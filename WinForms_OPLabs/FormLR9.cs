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
    public partial class FormLR9 : Form
    {
        PrivatePassengerAirplane privatePassengerAirplane;
        PrivateVIPAirplane privateVIPAirplane;

        public FormLR9()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbBoardNumber.Clear();
            tbModel.Clear();
            dtpLastMaintenanceDate.Value = dtpLastMaintenanceDate.MinDate;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //privatePassengerAirplane = new PrivatePassengerAirplane(tbBoardNumber.Text, tbModel.Text, true, dtpLastMaintenanceDate.Value, (int)nudPassengers.Value, tbOwner.Text);
            //rtbInfo.Text += privatePassengerAirplane.ToString();

            // Наследник
            privateVIPAirplane = new PrivateVIPAirplane(tbBoardNumber.Text, tbModel.Text, true, dtpLastMaintenanceDate.Value, (int)nudPassengers.Value, tbOwner.Text);
            rtbInfo.Text += privateVIPAirplane.ToString();
        }

        private void btnChangeOwner_Click(object sender, EventArgs e)
        {
            //privatePassengerAirplane.Note += DisplayMessage;
            //privatePassengerAirplane.Note += DisplayMessageMT;
            //privatePassengerAirplane.ChangeOwner(tbNewOwner.Text);
            
            //privatePassengerAirplane.Note -= DisplayMessage;
            //privatePassengerAirplane.Note -= DisplayMessageMT;

            //rtbInfo.Text += privatePassengerAirplane.ToString();

            // Наследник
            privateVIPAirplane.Note += DisplayMessage;
            privateVIPAirplane.Note += DisplayMessageMT;
            privateVIPAirplane.ChangeOwner(tbNewOwner.Text);

            privateVIPAirplane.Note -= DisplayMessage;
            privateVIPAirplane.Note -= DisplayMessageMT;

            rtbInfo.Text += privateVIPAirplane.ToString();
        }

        private void DisplayMessage(object sender, PPAirplaneEventArgs e)
        {
            MessageBox.Show(string.Format("{0} {1}", e.Message, e.Owner), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayMessageMT(object sender, PPAirplaneEventArgs e)
        {
            //privatePassengerAirplane.LastMaintenanceDate = DateTime.Now;

            // Наследник
            privateVIPAirplane.LastMaintenanceDate = DateTime.Now;

            MessageBox.Show("Дата техобслуживания изменена на сегодняшнюю", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
