using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary_OPLabsss
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

        private string airplaneName;
        private int engineCount;
        private DateTime lastMaintenanceDate;
        public string image;

        // Свойства
        public bool IsForPassengers { get; set; }

        public string AirplaneName
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

        public virtual DateTime LastMaintenanceDate { get => lastMaintenanceDate; set => lastMaintenanceDate = value; }

        public string BoardNumber { get => boardNumber; set => boardNumber = value; }
        public string ModelNumber { get => modelNumber; set => modelNumber = value; }

        // Конструкторы
        public Airplane() { }

        public Airplane(string boardNumber, string modelNumber)
        {
            this.BoardNumber = boardNumber;
            this.ModelNumber = modelNumber;
        }

        public Airplane(string boardNumber, string modelNumber, bool isForPassengers, string airplaneName, int engineCount, DateTime lastMaintenanceDate) : this(boardNumber, modelNumber)
        {
            this.IsForPassengers = isForPassengers;
            this.AirplaneName = airplaneName;
            this.EngineCount = engineCount;
            this.LastMaintenanceDate = lastMaintenanceDate;
        }

        public Airplane(string boardNumber, string modelNumber, string image)
        {
            this.BoardNumber = boardNumber;
            this.ModelNumber = modelNumber;
            this.image = image;
        }

        public Airplane(string boardNumber, string modelNumber, DateTime lastMaintenanceDate)
        {
            this.BoardNumber = boardNumber;
            this.ModelNumber = modelNumber;
            this.LastMaintenanceDate = lastMaintenanceDate;
        }

        public Airplane(string boardNumber, string modelNumber, bool isForPassengers, DateTime lastMaintenanceDate)
        {
            this.BoardNumber = boardNumber;
            this.ModelNumber = modelNumber;
            this.IsForPassengers = isForPassengers;
            this.LastMaintenanceDate = lastMaintenanceDate;
        }

        static Airplane()
        {
            Airplane.bgColor = Color.Azure;
        }

        // Методы
        public void ShowAirplaneImage(PictureBox pictureBox)
        {
            Graphics g = Graphics.FromHwnd(pictureBox.Handle);
            g.DrawImage(System.Drawing.Image.FromFile(this.image), new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
        }

        public void ShowAirplaneImage(Form form)
        {
            Graphics g = Graphics.FromHwnd(form.Handle);
            g.DrawImage(System.Drawing.Image.FromFile(this.image), new Rectangle(0, 0, form.Width, form.Height));
        }

        public virtual void WhriteInfo(SaveFileDialog dlg)
        {
            string path;

            path = dlg.FileName;
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("Бортовой номер - " + this.BoardNumber);
            streamWriter.WriteLine("Номер модели - " + this.ModelNumber);
            streamWriter.WriteLine("Дата последнего ТО - " + this.LastMaintenanceDate.ToShortDateString());
            streamWriter.Close();
        }

        public string ReadInfo(OpenFileDialog dlg)
        {
            string path;
            string str = null;

            path = dlg.FileName;
            StreamReader streamReader = new StreamReader(path);
            str = streamReader.ReadToEnd();
            streamReader.Close();

            return str;
        }

        public virtual int AfterMaintenanceYears()
        {
            int years = 0;

            years = DateTime.Today.Year - LastMaintenanceDate.Year;

            return years;
        }

        public void AverageMaintananceYears(ref string str, in List<Airplane> airplanes, out int avg, out int count)
        {
            int years = 0;
            count = 0;
            
            foreach (Airplane airplane in airplanes)
            {
                years += DateTime.Today.Year - airplane.LastMaintenanceDate.Year;
                count ++;
            }

            avg = years / count;

            str = "Измененная строка";
        }

        public void Type(RichTextBox box, string optional = "Константа - Самолет")
        {
            box.Text += string.Format("\nМетод с необязательным параметром:\n{0}", optional);
        }
    }
}