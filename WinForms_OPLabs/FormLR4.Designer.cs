namespace WinForms_OPLabs
{
    partial class FormLR4
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tbName = new TextBox();
            nudEngineCount = new NumericUpDown();
            dtpLastMaintenanceDate = new DateTimePicker();
            label4 = new Label();
            btnAdd = new Button();
            btnClear = new Button();
            label3 = new Label();
            label2 = new Label();
            tbBoardNumber = new TextBox();
            tbModel = new TextBox();
            cbForPassengers = new CheckBox();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tbName2 = new TextBox();
            nudEngineCount2 = new NumericUpDown();
            dtpLastMaintenanceDate2 = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            tbBoardNumber2 = new TextBox();
            tbModel2 = new TextBox();
            cbForPassengers2 = new CheckBox();
            lbAirplanes = new ListBox();
            btnImage = new Button();
            pbImage = new PictureBox();
            btnImageForm = new Button();
            ((System.ComponentModel.ISupportInitialize)nudEngineCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEngineCount2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 281);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 73;
            label7.Text = "Дата последнего ТО";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 237);
            label6.Name = "label6";
            label6.Size = new Size(143, 21);
            label6.TabIndex = 72;
            label6.Text = "Кол-во двигателей";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 71;
            label5.Text = "Название";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(173, 195);
            tbName.Name = "tbName";
            tbName.Size = new Size(150, 29);
            tbName.TabIndex = 61;
            // 
            // nudEngineCount
            // 
            nudEngineCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudEngineCount.Location = new Point(173, 237);
            nudEngineCount.Name = "nudEngineCount";
            nudEngineCount.Size = new Size(150, 29);
            nudEngineCount.TabIndex = 62;
            // 
            // dtpLastMaintenanceDate
            // 
            dtpLastMaintenanceDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpLastMaintenanceDate.Location = new Point(173, 281);
            dtpLastMaintenanceDate.MinDate = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            dtpLastMaintenanceDate.Name = "dtpLastMaintenanceDate";
            dtpLastMaintenanceDate.Size = new Size(150, 29);
            dtpLastMaintenanceDate.TabIndex = 63;
            dtpLastMaintenanceDate.Value = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(530, 33);
            label4.Name = "label4";
            label4.Size = new Size(141, 21);
            label4.TabIndex = 70;
            label4.Text = "Список самолетов";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(353, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 60);
            btnAdd.TabIndex = 64;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(12, 335);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 60);
            btnClear.TabIndex = 65;
            btnClear.Text = "Очистить ввод";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 69;
            label3.Text = "Номер модели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 68;
            label2.Text = "Бортовой номер";
            // 
            // tbBoardNumber
            // 
            tbBoardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBoardNumber.Location = new Point(173, 70);
            tbBoardNumber.Name = "tbBoardNumber";
            tbBoardNumber.Size = new Size(150, 29);
            tbBoardNumber.TabIndex = 58;
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.Location = new Point(173, 110);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(150, 29);
            tbModel.TabIndex = 59;
            // 
            // cbForPassengers
            // 
            cbForPassengers.AutoSize = true;
            cbForPassengers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbForPassengers.Location = new Point(12, 155);
            cbForPassengers.Name = "cbForPassengers";
            cbForPassengers.Size = new Size(243, 25);
            cbForPassengers.TabIndex = 60;
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
            label1.Size = new Size(263, 45);
            label1.TabIndex = 67;
            label1.Text = "Методы классов";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(477, 366);
            label8.Name = "label8";
            label8.Size = new Size(154, 21);
            label8.TabIndex = 84;
            label8.Text = "Дата последнего ТО";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(477, 322);
            label9.Name = "label9";
            label9.Size = new Size(143, 21);
            label9.TabIndex = 83;
            label9.Text = "Кол-во двигателей";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(477, 280);
            label10.Name = "label10";
            label10.Size = new Size(78, 21);
            label10.TabIndex = 82;
            label10.Text = "Название";
            // 
            // tbName2
            // 
            tbName2.Enabled = false;
            tbName2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbName2.Location = new Point(638, 280);
            tbName2.Name = "tbName2";
            tbName2.Size = new Size(150, 29);
            tbName2.TabIndex = 77;
            // 
            // nudEngineCount2
            // 
            nudEngineCount2.Enabled = false;
            nudEngineCount2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudEngineCount2.Location = new Point(638, 322);
            nudEngineCount2.Name = "nudEngineCount2";
            nudEngineCount2.Size = new Size(150, 29);
            nudEngineCount2.TabIndex = 78;
            // 
            // dtpLastMaintenanceDate2
            // 
            dtpLastMaintenanceDate2.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate2.Enabled = false;
            dtpLastMaintenanceDate2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate2.Format = DateTimePickerFormat.Short;
            dtpLastMaintenanceDate2.Location = new Point(638, 366);
            dtpLastMaintenanceDate2.MinDate = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            dtpLastMaintenanceDate2.Name = "dtpLastMaintenanceDate2";
            dtpLastMaintenanceDate2.Size = new Size(150, 29);
            dtpLastMaintenanceDate2.TabIndex = 79;
            dtpLastMaintenanceDate2.Value = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(477, 195);
            label11.Name = "label11";
            label11.Size = new Size(116, 21);
            label11.TabIndex = 81;
            label11.Text = "Номер модели";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(477, 155);
            label12.Name = "label12";
            label12.Size = new Size(129, 21);
            label12.TabIndex = 80;
            label12.Text = "Бортовой номер";
            // 
            // tbBoardNumber2
            // 
            tbBoardNumber2.Enabled = false;
            tbBoardNumber2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBoardNumber2.Location = new Point(638, 155);
            tbBoardNumber2.Name = "tbBoardNumber2";
            tbBoardNumber2.Size = new Size(150, 29);
            tbBoardNumber2.TabIndex = 74;
            // 
            // tbModel2
            // 
            tbModel2.Enabled = false;
            tbModel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel2.Location = new Point(638, 195);
            tbModel2.Name = "tbModel2";
            tbModel2.Size = new Size(150, 29);
            tbModel2.TabIndex = 75;
            // 
            // cbForPassengers2
            // 
            cbForPassengers2.AutoSize = true;
            cbForPassengers2.Enabled = false;
            cbForPassengers2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbForPassengers2.Location = new Point(477, 240);
            cbForPassengers2.Name = "cbForPassengers2";
            cbForPassengers2.Size = new Size(243, 25);
            cbForPassengers2.TabIndex = 76;
            cbForPassengers2.Text = "Для пассажирских перевозок ";
            cbForPassengers2.UseVisualStyleBackColor = true;
            // 
            // lbAirplanes
            // 
            lbAirplanes.FormattingEnabled = true;
            lbAirplanes.ItemHeight = 15;
            lbAirplanes.Location = new Point(477, 58);
            lbAirplanes.Name = "lbAirplanes";
            lbAirplanes.Size = new Size(311, 79);
            lbAirplanes.TabIndex = 85;
            // 
            // btnImage
            // 
            btnImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImage.Location = new Point(315, 418);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(127, 60);
            btnImage.TabIndex = 86;
            btnImage.Text = "ShowImage() в окне";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(477, 418);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(311, 185);
            pbImage.TabIndex = 87;
            pbImage.TabStop = false;
            // 
            // btnImageForm
            // 
            btnImageForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImageForm.Location = new Point(315, 543);
            btnImageForm.Name = "btnImageForm";
            btnImageForm.Size = new Size(127, 60);
            btnImageForm.TabIndex = 88;
            btnImageForm.Text = "ShowImage() в форме";
            btnImageForm.UseVisualStyleBackColor = true;
            btnImageForm.Click += btnImageForm_Click;
            // 
            // FormLR4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 633);
            Controls.Add(btnImageForm);
            Controls.Add(pbImage);
            Controls.Add(btnImage);
            Controls.Add(lbAirplanes);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(tbName2);
            Controls.Add(nudEngineCount2);
            Controls.Add(dtpLastMaintenanceDate2);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(tbBoardNumber2);
            Controls.Add(tbModel2);
            Controls.Add(cbForPassengers2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbName);
            Controls.Add(nudEngineCount);
            Controls.Add(dtpLastMaintenanceDate);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbBoardNumber);
            Controls.Add(tbModel);
            Controls.Add(cbForPassengers);
            Controls.Add(label1);
            Name = "FormLR4";
            Text = "Лабораторная работа 4";
            WindowState = FormWindowState.Maximized;
            Load += FormLR4_Load;
            ((System.ComponentModel.ISupportInitialize)nudEngineCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEngineCount2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbName;
        private NumericUpDown nudEngineCount;
        private DateTimePicker dtpLastMaintenanceDate;
        private Label label4;
        private Button btnAdd;
        private Button btnClear;
        private Label label3;
        private Label label2;
        private TextBox tbBoardNumber;
        private TextBox tbModel;
        private CheckBox cbForPassengers;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox tbName2;
        private NumericUpDown nudEngineCount2;
        private DateTimePicker dtpLastMaintenanceDate2;
        private Label label11;
        private Label label12;
        private TextBox tbBoardNumber2;
        private TextBox tbModel2;
        private CheckBox cbForPassengers2;
        private ListBox lbAirplanes;
        private Button btnImage;
        private PictureBox pbImage;
        private Button btnImageForm;
    }
}