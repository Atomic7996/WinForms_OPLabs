namespace WinForms_OPLabs
{
    partial class FormLR2
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
            label4 = new Label();
            btnShowList = new Button();
            btnClear = new Button();
            label3 = new Label();
            label2 = new Label();
            tbBoardNumber = new TextBox();
            tbModel = new TextBox();
            rtbList = new RichTextBox();
            cbForPassengers = new CheckBox();
            label1 = new Label();
            btnStruct = new Button();
            tbFIO = new TextBox();
            nudAge = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(344, 88);
            label4.Name = "label4";
            label4.Size = new Size(196, 21);
            label4.TabIndex = 36;
            label4.Text = "Информация о самолетах";
            // 
            // btnShowList
            // 
            btnShowList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowList.Location = new Point(344, 380);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(120, 60);
            btnShowList.TabIndex = 7;
            btnShowList.Text = "Вывод списка самолетов";
            btnShowList.UseVisualStyleBackColor = true;
            btnShowList.Click += btnShowList_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(173, 380);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 6;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 35;
            label3.Text = "Номер модели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 34;
            label2.Text = "Бортовой номер";
            // 
            // tbBoardNumber
            // 
            tbBoardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBoardNumber.Location = new Point(173, 112);
            tbBoardNumber.Name = "tbBoardNumber";
            tbBoardNumber.Size = new Size(150, 29);
            tbBoardNumber.TabIndex = 1;
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.Location = new Point(173, 152);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(150, 29);
            tbModel.TabIndex = 2;
            // 
            // rtbList
            // 
            rtbList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbList.Location = new Point(344, 112);
            rtbList.Name = "rtbList";
            rtbList.Size = new Size(444, 227);
            rtbList.TabIndex = 9;
            rtbList.Text = "";
            // 
            // cbForPassengers
            // 
            cbForPassengers.AutoSize = true;
            cbForPassengers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbForPassengers.Location = new Point(12, 197);
            cbForPassengers.Name = "cbForPassengers";
            cbForPassengers.Size = new Size(243, 25);
            cbForPassengers.TabIndex = 3;
            cbForPassengers.Text = "Для пассажирских перевозок ";
            cbForPassengers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(143, 9);
            label1.Name = "label1";
            label1.Size = new Size(489, 45);
            label1.TabIndex = 32;
            label1.Text = "Архитектура классов и структур";
            // 
            // btnStruct
            // 
            btnStruct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStruct.Location = new Point(568, 378);
            btnStruct.Name = "btnStruct";
            btnStruct.Size = new Size(220, 60);
            btnStruct.TabIndex = 8;
            btnStruct.Text = "Вывод информации о пилоте";
            btnStruct.UseVisualStyleBackColor = true;
            btnStruct.Click += btnStruct_Click;
            // 
            // tbFIO
            // 
            tbFIO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbFIO.Location = new Point(173, 275);
            tbFIO.Name = "tbFIO";
            tbFIO.Size = new Size(150, 29);
            tbFIO.TabIndex = 4;
            // 
            // nudAge
            // 
            nudAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudAge.Location = new Point(173, 316);
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(150, 29);
            nudAge.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 275);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 37;
            label5.Text = "ФИО пилота";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 316);
            label6.Name = "label6";
            label6.Size = new Size(101, 21);
            label6.TabIndex = 38;
            label6.Text = "Стаж пилота";
            // 
            // FormLR2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(nudAge);
            Controls.Add(tbFIO);
            Controls.Add(btnStruct);
            Controls.Add(label4);
            Controls.Add(btnShowList);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbBoardNumber);
            Controls.Add(tbModel);
            Controls.Add(rtbList);
            Controls.Add(cbForPassengers);
            Controls.Add(label1);
            Name = "FormLR2";
            Text = "Лабораторная работа 2";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnShowList;
        private Button btnClear;
        private Label label3;
        private Label label2;
        private TextBox tbBoardNumber;
        private TextBox tbModel;
        private RichTextBox rtbList;
        private CheckBox cbForPassengers;
        private Label label1;
        private Button btnStruct;
        private TextBox tbFIO;
        private NumericUpDown nudAge;
        private Label label5;
        private Label label6;
    }
}