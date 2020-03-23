using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject
{
    public partial class ViewRules : Form
    {
        public ViewRules()
        {
            InitializeComponent();
        }

        private void ButtonGoBack_Click_2(object sender, EventArgs e)
        {
            Program.V_MainMenu.Visible = true;
            Close();
        }

        private void buttonViewRules_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"http://www.fpdamas.pt/downloads/Regras_Damas_Cl%C3%A1ssicas_.pdf");
            pStart.Start();
        }

    }
}
