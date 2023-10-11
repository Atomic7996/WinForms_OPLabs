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
    public partial class FormLR5 : Form
    {
        List<Airplane> airplaneList = new List<Airplane>();

        public FormLR5()
        {
            InitializeComponent();
        }

        private void FormLR5_Load(object sender, EventArgs e)
        {
            airplaneList.Add(new Airplane("557HJ", "A320", new DateTime(2020, 12, 11)));
            airplaneList.Add(new Airplane("732RF", "B220", new DateTime(2018, 8, 3)));
            airplaneList.Add(new Airplane("890XY", "B-15M", new DateTime(2022, 5, 7)));
            lbAirplanes.Visible = false;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            Airplane airplane = new Airplane(tbBoardNumber.Text, tbModel.Text, dtpLastMaintenanceDate.Value);
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                airplane.WhriteInfo(dlg);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Airplane airplane = new Airplane(tbBoardNumber.Text, tbModel.Text, dtpLastMaintenanceDate.Value);
            OpenFileDialog dlg = new OpenFileDialog();
            string str = null;

            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                str = airplane.ReadInfo(dlg);
            }

            rtbInfo.Clear();
            rtbInfo.Text += str;
            rtbInfo.Text += "Лет с последнего ТО - " + airplane.AfterMaintenanceYears();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            string str = "Строка\n";
            int avg = 0;
            int count = 0;

            Airplane airplane = new Airplane(tbBoardNumber.Text, tbModel.Text, dtpLastMaintenanceDate.Value);
            airplaneList.Add(airplane);

            lbAirplanes.Visible = true;
            lbAirplanes.DataSource = null;
            lbAirplanes.DataSource = airplaneList;
            lbAirplanes.DisplayMember = "LastMaintenanceDate";

            rtbInfo.Clear();
            rtbInfo.Text += str;

            airplane.AverageMaintananceYears(ref str, airplaneList, out avg, out count);

            rtbInfo.Text += str;
            rtbInfo.Text += "\nСреднее время после ТО - " + avg;
            rtbInfo.Text += "\nКол-во самолетов в списке - " + count;

            airplane.Type(rtbInfo);
        }
    }
}
