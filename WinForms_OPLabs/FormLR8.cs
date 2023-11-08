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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms_OPLabs
{
    public partial class FormLR8 : Form
    {
        Airplane airplane;

        public FormLR8()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            airplane = new Airplane(tbBoardNumber.Text, tbModel.Text, tbAirplaneName.Text, dtpLastMaintenanceDate.Value, tbAirplaneId.Text);
            rtbInfo.Text += string.Format("Самолет: бортовой номер: {0}, модель: {1}, название - {2}, дата последнего ТО - {3}, идентификатор - {4} \n\n", airplane.BoardNumber, airplane.ModelNumber, airplane.AirplaneName, airplane.LastMaintenanceDate.ToString("d"), airplane.getAirplaneId());
            rtbInfo.Text += "Переопределение ToString():\n" + airplane.ToString();
            AbstractAirplane abstractAirplane = new Airplane();
            //abstractAirplane.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbBoardNumber.Clear();
            tbModel.Clear();
            dtpLastMaintenanceDate.Value = dtpLastMaintenanceDate.MinDate;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font font = fontDialog.Font;
                Color color = fontDialog.Color;

                airplane.NameText(pbImage, font, color);
            }            
        }
    }
}
