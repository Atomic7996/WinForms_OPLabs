using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ClassLibrary_OPLabs
{
    public class Airplane
    {
        public static readonly int? airplaneId;
        public string? boardNumber;
        public string? modelNumber;
        public bool isForPassengers;
        public const string airportName = "Pulkovo SPB";
        private string? airplaneName;
        public static readonly Color bgColor;

        public Airplane() { }

        public Airplane(string? boardNumber, string? modelNumber)
        {
            this.boardNumber = boardNumber;
            this.modelNumber = modelNumber;
        }

        public Airplane(string? boardNumber, string? modelNumber, bool isForPassengers, string? airplaneName)
        {
            this.boardNumber = boardNumber;
            this.modelNumber = modelNumber;
            this.isForPassengers = isForPassengers;
            this.airplaneName = airplaneName;
        }

        static Airplane()
        {
            Airplane.bgColor = Color.Azure;
        }
    }
}