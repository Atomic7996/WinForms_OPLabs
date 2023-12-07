using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary_OPLabsss
{
    public class Engine
    {
        // Поля
        private string engineType;
        private decimal power;

        // Свойства
        public string EngineType { get; set; }
        public decimal Power { get; set; }

        // Конструкторы
        public Engine()
        {
            this.EngineType = "Type";
            this.Power = 10;
        }
    }
}