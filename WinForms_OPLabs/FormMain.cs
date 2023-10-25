using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_OPLabs
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void LR1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLR1 lr = new FormLR1();
            lr.MdiParent = this;
            lr.Show();
        }

        private void LR2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLR2 lr = new FormLR2();
            lr.MdiParent = this;
            lr.Show();
        }

        private void LR3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLR3 lr = new FormLR3();
            lr.MdiParent = this;
            lr.Show();
        }

        private void LR4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLR4 lr = new FormLR4();
            lr.MdiParent = this;
            lr.Show();
        }

        private void LR5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLR5 lr = new FormLR5();
            lr.MdiParent = this;
            lr.Show();
        }

        private void LR6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLR6 lr = new FormLR6();
            lr.MdiParent = this;
            lr.Show();
        }

        private void LR7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLR7 lr = new FormLR7();
            lr.MdiParent = this;
            lr.Show();
        }
    }
}
