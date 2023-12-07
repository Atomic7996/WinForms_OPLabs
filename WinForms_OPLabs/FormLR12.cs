using ClassLibrary_OPLabsss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_OPLabs
{
    public partial class FormLR12 : Form
    {
        Airport airport;

        public FormLR12()
        {
            InitializeComponent();

            List<string> petrols = new List<string>() { "Газпром", "Лукойл"};
            lbPetrols.DataSource = petrols;
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            Airport airport1 = new Airport(new[] { new PetrolStation("Газпром", 220), new PetrolStation("Лукойл", 98) });

            rtbInfo.Text += airport1[0].Title + "\t" + airport1[0].FuelAmount + "\n";
            rtbInfo.Text += airport1[1].Title + "\t" + airport1[1].FuelAmount + "\n";
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            airport = new Airport(new[,] { { "Газпром", "Закрыто" }, { "Лукойл", "Открыто" } });

            rtbInfo.Clear();
            rtbInfo.Text += string.Format("Заправка {0} имеет статус {1}\n", lbPetrols.SelectedItem, airport[lbPetrols.SelectedIndex, 1]);
        }
    }
}
