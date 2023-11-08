using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClassLibrary_OPLabsss;

namespace WinForms_OPLabs
{
    public partial class FormLR6 : Form
    {
        public FormLR6()
        {
            InitializeComponent();
        }

        private void FormLR6_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            nudPassengers.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbForPassengers.Checked == true)
            {
                PassangersAirplane passengerAirplane = new PassangersAirplane(tbBoardNumber.Text, tbModel.Text, cbForPassengers.Checked, dtpLastMaintenanceDate.Value, (int)nudPassengers.Value);
                rtbInfo.Text += string.Format("Самолет: бортовой номер: {0}, модель: {1}, для пассажиров - {2}, дата последнего ТО - {3}, кол-во пассажиров - {4} \n\n", passengerAirplane.boardNumber, passengerAirplane.modelNumber, passengerAirplane.IsForPassengers, passengerAirplane.LastMaintenanceDate.ToString("d"), passengerAirplane.PassengersAmount);

                Airplane airplane = (Airplane)passengerAirplane;
                //airplane.PassengersAmount = 0; // У класса Airplane отсутствует свойство PassengersAmount, которое описано в классе-наследнике PassengerAirplane, и оно является недоступным
                // это вызывает ошибку в Visual Studio

                Airplane airplane1 = new Airplane();
                Airplane passengerAirplane1 = (Airplane)airplane1;
                //passengerAirplane1.PassangersAmount = 0; // А при нисходящем преобразовании свойство становится доступным

                passengerAirplane1.GetHashCode(); // Этот метод унаследован от класса Object
            }
            else
            {
                CargoAirplane cargoAirplane = new CargoAirplane(tbBoardNumber.Text, tbModel.Text, cbForPassengers.Checked, dtpLastMaintenanceDate.Value, (int)nudWeight.Value, tbLicense.Text);
                rtbInfo.Text += string.Format("Самолет: бортовой номер: {0}, модель: {1}, для пассажиров - {2}, дата последнего ТО - {3}, грузоподъемность - {4}, лицензия - {5} \n\n", cargoAirplane.boardNumber, cargoAirplane.modelNumber, cargoAirplane.IsForPassengers, cargoAirplane.LastMaintenanceDate.ToString("d"), cargoAirplane.LoadCapacity, cargoAirplane.License);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbBoardNumber.Clear();
            tbModel.Clear();
            cbForPassengers.Checked = false;
            tbLicense.Clear();
            nudWeight.Value = 0;
            nudPassengers.Value = 0;
            dtpLastMaintenanceDate.Value = dtpLastMaintenanceDate.MinDate;
        }

        private void cbForPassengers_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForPassengers.Checked == true)
            {
                label4.Visible = true;
                nudPassengers.Visible = true;

                label5.Visible = false;
                label6.Visible = false;
                nudWeight.Visible = false;
                tbLicense.Visible = false;
            }
            else
            {
                label5.Visible = true;
                label6.Visible = true;
                nudWeight.Visible = true;
                tbLicense.Visible = true;

                label4.Visible = false;
                nudPassengers.Visible = false;
            }
        }
    }
}
