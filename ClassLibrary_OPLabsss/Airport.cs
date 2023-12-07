using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary_OPLabsss
{
    public class Airport
    {
        // Поля
        private string name;
        private string city;
        private PetrolStation petrolStation;
        

        // Свойства
        public string Name { get; set; }
        public string City { get; set; }
        public PetrolStation PetrolStation { get; set; }
        PetrolStation[] PetrolStations { get; set; }
        


        // Конструкторы
        public Airport() { }
        public Airport(string name, string city)
        {
            this.Name = name;
            this.City = city;
            this.PetrolStation = new PetrolStation();
        }
        public Airport(PetrolStation[] petrolStation) => PetrolStations = petrolStation;
        public Airport(string[,] petrolStationStat) => PetrolStationsStatus = petrolStationStat;

        // Индексатор
        public PetrolStation this[int index]
        {
            get => PetrolStations[index];
            set => PetrolStations[index] = value;
        }

        // Многомерный индексатор
        public string[,] PetrolStationsStatus; // статус заправки
        public string this[int i, int j]
        {
            get => PetrolStationsStatus[i, j];
            set => PetrolStationsStatus[i, j] = value;
        }
    }
}