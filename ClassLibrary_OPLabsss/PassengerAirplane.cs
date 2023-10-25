using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_OPLabsss
{
    public class PassengerAirplane: Airplane
    {
        // Поля
        private int passengersAmount;

        // Свойства
        public int PassengersAmount { get; set; }
        public bool IsVIP { get; set; }

        // Конструкторы
        public PassengerAirplane() : base() { }

        public PassengerAirplane(string boardNumber, string modelNumber, bool isForPassengers, DateTime lastMaintenanceDate, int passengersAmount) : base(boardNumber, modelNumber, isForPassengers, lastMaintenanceDate)
        {
            this.PassengersAmount = passengersAmount;
        }
    }
}
