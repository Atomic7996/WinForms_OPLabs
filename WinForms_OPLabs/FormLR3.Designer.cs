namespace WinForms_OPLabs
{
    partial class FormLR3
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
            dtpLastMaintenanceDate = new DateTimePicker();
            nudEngineCount = new NumericUpDown();
            tbName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudEngineCount).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(344, 89);
            label4.Name = "label4";
            label4.Size = new Size(196, 21);
            label4.TabIndex = 51;
            label4.Text = "Информация о самолетах";
            // 
            // btnShowList
            // 
            btnShowList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowList.Location = new Point(344, 381);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(120, 60);
            btnShowList.TabIndex = 45;
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
            btnClear.TabIndex = 44;
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
            label3.TabIndex = 50;
            label3.Text = "Номер модели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 49;
            label2.Text = "Бортовой номер";
            // 
            // tbBoardNumber
            // 
            tbBoardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBoardNumber.Location = new Point(173, 113);
            tbBoardNumber.Name = "tbBoardNumber";
            tbBoardNumber.Size = new Size(150, 29);
            tbBoardNumber.TabIndex = 1;
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.Location = new Point(173, 153);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(150, 29);
            tbModel.TabIndex = 2;
            // 
            // rtbList
            // 
            rtbList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbList.Location = new Point(344, 113);
            rtbList.Name = "rtbList";
            rtbList.Size = new Size(444, 240);
            rtbList.TabIndex = 47;
            rtbList.Text = "";
            // 
            // cbForPassengers
            // 
            cbForPassengers.AutoSize = true;
            cbForPassengers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbForPassengers.Location = new Point(12, 198);
            cbForPassengers.Name = "cbForPassengers";
            cbForPassengers.Size = new Size(243, 25);
            cbForPassengers.TabIndex = 41;
            cbForPassengers.Text = "Для пассажирских перевозок ";
            cbForPassengers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 45);
            label1.TabIndex = 48;
            label1.Text = "Свойства классов";
            // 
            // dtpLastMaintenanceDate
            // 
            dtpLastMaintenanceDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpLastMaintenanceDate.Location = new Point(173, 324);
            dtpLastMaintenanceDate.MinDate = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            dtpLastMaintenanceDate.Name = "dtpLastMaintenanceDate";
            dtpLastMaintenanceDate.Size = new Size(150, 29);
            dtpLastMaintenanceDate.TabIndex = 3;
            dtpLastMaintenanceDate.Value = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            // 
            // nudEngineCount
            // 
            nudEngineCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudEngineCount.Location = new Point(173, 280);
            nudEngineCount.Name = "nudEngineCount";
            nudEngineCount.Size = new Size(150, 29);
            nudEngineCount.TabIndex = 52;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(173, 238);
            tbName.Name = "tbName";
            tbName.Size = new Size(150, 29);
            tbName.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 238);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 55;
            label5.Text = "Название";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 280);
            label6.Name = "label6";
            label6.Size = new Size(143, 21);
            label6.TabIndex = 56;
            label6.Text = "Кол-во двигателей";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 324);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 57;
            label7.Text = "Дата последнего ТО";
            // 
            // FormLR3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbName);
            Controls.Add(nudEngineCount);
            Controls.Add(dtpLastMaintenanceDate);
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
            Name = "FormLR3";
            Text = "Лабораторная работа 3";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)nudEngineCount).EndInit();
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
        private DateTimePicker dtpLastMaintenanceDate;
        private NumericUpDown nudEngineCount;
        private TextBox tbName;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}