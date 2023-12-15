using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleThreading
{
    public partial class Threading : Form
    {
        public Threading()
        {
            InitializeComponent();
        }

        private List<Label> threadLabels = new List<Label>();
        private int singleThreadCount = 0;
        private int multiThreadCount = 0;

        #region Single Thread
        private void btnGoSingleThread_Click(object sender, EventArgs e)
        {
            singleThreadCount++;
            lblSingleThreadCount.Text = $"Task done (Single): {singleThreadCount}";

            int.TryParse(textBox1.Text, out int iteration);
            int.TryParse(textBox2.Text, out int sleepDuration);

            btnGoSingleThread.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            for (int i = 0; i <= iteration; i++)
            {
                lblCounter.Text = i.ToString();
                lblCounter.Refresh();
                Thread.Sleep(sleepDuration);
            }

            btnGoSingleThread.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }
        #endregion

        #region Multi Thread
        private void btnGoMultiThread_Click(object sender, EventArgs e)
        {
            multiThreadCount++;
            lblMultiThreadCount.Text = $"Task done (Multi): {multiThreadCount}";

            //Reading from UI
            int.TryParse(textBox1.Text, out int iteration);
            int.TryParse(textBox2.Text, out int sleepDuration);

            //Setting up label
            Label l = new Label();
            l.Text = DateTime.Now.ToLongTimeString();
            threadLabels.Add(l);

            l.Top = (panel1.Controls.Count) * l.Height + 20;
            l.Left = 5;

            //Adding the label we created so it is actually on the UI
            this.panel1.Controls.Add(l);

            //Creating Actual Thread
            Task.Factory.StartNew(() =>
            {
                //doing some stuff in the thread
                for (int i = 0; i <= iteration; i++)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        l.Text = i.ToString();
                    });

                    Thread.Sleep(sleepDuration);
                }
            });
        }
        #endregion

        #region Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (var label in threadLabels)
            {
                panel1.Controls.Remove(label);
            }
            threadLabels.Clear();

            textBox1.Text = "";
            textBox2.Text = "";
            lblCounter.Text = "[MY COUNTER]";
            lblSingleThreadCount.Text = "Single count = 0";
            lblMultiThreadCount.Text = "Multi count = 0";

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            btnGoSingleThread.Enabled = true;
            btnGoMultiThread.Enabled = true;

            singleThreadCount = 0;
            multiThreadCount = 0;
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We need to kill any running threads
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
