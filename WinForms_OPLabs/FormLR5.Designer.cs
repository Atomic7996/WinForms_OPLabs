namespace WinForms_OPLabs
{
    partial class FormLR5
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
            dtpLastMaintenanceDate = new DateTimePicker();
            btnRead = new Button();
            btnWrite = new Button();
            label3 = new Label();
            label2 = new Label();
            tbBoardNumber = new TextBox();
            tbModel = new TextBox();
            label1 = new Label();
            rtbInfo = new RichTextBox();
            btnMethod = new Button();
            lbAirplanes = new ListBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 174);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 100;
            label7.Text = "Дата последнего ТО";
            // 
            // dtpLastMaintenanceDate
            // 
            dtpLastMaintenanceDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLastMaintenanceDate.Format = DateTimePickerFormat.Short;
            dtpLastMaintenanceDate.Location = new Point(173, 174);
            dtpLastMaintenanceDate.MinDate = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            dtpLastMaintenanceDate.Name = "dtpLastMaintenanceDate";
            dtpLastMaintenanceDate.Size = new Size(150, 29);
            dtpLastMaintenanceDate.TabIndex = 91;
            dtpLastMaintenanceDate.Value = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRead.Location = new Point(670, 267);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(100, 60);
            btnRead.TabIndex = 92;
            btnRead.Text = "Прочитать";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWrite.Location = new Point(459, 267);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(100, 60);
            btnWrite.TabIndex = 93;
            btnWrite.Text = "Записать";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 96;
            label3.Text = "Номер модели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 95;
            label2.Text = "Бортовой номер";
            // 
            // tbBoardNumber
            // 
            tbBoardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBoardNumber.Location = new Point(173, 93);
            tbBoardNumber.Name = "tbBoardNumber";
            tbBoardNumber.Size = new Size(150, 29);
            tbBoardNumber.TabIndex = 86;
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.Location = new Point(173, 133);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(150, 29);
            tbModel.TabIndex = 87;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(616, 45);
            label1.TabIndex = 94;
            label1.Text = "Источники данных. Параметры методов";
            // 
            // rtbInfo
            // 
            rtbInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbInfo.Location = new Point(459, 93);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(311, 154);
            rtbInfo.TabIndex = 101;
            rtbInfo.Text = "";
            // 
            // btnMethod
            // 
            btnMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMethod.Location = new Point(552, 359);
            btnMethod.Name = "btnMethod";
            btnMethod.Size = new Size(123, 60);
            btnMethod.TabIndex = 102;
            btnMethod.Text = "Метод с параметрами";
            btnMethod.UseVisualStyleBackColor = true;
            btnMethod.Click += btnMethod_Click;
            // 
            // lbAirplanes
            // 
            lbAirplanes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAirplanes.FormattingEnabled = true;
            lbAirplanes.ItemHeight = 21;
            lbAirplanes.Location = new Point(12, 236);
            lbAirplanes.Name = "lbAirplanes";
            lbAirplanes.Size = new Size(311, 151);
            lbAirplanes.TabIndex = 103;
            // 
            // FormLR5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbAirplanes);
            Controls.Add(btnMethod);
            Controls.Add(rtbInfo);
            Controls.Add(label7);
            Controls.Add(dtpLastMaintenanceDate);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbBoardNumber);
            Controls.Add(tbModel);
            Controls.Add(label1);
            Name = "FormLR5";
            Text = "FormLR5";
            WindowState = FormWindowState.Maximized;
            Load += FormLR5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private DateTimePicker dtpLastMaintenanceDate;
        private Button btnRead;
        private Button btnWrite;
        private Label label3;
        private Label label2;
        private TextBox tbBoardNumber;
        private TextBox tbModel;
        private Label label1;
        private RichTextBox rtbInfo;
        private Button btnMethod;
        private ListBox lbAirplanes;
    }
}