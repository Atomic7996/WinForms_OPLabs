using ClassLibrary_OPLabsss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_OPLabs
{
    public partial class FormLR3 : Form
    {
        public FormLR3()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbBoardNumber.Clear();
            tbModel.Clear();
            cbForPassengers.Checked = false;
            tbName.Clear();
            nudEngineCount.Value = 0;
            dtpLastMaintenanceDate.Value = dtpLastMaintenanceDate.MinDate;
            rtbList.Clear();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            Airplane airplane1 = new Airplane("N-733PG", "A320", true, "Победа", 2, new DateTime(2020, 12, 25));
            Airplane airplane2 = new Airplane(tbBoardNumber.Text, tbModel.Text, cbForPassengers.Checked, tbName.Text, (int)nudEngineCount.Value, dtpLastMaintenanceDate.Value);

            rtbList.Clear();
            rtbList.Text += string.Format("Самолет: бортовой номер: {0}, модель: {1}, для пассажиров - {2}, название - {3}, кол-во двигателей - {4}, дата последнего СТО - {5} \n\n", airplane1.boardNumber, airplane1.modelNumber, airplane1.IsForPassengers, airplane1.AirplaneName, airplane1.EngineCount, airplane1.LastMaintenanceDate.ToString("d"));
            rtbList.Text += string.Format("Самолет: бортовой номер: {0}, модель: {1}, для пассажиров - {2}, название - {3}, кол-во двигателей - {4}, дата последнего СТО - {5} \n\n", airplane2.boardNumber, airplane2.modelNumber, airplane2.IsForPassengers, airplane2.AirplaneName, airplane2.EngineCount, airplane2.LastMaintenanceDate.ToString("d"));
        }
    }
}
