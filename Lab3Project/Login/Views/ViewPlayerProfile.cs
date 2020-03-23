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
    public partial class ViewPlayerProfile : Form
    {
        #region PrivateVaribles
        private string FotoPath;
        private bool flag = false;
        #endregion


        #region PublicEvents
        public event Methods6Strings AskChangeProfile;
        public event Methods2Strings FotoChange_Request;
        #endregion

        public ViewPlayerProfile()
        {
            InitializeComponent();
            Program.M_Profile.SuccessChanges += M_Profile_SuccessChanges;

        }
        public void SetInfo(Player p)
        {
            BoxUserName.Text = p.Username.ToString();
            BoxPassword.Text = (p as RealPlayer).Password.ToString();
            BoxEmail.Text = (p as RealPlayer).Email.ToString();
            BoxCountry.Text = (p as RealPlayer).Country.ToString();
            BoxGames.Text = (p as RealPlayer).N_Games.ToString();
            BoxWins.Text = (p as RealPlayer).N_Wins.ToString();
            BoxLosts.Text = (p as RealPlayer).N_Losts.ToString();
            BoxLeft.Text = (p as RealPlayer).N_Left.ToString();
            PlayerFoto.BackgroundImage = (p as RealPlayer).Foto;
            PlayerFoto.BackgroundImageLayout = ImageLayout.Zoom;
            boxFirstName.Text = (p as RealPlayer).Name;
            boxLastName.Text = (p as RealPlayer).Surname;

        }

        private void M_Profile_SuccessChanges()
        {
            LabelStatus.Visible = true;
            LabelStatus.BringToFront();
            LabelStatus.ForeColor = Color.Green;
            LabelStatus.Text = "Data changed successfully!";
            AuxFunctions.WaitNSeconds(3);
            LabelStatus.Visible = false;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (buttonModify.ButtonText.Equals("Save"))
            {

                buttonModify.ButtonText = "Modify";
                BoxPassword.Enabled = false;
                BoxEmail.Enabled = false;
                BoxCountry.Enabled = false;
                boxFirstName.Enabled = false;
                boxLastName.Enabled = false;
                flag = false;
                if (FotoPath!=null)
                {
                    FotoChange_Request?.Invoke(BoxUserName.Text, FotoPath);
                    FotoPath = null;
                }
                AskChangeProfile?.Invoke(BoxUserName.Text, boxFirstName.Text, boxLastName.Text, BoxPassword.Text, BoxEmail.Text, BoxCountry.Text);
                return;
            }
            if (buttonModify.ButtonText.Equals("Modify"))
            {
                boxFirstName.Enabled = true;
                boxLastName.Enabled = true;
                BoxPassword.Enabled = true;
                BoxEmail.Enabled = true;
                BoxCountry.Enabled = true;
                buttonModify.ButtonText = "Save";
                flag = true;
            }

        }
        private void ButtonGoBack_Click(object sender, EventArgs e)
        {
            if (buttonModify.ButtonText.Equals("Save"))
            {
                buttonModify.ButtonText = "Modify";
                BoxUserName.Enabled = false;
                BoxPassword.Enabled = false;
                BoxEmail.Enabled = false;
                BoxCountry.Enabled = false;
            }
            Program.V_MainMenu.Visible = true;
            Close();
        }
        private void PlayerFoto_Click(object sender, EventArgs e)
        {
            if(!flag)
            {
                return;
            }
            else
            {
                try
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.Filter = "jpg files (*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        PlayerFoto.BackgroundImage = Image.FromFile(dlg.FileName);
                        PlayerFoto.BackgroundImageLayout = ImageLayout.Zoom;
                        
                        FotoPath = dlg.FileName;
                    }
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("An Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }
            
        }

        private void ViewPlayerProfile_Load(object sender, EventArgs e)
        {
            SetInfo(Program.M_Game.Game.Players[0]);

        }
    }
}
