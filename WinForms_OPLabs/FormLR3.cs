using ClassLibrary_OPLabs;
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
            //Airplane airplane = new Airplane("N-733PG", "A320", true, "Победа", 2, new DateOnly(2020, 12, 25));
            //rtbList.Text += string.Format("{0} {1} {2} {3} {4} {5}",airplane.boardNumber, airplane.modelNumber, airplane.IsForPassengers, airplane.AirplaneName, airplane.EngineCount, airplane.lastMaintenanceDate);
            Airplane airplane1 = new Airplane(tbBoardNumber.Text, tbModel.Text, cbForPassengers.Checked, tbName.Text, (int)nudEngineCount.Value, DateOnly.FromDateTime(dtpLastMaintenanceDate.Value));

            rtbList.Clear();
            rtbList.Text += string.Format("{0} {1} {2} {3} {4} {5}",airplane1.boardNumber, airplane1.modelNumber, airplane1.IsForPassengers, airplane1.AirplaneName, airplane1.EngineCount, airplane1.lastMaintenanceDate);
        }
    }
}
