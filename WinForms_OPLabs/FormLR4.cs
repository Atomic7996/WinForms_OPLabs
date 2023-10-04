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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinForms_OPLabs
{
    public partial class FormLR4 : Form
    {
        List<Airplane> airplanes = new List<Airplane>();

        public FormLR4()
        {
            InitializeComponent();
        }

        private void FormLR4_Load(object sender, EventArgs e)
        {
            airplanes.Add(new Airplane("567HJ", "A320", true, "Win", 4, DateTime.Now));

            lbAirplanes.DataSource = airplanes;
            lbAirplanes.DisplayMember = "BoardNumber";

            tbBoardNumber2.DataBindings.Add("Text", airplanes, "BoardNumber");
            tbModel2.DataBindings.Add("Text", airplanes, "ModelNumber");
            cbForPassengers2.DataBindings.Add("Checked", airplanes, "IsForPassengers");
            tbName2.DataBindings.Add("Text", airplanes, "AirplaneName");
            nudEngineCount2.DataBindings.Add("Value", airplanes, "EngineCount");
            dtpLastMaintenanceDate2.DataBindings.Add("Value", airplanes, "LastMaintenanceDate");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbBoardNumber.Clear();
            tbModel.Clear();
            cbForPassengers.Checked = false;
            tbName.Clear();
            nudEngineCount.Value = 0;
            dtpLastMaintenanceDate.Value = dtpLastMaintenanceDate.MinDate;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            airplanes.Add(new Airplane(tbBoardNumber.Text, tbModel.Text, cbForPassengers.Checked, tbName.Text, (int)nudEngineCount.Value, dtpLastMaintenanceDate.Value));

            lbAirplanes.DataSource = null;
            lbAirplanes.DataSource = airplanes;
            lbAirplanes.DisplayMember = "BoardNumber";
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                Airplane airplane = new Airplane(tbBoardNumber.Text, tbBoardNumber.Text, dlg.FileName);
                airplane.ShowAirplaneImage(pbImage);
            }
        }

        private void btnImageForm_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                Airplane airplane = new Airplane(tbBoardNumber.Text, tbBoardNumber.Text, dlg.FileName);
                airplane.ShowAirplaneImage(this);
            }
        }
    }
}
