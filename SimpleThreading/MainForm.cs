using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleThreading
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnThreading_Click(object sender, EventArgs e)
        {
            Threading f = new Threading();
            f.ShowDialog();
        }

        private void btnFileTransfer_Click(object sender, EventArgs e)
        {
            FileTransfer f = new FileTransfer();
            f.ShowDialog();
        }
    }
}
