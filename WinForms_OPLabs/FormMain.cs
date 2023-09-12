using ClassLibrary_OPLabs;

namespace WinForms_OPLabs
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbBoardNumber.Clear();
            tbModel.Clear();
            rtbList.Clear();
            cbForPassengers.Checked = false;
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            Airplane airplane1 = new Airplane();
            Airplane airplane2 = new Airplane() { boardNumber = "123AB", modelNumber = "A322", isForPassengers = false };
            Airplane airplane3 = new Airplane();

            airplane1.boardNumber = "755PG";
            airplane1.modelNumber = "A320";
            airplane1.isForPassengers = true;

            airplane3.boardNumber = tbBoardNumber.Text;
            airplane3.modelNumber = tbModel.Text;
            airplane3.isForPassengers = cbForPassengers.Checked;

            rtbList.Clear();
            rtbList.Text += string.Format("Самолет: модель {0}, бортовой номер {1}, для пассажиров - {2}, аэропорт базирования - {3} \n", airplane1.modelNumber, airplane1.boardNumber, airplane1.isForPassengers, Airplane.airportName);
            rtbList.Text += string.Format("Самолет: модель {0}, бортовой номер {1}, для пассажиров - {2}, аэропорт базирования - {3} \n", airplane2.modelNumber, airplane2.boardNumber, airplane2.isForPassengers, Airplane.airportName);
            rtbList.Text += string.Format("Самолет: модель {0}, бортовой номер {1}, для пассажиров - {2}, аэропорт базирования - {3} \n", airplane3.modelNumber, airplane3.boardNumber, airplane3.isForPassengers, Airplane.airportName);
        }

        private void btnShowMethod_Click(object sender, EventArgs e)
        {
            Airplane airplane = new Airplane();
            rtbList.Text += string.Format("У экземпляра класса Airplane тип - {0} \n", airplane.GetType().ToString());
        }
    }
}