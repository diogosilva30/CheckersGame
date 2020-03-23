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
    public partial class ViewMainMenu : Form
    {
        public ViewMainMenu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            Visible = false;
            Program.V_PlayerProfile.ShowDialog();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        

        private void buttonRules_Click(object sender, EventArgs e)
        {
            Visible = false;
            Program.V_Rules.ShowDialog();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            Visible = false;
            Program.V_SelectGameMode.ShowDialog();
        }
    }
}
