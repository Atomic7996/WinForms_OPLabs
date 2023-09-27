﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ClassLibrary_OPLabs
{
    public class Airplane
    {
        // Поля
        public static readonly int airplaneId;
        public string boardNumber;
        public string modelNumber;
        public bool isForPassengers;
        public const string airportName = "Pulkovo SPB";

        public static readonly Color bgColor;

        private string? airplaneName;
        private int engineCount;
        private DateOnly lastMaintenanceDate;

        // Свойства
        public bool IsForPassengers { get; set; }

        public string? AirplaneName
        {
            get
            {
                return airplaneName;
            }
            private set
            {
                if (value.Length != 0 && char.IsLower(value[0]))
                    value = char.ToUpper(value[0]) + value.Substring(1);

                airplaneName = value;
            }
        }

        public int EngineCount
        {
            get => engineCount;
            set
            {
                if (value < 1)
                    return;
                else
                    engineCount = value;
            }
        }

        public DateOnly LastMaintenanceDate { get => lastMaintenanceDate; set => lastMaintenanceDate = value; }

        // Конструкторы
        public Airplane() { }

        public Airplane(string boardNumber, string modelNumber)
        {
            this.boardNumber = boardNumber;
            this.modelNumber = modelNumber;
        }

        public Airplane(string boardNumber, string modelNumber, bool isForPassengers, string? airplaneName, int engineCount, DateOnly lastMaintenanceDate) : this(boardNumber, modelNumber)
        {
            this.IsForPassengers = isForPassengers;
            this.AirplaneName = airplaneName;
            this.EngineCount = engineCount;
            this.LastMaintenanceDate = lastMaintenanceDate;
        }

        static Airplane()
        {
            Airplane.bgColor = Color.Azure;
        }
    }
}