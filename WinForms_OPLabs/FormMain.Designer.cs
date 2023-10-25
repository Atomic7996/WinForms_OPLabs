namespace WinForms_OPLabs
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            LRToolStripMenuItem = new ToolStripMenuItem();
            LR1ToolStripMenuItem = new ToolStripMenuItem();
            LR2ToolStripMenuItem = new ToolStripMenuItem();
            LR3ToolStripMenuItem = new ToolStripMenuItem();
            LR4ToolStripMenuItem = new ToolStripMenuItem();
            LR5ToolStripMenuItem = new ToolStripMenuItem();
            LR6ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { LRToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(864, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // LRToolStripMenuItem
            // 
            LRToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LR1ToolStripMenuItem, LR2ToolStripMenuItem, LR3ToolStripMenuItem, LR4ToolStripMenuItem, LR5ToolStripMenuItem, LR6ToolStripMenuItem });
            LRToolStripMenuItem.Name = "LRToolStripMenuItem";
            LRToolStripMenuItem.Size = new Size(145, 20);
            LRToolStripMenuItem.Text = "Лабораторные работы";
            // 
            // LR1ToolStripMenuItem
            // 
            LR1ToolStripMenuItem.Name = "LR1ToolStripMenuItem";
            LR1ToolStripMenuItem.Size = new Size(203, 22);
            LR1ToolStripMenuItem.Text = "Лабораторная работа 1";
            LR1ToolStripMenuItem.Click += LR1ToolStripMenuItem_Click;
            // 
            // LR2ToolStripMenuItem
            // 
            LR2ToolStripMenuItem.Name = "LR2ToolStripMenuItem";
            LR2ToolStripMenuItem.Size = new Size(203, 22);
            LR2ToolStripMenuItem.Text = "Лабораторная работа 2";
            LR2ToolStripMenuItem.Click += LR2ToolStripMenuItem_Click;
            // 
            // LR3ToolStripMenuItem
            // 
            LR3ToolStripMenuItem.Name = "LR3ToolStripMenuItem";
            LR3ToolStripMenuItem.Size = new Size(203, 22);
            LR3ToolStripMenuItem.Text = "Лабораторная работа 3";
            LR3ToolStripMenuItem.Click += LR3ToolStripMenuItem_Click;
            // 
            // LR4ToolStripMenuItem
            // 
            LR4ToolStripMenuItem.Name = "LR4ToolStripMenuItem";
            LR4ToolStripMenuItem.Size = new Size(203, 22);
            LR4ToolStripMenuItem.Text = "Лабораторная работа 4";
            LR4ToolStripMenuItem.Click += LR4ToolStripMenuItem_Click;
            // 
            // LR5ToolStripMenuItem
            // 
            LR5ToolStripMenuItem.Name = "LR5ToolStripMenuItem";
            LR5ToolStripMenuItem.Size = new Size(203, 22);
            LR5ToolStripMenuItem.Text = "Лабораторная работа 5";
            LR5ToolStripMenuItem.Click += LR5ToolStripMenuItem_Click;
            // 
            // LR6ToolStripMenuItem
            // 
            LR6ToolStripMenuItem.Name = "LR6ToolStripMenuItem";
            LR6ToolStripMenuItem.Size = new Size(203, 22);
            LR6ToolStripMenuItem.Text = "Лабораторная работа 6";
            LR6ToolStripMenuItem.Click += LR6ToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 521);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторные работы \"Основы программирования\"";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem LRToolStripMenuItem;
        private ToolStripMenuItem LR1ToolStripMenuItem;
        private ToolStripMenuItem LR2ToolStripMenuItem;
        private ToolStripMenuItem LR3ToolStripMenuItem;
        private ToolStripMenuItem LR4ToolStripMenuItem;
        private ToolStripMenuItem LR5ToolStripMenuItem;
        private ToolStripMenuItem LR6ToolStripMenuItem;
    }
}