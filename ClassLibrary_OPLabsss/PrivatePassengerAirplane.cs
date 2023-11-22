using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_OPLabsss
{
    public class PrivatePassengerAirplane : PassangersAirplane
    {
        // Поля
        private string owner;

        // Свойства
        public string Owner { get; private set; }

        public delegate void PlaneHandler(object sender, PPAirplaneEventArgs e);
        public event PlaneHandler Note;

        // Конструкторы
        public PrivatePassengerAirplane() : base() { }

        public PrivatePassengerAirplane(string owner) : base()
        {
            this.Owner = owner;
        }

        public PrivatePassengerAirplane(string boardNumber, string modelNumber, bool isForPassengers, DateTime lastMaintenanceDate, int passengersAmount, string owner) : base(boardNumber, modelNumber, isForPassengers, lastMaintenanceDate, passengersAmount)
        {
            this.Owner = owner;
        }

        // Методы
        public override string ToString()
        {
            return string.Format("Частный самолет: бортовой номер: {0}, модель: {1}, название - {2}, дата последнего ТО - {3}, владелец - {4} \n\n", this.BoardNumber, this.ModelNumber, this.AirplaneName, this.LastMaintenanceDate.ToString("d"), this.Owner);
        }

        // Обработчики событий
        public virtual void ChangeOwner(string newOwner)
        {
            this.Owner = newOwner;
            Note.Invoke(this, new PPAirplaneEventArgs("Новый владелец самолета - ", newOwner));
        }
    }

    // Класс EventArgs
    public class PPAirplaneEventArgs: EventArgs
    {
        public string Message { get; }
        public string Owner { get; }

        public PPAirplaneEventArgs(string msg, string owner)
        {
            this.Message = msg;
            this.Owner = owner;
        }
    }
}
