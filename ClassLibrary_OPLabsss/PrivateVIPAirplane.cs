using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary_OPLabsss
{
    public class PrivateVIPAirplane : PrivatePassengerAirplane
    {
        // Поля
        private string status;

        // Свойства
        public string Status { get; set; }

        // Конструкторы
        public PrivateVIPAirplane(string boardNumber, string modelNumber, bool isForPassengers, DateTime lastMaintenanceDate, int passengersAmount, string owner) : base(boardNumber, modelNumber, isForPassengers, lastMaintenanceDate, passengersAmount, owner) { }

        // Методы
        public override void ChangeOwner(string newOwner)
        {
            base.ChangeOwner(newOwner);
        }

        public override string ToString()
        {
            return string.Format("Самолет VIP: бортовой номер: {0}, модель: {1}, название - {2}, дата последнего ТО - {3}, владелец - {4} \n\n", this.BoardNumber, this.ModelNumber, this.AirplaneName, this.LastMaintenanceDate.ToString("d"), this.Owner);
        }

    }
}