using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_OPLabsss
{
    public class PassangersAirplane : Airplane
    {
        // Поля
        private int passengersAmount;
        
        // Свойства
        public int PassengersAmount { get; set; }
        public bool IsVIP { get; set; }
        
        // Конструкторы
        public PassangersAirplane() : base() { }
        public PassangersAirplane(string boardNumber, string modelNumber, bool isForPassengers, DateTime lastMaintenanceDate, int passengersAmount) : base(boardNumber, modelNumber, isForPassengers, lastMaintenanceDate)
        {
            this.PassengersAmount = passengersAmount;
        }

        // Методы
        public override string ToString()
        {
            return string.Format("Пассажирский самолет: бортовой номер: {0}, модель: {1}, название - {2}, дата последнего ТО - {3}, кол-во пассажиров - {4} \n\n", this.BoardNumber, this.ModelNumber, this.AirplaneName, this.LastMaintenanceDate.ToString("d"), this.passengersAmount);
        }
    }
}
