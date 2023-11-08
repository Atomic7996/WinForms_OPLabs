using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_OPLabsss
{
    public abstract class AbstractAirplane
    {
        // Свойтсва
        public abstract string AirplaneId { get; set; }

        // Методы
        public abstract string getAirplaneId();
    }
}
