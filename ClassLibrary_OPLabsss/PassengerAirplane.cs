using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary_OPLabsss
{
    public class PassengerAirplane: Airplane
    {
        // Поля
        private int passengersAmount;
        private DateTime lastMaintenanceDate;
        public new const string airportName = "Domodedovo MSC";

        // Свойства
        public int PassengersAmount { get; set; }

        public override DateTime LastMaintenanceDate
        { 
            get => lastMaintenanceDate;
            set
            {
                if (value > DateTime.Today)
                    lastMaintenanceDate = DateTime.Today;
                else
                    lastMaintenanceDate = value;
            }
        }

        // Конструкторы
        public PassengerAirplane() : base() { }

        public PassengerAirplane(string boardNumber, string modelNumber, bool isForPassengers, DateTime lastMaintenanceDate, int passengersAmount) : base(boardNumber, modelNumber, isForPassengers, lastMaintenanceDate)
        {
            this.PassengersAmount = passengersAmount;
        }

        // Методы
        public override int AfterMaintenanceYears()
        {
            int years = DateTime.Today.Year - LastMaintenanceDate.Year;

            if (years >= 7 && years < 10)
                MessageBox.Show("Подходит срок нового ТО", "Предупреждение!", MessageBoxButtons.OK);
            else if (years >= 10)
                MessageBox.Show("Истек срок ТО, необходимо обратиться в сервис!", "Предупреждение!", MessageBoxButtons.OK);

            return years;
        }

        public override sealed void WhriteInfo(SaveFileDialog dlg)
        {
            string path;

            path = dlg.FileName;
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("Бортовой номер - " + this.BoardNumber);
            streamWriter.WriteLine("Номер модели - " + this.ModelNumber);
            streamWriter.WriteLine("Дата последнего ТО - " + this.LastMaintenanceDate.ToShortDateString());
            streamWriter.WriteLine("Кол-во пассажиров - " + this.PassengersAmount);
            streamWriter.WriteLine("Домашний аэропорт - " + PassengerAirplane.airportName);
            
            streamWriter.Close();
        }

    }
}
