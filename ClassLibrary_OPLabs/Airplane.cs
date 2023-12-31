﻿using System.Drawing;

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
        private DateTime lastMaintenanceDate;
        private string image;

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

        public DateTime LastMaintenanceDate { get => lastMaintenanceDate; set => lastMaintenanceDate = value; }

        public string BoardNumber { get => boardNumber; set => boardNumber = value; }
        public string ModelNumber { get => modelNumber; set => modelNumber = value; }

        // Конструкторы
        public Airplane() { }

        public Airplane(string boardNumber, string modelNumber)
        {
            this.boardNumber = boardNumber;
            this.modelNumber = modelNumber;
        }

        public Airplane(string boardNumber, string modelNumber, bool isForPassengers, string? airplaneName, int engineCount, DateTime lastMaintenanceDate) : this(boardNumber, modelNumber)
        {
            this.IsForPassengers = isForPassengers;
            this.AirplaneName = airplaneName;
            this.EngineCount = engineCount;
            this.LastMaintenanceDate = lastMaintenanceDate;
        }

        public Airplane(string BoardNumber, string modelNumber, string image)
        {
            this.boardNumber = BoardNumber;
            this.modelNumber = modelNumber;
            this.image = image;
        }
        static Airplane()
        {
            Airplane.bgColor = Color.Azure;
        }

        // Методы

        //public void ShowAirplaneImage(PictureBox pictureBox)
        //{
        //    Graphics g = Graphics.FromHwnd(pictureBox.Handle);
        //    g.DrawImage(Image.FromFile(this.image), new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
        //}
    }
}