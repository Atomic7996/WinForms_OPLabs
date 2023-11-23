namespace WinForms_OPLabs
{
    partial class FormLR10
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
            label6 = new Label();
            nudFuel = new NumericUpDown();
            label4 = new Label();
            btnShowList = new Button();
            btnClear = new Button();
            label3 = new Label();
            label2 = new Label();
            tbBoardNumber = new TextBox();
            tbModel = new TextBox();
            label1 = new Label();
            rtbList = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)nudFuel).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 197);
            label6.Name = "label6";
            label6.Size = new Size(121, 21);
            label6.TabIndex = 72;
            label6.Text = "Кол-во топлива";
            // 
            // nudFuel
            // 
            nudFuel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudFuel.Location = new Point(173, 197);
            nudFuel.Name = "nudFuel";
            nudFuel.Size = new Size(150, 29);
            nudFuel.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(344, 89);
            label4.Name = "label4";
            label4.Size = new Size(196, 21);
            label4.TabIndex = 70;
            label4.Text = "Информация о самолетах";
            // 
            // btnShowList
            // 
            btnShowList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowList.Location = new Point(344, 381);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(120, 60);
            btnShowList.TabIndex = 64;
            btnShowList.Text = "Вывод списка самолетов";
            btnShowList.UseVisualStyleBackColor = true;
            btnShowList.Click += btnShowList_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(12, 378);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 60);
            btnClear.TabIndex = 65;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 153);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 69;
            label3.Text = "Номер модели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 68;
            label2.Text = "Бортовой номер";
            // 
            // tbBoardNumber
            // 
            tbBoardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBoardNumber.Location = new Point(173, 113);
            tbBoardNumber.Name = "tbBoardNumber";
            tbBoardNumber.Size = new Size(150, 29);
            tbBoardNumber.TabIndex = 58;
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.Location = new Point(173, 153);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(150, 29);
            tbModel.TabIndex = 59;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 45);
            label1.TabIndex = 67;
            label1.Text = "Интерфейсы";
            // 
            // rtbList
            // 
            rtbList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbList.Location = new Point(344, 113);
            rtbList.Name = "rtbList";
            rtbList.Size = new Size(444, 240);
            rtbList.TabIndex = 66;
            rtbList.Text = "";
            // 
            // FormLR10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(nudFuel);
            Controls.Add(label4);
            Controls.Add(btnShowList);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbBoardNumber);
            Controls.Add(tbModel);
            Controls.Add(rtbList);
            Controls.Add(label1);
            Name = "FormLR10";
            Text = "Лабораторная работа 10";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)nudFuel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private NumericUpDown nudFuel;
        private Label label4;
        private Button btnShowList;
        private Button btnClear;
        private Label label3;
        private Label label2;
        private TextBox tbBoardNumber;
        private TextBox tbModel;
        private Label label1;
        private RichTextBox rtbList;
    }
}