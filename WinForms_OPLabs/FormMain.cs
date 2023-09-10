using ClassLibrary_OPLabs;

namespace WinForms_OPLabs
{
    public partial class FormMain : Form
    {
        //FormMain formMain;

        public FormMain()
        {
            InitializeComponent();
            //formMain = this;
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

            airplane1.boardNumber = "755PG";
            airplane1.modelNumber = "A320";
            airplane1.isForPassengers = true;

            rtbList.Clear();

            rtbList.Text += string.Format("Самолет: модель {0}, бортовой номер {1}, для пассажиров - {2} \n", airplane1.modelNumber, airplane1.boardNumber, airplane1.isForPassengers);
            rtbList.Text += string.Format("Самолет: модель {0}, бортовой номер {1}, для пассажиров - {2} \n", airplane2.modelNumber, airplane2.boardNumber, airplane2.isForPassengers);
            rtbList.Text += string.Format("Самолет: модель {0}, бортовой номер {1}, для пассажиров - {2} \n", tbModel.Text, tbBoardNumber.Text, cbForPassengers.Checked);

            rtbList.Text += string.Format("У объекта airplane1 тип - {0}", airplane1.GetType().ToString());
            
        }
    }
}