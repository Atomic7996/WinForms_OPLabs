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
    public partial class FormLR10 : Form
    {
        public FormLR10()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            PetrolStation station = new PetrolStation("Лукойл", 120);
            Airplane airplane = new Airplane(tbBoardNumber.Text, tbModel.Text, nudFuel.Value);
            rtbList.Text += string.Format("Самолет: бортовой номер: {0}, модель: {1}, кол-во топлива - {2}\n", airplane.BoardNumber, airplane.ModelNumber, airplane.FuelAmount.ToString());
            rtbList.Text += string.Format("Заправка: название: {0}, кол-во топлива - {1}\n\n", station.Title, station.FuelAmount.ToString());

            airplane.AddFuelFrom(station, 20);
            rtbList.Text += string.Format("Самолет: бортовой номер: {0}, модель: {1}, кол-во топлива - {2}\n", airplane.BoardNumber, airplane.ModelNumber, airplane.FuelAmount.ToString());
            rtbList.Text += string.Format("Заправка: название: {0}, кол-во топлива - {1}\n\n", station.Title, station.FuelAmount.ToString());

            airplane.AddFuel(90);
            rtbList.Text += string.Format("Самолет: бортовой номер: {0}, модель: {1}, кол-во топлива - {2}\n", airplane.BoardNumber, airplane.ModelNumber, airplane.FuelAmount.ToString());
            rtbList.Text += string.Format("Заправка: название: {0}, кол-во топлива - {1}\n\n", station.Title, station.FuelAmount.ToString());

            // Преобразование типов
            IPetrolAirplane airplane1 = new Airplane(tbBoardNumber.Text, tbModel.Text, nudFuel.Value);
            IPetrolAirplane station1 = new PetrolStation("Газпром", 90);
            rtbList.Text += string.Format("Самолет: бортовой номер: {0}, модель: {1}, кол-во топлива - {2}\n", ((Airplane)airplane1).BoardNumber, ((Airplane)airplane1).ModelNumber, ((Airplane)airplane1).FuelAmount.ToString());
            rtbList.Text += string.Format("Заправка: название: {0}, кол-во топлива - {1}\n\n", ((PetrolStation)station1).Title, ((PetrolStation)station1).FuelAmount.ToString());

            airplane1.AddFuelFrom(station1, 20);
            rtbList.Text += string.Format("Самолет: бортовой номер: {0}, модель: {1}, кол-во топлива - {2}\n", ((Airplane)airplane1).BoardNumber, ((Airplane)airplane1).ModelNumber, ((Airplane)airplane1).FuelAmount.ToString());
            rtbList.Text += string.Format("Заправка: название: {0}, кол-во топлива - {1}\n\n", ((PetrolStation)station1).Title, ((PetrolStation)station1).FuelAmount.ToString());
        }
    }
}
