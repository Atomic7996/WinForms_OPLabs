using ClassLibrary_OPLabsss;

namespace WinForms_OPLabs
{
    public partial class FormLR2 : Form
    {
        public FormLR2()
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
            Airplane airplane1 = new Airplane(tbBoardNumber.Text, tbModel.Text, cbForPassengers.Checked, "Победа", 0, DateTime.Now);
            Airplane airplane2 = new Airplane("412HH", "F322");

            this.BackColor = Airplane.bgColor;

            rtbList.Clear();
            rtbList.Text += string.Format("Самолет: модель {0}, бортовой номер {1}, для пассажиров - {2}, аэропорт базирования - {3} \n", airplane1.modelNumber, airplane1.boardNumber, airplane1.isForPassengers, Airplane.airportName);
            rtbList.Text += string.Format("Самолет: модель {0}, бортовой номер {1}, для пассажиров - {2}, аэропорт базирования - {3} \n", airplane2.modelNumber, airplane2.boardNumber, airplane2.isForPassengers, Airplane.airportName);
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            Pilot pilot = new Pilot(tbFIO.Text, (int)nudAge.Value);

            rtbList.Text += string.Format("Пилот - {0}, стаж: {1} \n", pilot.fio, pilot.workExperience.ToString());
        }
    }
}
