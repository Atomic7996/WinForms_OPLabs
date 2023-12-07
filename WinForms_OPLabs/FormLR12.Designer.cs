namespace WinForms_OPLabs
{
    partial class FormLR12
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
            btnShowList = new Button();
            rtbInfo = new RichTextBox();
            btnIndex = new Button();
            lbPetrols = new ListBox();
            SuspendLayout();
            // 
            // btnShowList
            // 
            btnShowList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowList.Location = new Point(74, 361);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(120, 60);
            btnShowList.TabIndex = 5;
            btnShowList.Text = "Индексатор";
            btnShowList.UseVisualStyleBackColor = true;
            btnShowList.Click += btnShowList_Click;
            // 
            // rtbInfo
            // 
            rtbInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbInfo.Location = new Point(392, 72);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(368, 227);
            rtbInfo.TabIndex = 21;
            rtbInfo.Text = "";
            // 
            // btnIndex
            // 
            btnIndex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIndex.Location = new Point(592, 361);
            btnIndex.Name = "btnIndex";
            btnIndex.Size = new Size(138, 60);
            btnIndex.TabIndex = 22;
            btnIndex.Text = "Многомерный индексатор";
            btnIndex.UseVisualStyleBackColor = true;
            btnIndex.Click += btnIndex_Click;
            // 
            // lbPetrols
            // 
            lbPetrols.FormattingEnabled = true;
            lbPetrols.ItemHeight = 15;
            lbPetrols.Location = new Point(40, 72);
            lbPetrols.Name = "lbPetrols";
            lbPetrols.Size = new Size(304, 229);
            lbPetrols.TabIndex = 23;
            // 
            // FormLR12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbPetrols);
            Controls.Add(btnIndex);
            Controls.Add(rtbInfo);
            Controls.Add(btnShowList);
            Name = "FormLR12";
            Text = "Лабораторная работа 12";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowList;
        private RichTextBox rtbInfo;
        private Button btnIndex;
        private ListBox lbPetrols;
    }
}