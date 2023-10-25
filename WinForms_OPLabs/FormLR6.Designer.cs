namespace WinForms_OPLabs
{
    partial class FormLR6
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
            rtbInfo = new RichTextBox();
            label7 = new Label();
            dtpLastMaintenanceDate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            tbBoardNumber = new TextBox();
            tbModel = new TextBox();
            label1 = new Label();
            label4 = new Label();
            nudPassengers = new NumericUpDown();
            cbForPassengers = new CheckBox();
            nudWeight = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            tbLicense = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPassengers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            SuspendLayout();
            // 
            // rtbInfo
            // 
            rtbInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbInfo.Location = new Point(468, 104);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(311, 205);
            rtbInfo.TabIndex = 113;
            rtbInfo.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 185);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 112;
            label7.Text = "Дата последнего ТО";
            // 
            // dtpLastMaintenanceDate
            // 
            dtpLastMaintenanceDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpLastMaintenanceDate.Location = new Point(182, 185);
            dtpLastMaintenanceDate.MinDate = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            dtpLastMaintenanceDate.Name = "dtpLastMaintenanceDate";
            dtpLastMaintenanceDate.Size = new Size(150, 29);
            dtpLastMaintenanceDate.TabIndex = 106;
            dtpLastMaintenanceDate.Value = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 144);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 111;
            label3.Text = "Номер модели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 104);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 110;
            label2.Text = "Бортовой номер";
            // 
            // tbBoardNumber
            // 
            tbBoardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBoardNumber.Location = new Point(182, 104);
            tbBoardNumber.Name = "tbBoardNumber";
            tbBoardNumber.Size = new Size(150, 29);
            tbBoardNumber.TabIndex = 104;
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.Location = new Point(182, 144);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(150, 29);
            tbModel.TabIndex = 105;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(39, 19);
            label1.Name = "label1";
            label1.Size = new Size(719, 45);
            label1.TabIndex = 109;
            label1.Text = "Наследование классов. Преобразование типов";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 288);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 115;
            label4.Text = "Кол-во пассажиров";
            // 
            // nudPassengers
            // 
            nudPassengers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudPassengers.Location = new Point(193, 288);
            nudPassengers.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPassengers.Name = "nudPassengers";
            nudPassengers.Size = new Size(150, 29);
            nudPassengers.TabIndex = 116;
            // 
            // cbForPassengers
            // 
            cbForPassengers.AutoSize = true;
            cbForPassengers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbForPassengers.Location = new Point(21, 220);
            cbForPassengers.Name = "cbForPassengers";
            cbForPassengers.Size = new Size(243, 25);
            cbForPassengers.TabIndex = 117;
            cbForPassengers.Text = "Для пассажирских перевозок ";
            cbForPassengers.UseVisualStyleBackColor = true;
            cbForPassengers.CheckedChanged += cbForPassengers_CheckedChanged;
            // 
            // nudWeight
            // 
            nudWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudWeight.Location = new Point(193, 328);
            nudWeight.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(150, 29);
            nudWeight.TabIndex = 119;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 328);
            label5.Name = "label5";
            label5.Size = new Size(167, 21);
            label5.TabIndex = 118;
            label5.Text = "Грузоподъемность, кг";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 364);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 121;
            label6.Text = "Лицензия";
            // 
            // tbLicense
            // 
            tbLicense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbLicense.Location = new Point(193, 364);
            tbLicense.Name = "tbLicense";
            tbLicense.Size = new Size(150, 29);
            tbLicense.TabIndex = 120;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(362, 171);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 60);
            btnAdd.TabIndex = 122;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(113, 399);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 40);
            btnClear.TabIndex = 123;
            btnClear.Text = "Очистить ввод";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FormLR6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(label6);
            Controls.Add(tbLicense);
            Controls.Add(nudWeight);
            Controls.Add(label5);
            Controls.Add(cbForPassengers);
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
            Name = "FormLR6";
            Text = "Лабораторная работа 6";
            WindowState = FormWindowState.Maximized;
            Load += FormLR6_Load;
            ((System.ComponentModel.ISupportInitialize)nudPassengers).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtbInfo;
        private Label label7;
        private DateTimePicker dtpLastMaintenanceDate;
        private Label label3;
        private Label label2;
        private TextBox tbBoardNumber;
        private TextBox tbModel;
        private Label label1;
        private Label label4;
        private NumericUpDown nudPassengers;
        private CheckBox cbForPassengers;
        private NumericUpDown nudWeight;
        private Label label5;
        private Label label6;
        private TextBox tbLicense;
        private Button btnAdd;
        private Button btnClear;
    }
}