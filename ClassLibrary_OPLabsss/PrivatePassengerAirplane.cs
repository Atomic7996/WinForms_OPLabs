using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_OPLabsss
{
    public sealed class PrivatePassengerAirplane: PassengerAirplane
    {
        // Поля
        private string owner;

        // Свойства
        public string Owner { get; set; }

        // Конструкторы
        public PrivatePassengerAirplane() : base() { }

        public PrivatePassengerAirplane(string boardNumber, string modelNumber, bool isForPassengers, DateTime lastMaintenanceDate, int passengersAmount, string owner) : base(boardNumber, modelNumber, isForPassengers, lastMaintenanceDate, passengersAmount)
        {
            this.Owner = owner;
        }
    }
}
