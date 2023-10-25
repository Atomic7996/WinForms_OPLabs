namespace WinForms_OPLabs
{
    partial class FormLR7
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
            btnAdd = new Button();
            btnClear = new Button();
            nudPassengers = new NumericUpDown();
            label4 = new Label();
            rtbInfo = new RichTextBox();
            label7 = new Label();
            dtpLastMaintenanceDate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            tbBoardNumber = new TextBox();
            tbModel = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPassengers).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(362, 167);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 60);
            btnAdd.TabIndex = 139;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(113, 395);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 40);
            btnClear.TabIndex = 140;
            btnClear.Text = "Очистить ввод";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // nudPassengers
            // 
            nudPassengers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudPassengers.Location = new Point(182, 225);
            nudPassengers.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPassengers.Name = "nudPassengers";
            nudPassengers.Size = new Size(150, 29);
            nudPassengers.TabIndex = 133;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 225);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 132;
            label4.Text = "Кол-во пассажиров";
            // 
            // rtbInfo
            // 
            rtbInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbInfo.Location = new Point(468, 100);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(311, 205);
            rtbInfo.TabIndex = 131;
            rtbInfo.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 181);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 130;
            label7.Text = "Дата последнего ТО";
            // 
            // dtpLastMaintenanceDate
            // 
            dtpLastMaintenanceDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpLastMaintenanceDate.Location = new Point(182, 181);
            dtpLastMaintenanceDate.MinDate = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            dtpLastMaintenanceDate.Name = "dtpLastMaintenanceDate";
            dtpLastMaintenanceDate.Size = new Size(150, 29);
            dtpLastMaintenanceDate.TabIndex = 126;
            dtpLastMaintenanceDate.Value = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 140);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 129;
            label3.Text = "Номер модели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 100);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 128;
            label2.Text = "Бортовой номер";
            // 
            // tbBoardNumber
            // 
            tbBoardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBoardNumber.Location = new Point(182, 100);
            tbBoardNumber.Name = "tbBoardNumber";
            tbBoardNumber.Size = new Size(150, 29);
            tbBoardNumber.TabIndex = 124;
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.Location = new Point(182, 140);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(150, 29);
            tbModel.TabIndex = 125;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(284, 26);
            label1.Name = "label1";
            label1.Size = new Size(235, 45);
            label1.TabIndex = 127;
            label1.Text = "Полиморфизм";
            // 
            // FormLR7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(nudPassengers);
            Controls.Add(label4);
            Controls.Add(rtbInfo);
            Controls.Add(label7);
            Controls.Add(dtpLastMaintenanceDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbBoardNumber);
            Controls.Add(tbModel);
            Controls.Add(label1);
            Name = "FormLR7";
            Text = "Лабораторная работа 7";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)nudPassengers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnClear;
        private NumericUpDown nudPassengers;
        private Label label4;
        private RichTextBox rtbInfo;
        private Label label7;
        private DateTimePicker dtpLastMaintenanceDate;
        private Label label3;
        private Label label2;
        private TextBox tbBoardNumber;
        private TextBox tbModel;
        private Label label1;
    }
}