using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary_OPLabsss
{
    public class PetrolStation: IPetrolAirplane
    {
        private decimal fuelAmount;
        private string title;

        // Свойства
        public decimal FuelAmount { get; set; }
        public string Title { get; set; }


        // Конструкторы
        public PetrolStation() { }
        public PetrolStation(string title, decimal amount)
        {
            this.Title = title;
            this.FuelAmount = amount;
        }

        // Методы
        public void AddFuel(decimal fuelAmount)
        {
            if (this.FuelAmount - fuelAmount >= 0)
            {
                this.FuelAmount -= fuelAmount;
            }
            else
            {
                MessageBox.Show("Топливо кончилось!");
            }
        }

        public void AddFuelFrom(IPetrolAirplane petrolAirplane, decimal fuelAmount)
        {
            if (this.FuelAmount - fuelAmount >= 0)
            {
                this.FuelAmount -= fuelAmount;
                petrolAirplane.AddFuel(fuelAmount);
            }
            else
            {
                MessageBox.Show("Топливо кончилось!");
            }
            
        }
    }
}