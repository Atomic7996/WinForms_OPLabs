namespace WinForms_OPLabs
{
    partial class FormLR8
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
            rtbInfo = new RichTextBox();
            label7 = new Label();
            dtpLastMaintenanceDate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            tbBoardNumber = new TextBox();
            tbModel = new TextBox();
            label1 = new Label();
            btnImage = new Button();
            label5 = new Label();
            tbAirplaneName = new TextBox();
            label6 = new Label();
            tbAirplaneId = new TextBox();
            pbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(362, 162);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 60);
            btnAdd.TabIndex = 151;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(95, 346);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 40);
            btnClear.TabIndex = 152;
            btnClear.Text = "Очистить ввод";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // rtbInfo
            // 
            rtbInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbInfo.Location = new Point(468, 95);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(311, 205);
            rtbInfo.TabIndex = 148;
            rtbInfo.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 243);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 147;
            label7.Text = "Дата последнего ТО";
            // 
            // dtpLastMaintenanceDate
            // 
            dtpLastMaintenanceDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpLastMaintenanceDate.Location = new Point(182, 243);
            dtpLastMaintenanceDate.MinDate = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            dtpLastMaintenanceDate.Name = "dtpLastMaintenanceDate";
            dtpLastMaintenanceDate.Size = new Size(150, 29);
            dtpLastMaintenanceDate.TabIndex = 143;
            dtpLastMaintenanceDate.Value = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 135);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 146;
            label3.Text = "Номер модели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 95);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 145;
            label2.Text = "Бортовой номер";
            // 
            // tbBoardNumber
            // 
            tbBoardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBoardNumber.Location = new Point(182, 95);
            tbBoardNumber.Name = "tbBoardNumber";
            tbBoardNumber.Size = new Size(150, 29);
            tbBoardNumber.TabIndex = 141;
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.Location = new Point(182, 135);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(150, 29);
            tbModel.TabIndex = 142;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(241, 21);
            label1.Name = "label1";
            label1.Size = new Size(321, 45);
            label1.TabIndex = 144;
            label1.Text = "Абстрактные классы";
            // 
            // btnImage
            // 
            btnImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImage.Location = new Point(401, 346);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(127, 60);
            btnImage.TabIndex = 153;
            btnImage.Text = "NameText() в окне";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 170);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 156;
            label5.Text = "Название";
            // 
            // tbAirplaneName
            // 
            tbAirplaneName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbAirplaneName.Location = new Point(182, 170);
            tbAirplaneName.Name = "tbAirplaneName";
            tbAirplaneName.Size = new Size(150, 29);
            tbAirplaneName.TabIndex = 155;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 208);
            label6.Name = "label6";
            label6.Size = new Size(125, 21);
            label6.TabIndex = 158;
            label6.Text = "Идентификатор";
            // 
            // tbAirplaneId
            // 
            tbAirplaneId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbAirplaneId.Location = new Point(182, 208);
            tbAirplaneId.Name = "tbAirplaneId";
            tbAirplaneId.Size = new Size(150, 29);
            tbAirplaneId.TabIndex = 157;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(552, 326);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(155, 93);
            pbImage.TabIndex = 154;
            pbImage.TabStop = false;
            // 
            // FormLR8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(tbAirplaneId);
            Controls.Add(label5);
            Controls.Add(tbAirplaneName);
            Controls.Add(pbImage);
            Controls.Add(btnImage);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(rtbInfo);
            Controls.Add(label7);
            Controls.Add(dtpLastMaintenanceDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbBoardNumber);
            Controls.Add(tbModel);
            Controls.Add(label1);
            Name = "FormLR8";
            Text = "Лабораторная работа 8";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnClear;
        private RichTextBox rtbInfo;
        private Label label7;
        private DateTimePicker dtpLastMaintenanceDate;
        private Label label3;
        private Label label2;
        private TextBox tbBoardNumber;
        private TextBox tbModel;
        private Label label1;
        private Button btnImage;
        private Label label5;
        private TextBox tbAirplaneName;
        private Label label6;
        private TextBox tbAirplaneId;
        private PictureBox pbImage;
    }
}