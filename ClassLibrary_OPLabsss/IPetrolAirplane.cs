using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary_OPLabsss
{
    public interface IPetrolAirplane
    {
        decimal FuelAmount { get; set; }

        void AddFuel(decimal fuelAmount);

        void AddFuelFrom(IPetrolAirplane petrolAirplane, decimal fuelAmount);
    }
}