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
    public partial class FormLR7 : Form
    {
        public FormLR7()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PassengerAirplane passengerAirplane = new PassengerAirplane(tbBoardNumber.Text, tbModel.Text, true, dtpLastMaintenanceDate.Value, (int)nudPassengers.Value);
            rtbInfo.Text += string.Format("Самолет: бортовой номер: {0}, модель: {1}, для пассажиров - {2}, дата последнего ТО - {3}, кол-во пассажиров - {4} \n\n", passengerAirplane.BoardNumber, passengerAirplane.ModelNumber, passengerAirplane.IsForPassengers, passengerAirplane.LastMaintenanceDate.ToString("d"), passengerAirplane.PassengersAmount);
            rtbInfo.Text += string.Format("Домашний аэропорт - {0}\n\n", PassengerAirplane.airportName);

            passengerAirplane.AfterMaintenanceYears();

            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                passengerAirplane.WhriteInfo(dlg);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbBoardNumber.Clear();
            tbModel.Clear();
            nudPassengers.Value = 0;
            dtpLastMaintenanceDate.Value = dtpLastMaintenanceDate.MinDate;
        }
    }
}
