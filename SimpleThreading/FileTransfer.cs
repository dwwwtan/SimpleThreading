using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimpleThreading
{
    public partial class FileTransfer : Form
    {
        public FileTransfer()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFile(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sourceFileName = txtSource.Text;
            string destinationFileName = txtDestination.Text;

            string sourceFilePath = Path.GetFullPath(sourceFileName);
            string destinationFilePath = Path.GetFullPath(destinationFileName);

            if (File.Exists(sourceFilePath))
            {
                if (File.Exists(destinationFilePath))
                {
                    DialogResult result = MessageBox.Show("The destination file already exists. Do you want to overwrite it?", "File Exists", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("File copy operation canceled.", "Copy File");
                        return;
                    }
                }

                // Create a new thread for the file copy operation
                Thread copyThread = new Thread(() =>
                {
                    try
                    {
                        bool success = CopyFile(sourceFilePath, destinationFilePath, false);
                        if (success)
                            MessageBox.Show($"File copied successfully from {sourceFilePath} to {destinationFilePath}", "Copy File");
                        else
                        {
                            int error = Marshal.GetLastWin32Error();
                            MessageBox.Show($"Error copying file. Error code: {error}", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error copying file: {ex.Message}", "Error");
                    }
                });

                // Start the thread
                copyThread.Start();
            }
            else
            {
                MessageBox.Show("Source file not found!", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
