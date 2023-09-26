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
            FormLR1 lr1 = new FormLR1();
            lr1.MdiParent = this;
            lr1.Show();
        }

        private void LR2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLR2 lr2 = new FormLR2();
            lr2.MdiParent = this;
            lr2.Show();
        }

        private void LR3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLR3 lr3 = new FormLR3();
            lr3.MdiParent = this;
            lr3.Show();
        }
    }
}
