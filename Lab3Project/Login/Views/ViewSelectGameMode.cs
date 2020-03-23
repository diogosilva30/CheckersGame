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
    public partial class ViewSelectGameMode : Form
    {
        public event Methods1String GameModeSelected;

        public ViewSelectGameMode()
        {
            InitializeComponent();
            Program.M_Game.ErrorLoadingGame += M_Game_ErrorLoadingGame;
            Program.M_Game.SucessLoadingGame += M_Game_SucessLoadingGame;
        }

        private void M_Game_SucessLoadingGame()
        {
            Point p = new Point(351,596);
            LabelErrorLoading.Location = p;
            LabelErrorLoading.Text = "Game Loaded With Sucess!";
            LabelErrorLoading.ForeColor = Color.Green;
            LabelErrorLoading.Visible = true;
            AuxFunctions.WaitNSeconds(4);
            LabelErrorLoading.Visible = false;
            Visible = false;
            Program.V_Game.ShowDialog();
            
        }

        private void M_Game_ErrorLoadingGame()
        {
            Point p = new Point(227, 596);
            LabelErrorLoading.Location = p;
            LabelErrorLoading.Text = "Error Loading Game: You Must Load A Game That Is Yours!";
            LabelErrorLoading.Visible = true;
            LabelErrorLoading.ForeColor = Color.Red;
            AuxFunctions.WaitNSeconds(4);
            LabelErrorLoading.Visible = false;
        }
        public event MethodsNoParamaters SetUpNewGame;

        private void ButtonGoBack_Click(object sender, EventArgs e)
        {
            Program.V_MainMenu.Visible = true;
            Close();
        }

        private void buttonPlayerVsPc_Click(object sender, EventArgs e)
        {

            Visible = false;
            GameModeSelected?.Invoke("PC");
            SetUpNewGame?.Invoke();
            Program.V_Game.ShowDialog();
        }

        private void buttonPlayerVsPlayer_Click(object sender, EventArgs e)
        {
            Visible = false;
            GameModeSelected?.Invoke("PVP");
            SetUpNewGame?.Invoke();
            Program.V_Game.ShowDialog();
        }

        private void buttonOnline_Click(object sender, EventArgs e)
        {
            Visible = false;
            Program.V_OnlineLobbys.ShowDialog();
        }

        public event Methods1String RequestLoadGame;

        private void buttonLoadGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = ("XML Files|*.XML");
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                RequestLoadGame?.Invoke(dlg.FileName);
            }
        }
    }
}
