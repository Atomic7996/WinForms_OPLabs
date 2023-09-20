namespace WinForms_OPLabs
{
    partial class FormLR1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowList = new Button();
            btnClear = new Button();
            label3 = new Label();
            label2 = new Label();
            tbBoardNumber = new TextBox();
            tbModel = new TextBox();
            rtbList = new RichTextBox();
            cbForPassengers = new CheckBox();
            label1 = new Label();
            label4 = new Label();
            btnShowMethod = new Button();
            SuspendLayout();
            // 
            // btnShowList
            // 
            btnShowList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowList.Location = new Point(344, 378);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(120, 60);
            btnShowList.TabIndex = 4;
            btnShowList.Text = "Вывод списка самолетов";
            btnShowList.UseVisualStyleBackColor = true;
            btnShowList.Click += btnShowList_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(173, 378);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 3;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 24;
            label3.Text = "Номер модели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 23;
            label2.Text = "Бортовой номер";
            // 
            // tbBoardNumber
            // 
            tbBoardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBoardNumber.Location = new Point(173, 110);
            tbBoardNumber.Name = "tbBoardNumber";
            tbBoardNumber.Size = new Size(150, 29);
            tbBoardNumber.TabIndex = 0;
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.Location = new Point(173, 150);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(150, 29);
            tbModel.TabIndex = 1;
            // 
            // rtbList
            // 
            rtbList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbList.Location = new Point(344, 110);
            rtbList.Name = "rtbList";
            rtbList.Size = new Size(444, 227);
            rtbList.TabIndex = 20;
            rtbList.Text = "";
            // 
            // cbForPassengers
            // 
            cbForPassengers.AutoSize = true;
            cbForPassengers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbForPassengers.Location = new Point(12, 195);
            cbForPassengers.Name = "cbForPassengers";
            cbForPassengers.Size = new Size(243, 25);
            cbForPassengers.TabIndex = 2;
            cbForPassengers.Text = "Для пассажирских перевозок ";
            cbForPassengers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(457, 45);
            label1.TabIndex = 18;
            label1.Text = "Тестирование класса Airplane";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(344, 86);
            label4.Name = "label4";
            label4.Size = new Size(196, 21);
            label4.TabIndex = 25;
            label4.Text = "Информация о самолетах";
            // 
            // btnShowMethod
            // 
            btnShowMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowMethod.Location = new Point(568, 378);
            btnShowMethod.Name = "btnShowMethod";
            btnShowMethod.Size = new Size(220, 60);
            btnShowMethod.TabIndex = 5;
            btnShowMethod.Text = "Вывод работы метода  GetType()";
            btnShowMethod.UseVisualStyleBackColor = true;
            btnShowMethod.Click += btnShowMethod_Click;
            // 
            // FormLR1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowMethod);
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
            Name = "FormLR1";
            Text = "Лабораторная работа 1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowList;
        private Button btnClear;
        private Label label3;
        private Label label2;
        private TextBox tbBoardNumber;
        private TextBox tbModel;
        private RichTextBox rtbList;
        private CheckBox cbForPassengers;
        private Label label1;
        private Label label4;
        private Button btnShowMethod;
    }
}