using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_OPLabsss
{
    public class CargoAirplane : Airplane
    {
        // Поля
        private decimal loadCapacity;
        private string license;

        // Свойства
        public decimal LoadCapacity { get; set; }
        public string License { get; set; }

        // Конструкторы
        public CargoAirplane(): base() { }

        public CargoAirplane(string boardNumber, string modelNumber, bool isForPassengers, DateTime lastMaintenanceDate, decimal loadCapacity, string license) : base(boardNumber, modelNumber, isForPassengers, lastMaintenanceDate)
        { 
            this.LoadCapacity = loadCapacity;
            this.License = license;
        }
    }
}
