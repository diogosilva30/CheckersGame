using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;


namespace LabProject
{
    
    public partial class ViewLogin : Form
    {

        #region PublicEvents
        public event Methods2Strings Login_Request;
        #endregion

        public ViewLogin()
        {
            InitializeComponent();
            Program.M_Login.Login_Successful += M_Login_Login_Successful;
            Program.M_Login.Error_Login += M_Login_Error_Login;
        }

        private void M_Login_Error_Login(string str)
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = str;
            AuxFunctions.WaitNSeconds(2);
            ErrorLabel.Visible = false;
            
        }

        private void M_Login_Login_Successful(string str1, string str2)
        {
            PanelLogin.Visible = false;

            //transicao.HideSync(PanelLogin);
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.ForeColor = Color.White;
            labelWelcome.BringToFront();
            labelWelcome.Font = new Font("Segoe UI", 30);
            labelWelcome.AutoSize = true;
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            labelWelcome.Text = "Welcome Back " +str1 + " " + str2 +"!";
            labelWelcome.Location = AuxFunctions.GetPosition(labelWelcome, Height, Width);
            labelWelcome.Visible = true;
            System.Threading.Thread.Sleep(1500);
            BackPanel.Controls.Add(labelWelcome);
            timerEnter.Enabled = true;
        }

        private void ClickButtonLogin(object sender, EventArgs e)
        {
            Login_Request?.Invoke(BoxUserName.Text, BoxPassword.Text);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ClickButtonLogin(new object(), new EventArgs());
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void BoxUsernameEnter(object sender, EventArgs e)
        {
            if (BoxUserName.Text.Equals(@"Username"))
            {
                BoxUserName.Text = "";
            }
        }

        private void BoxUsernameLeave(object sender, EventArgs e)
        {
            if (BoxUserName.Text.Equals(""))
            {
                BoxUserName.Text = "Username";
            }
        }

        private void BoxPasswordEnter(object sender, EventArgs e)
        {
            if (BoxPassword.Text.Equals("Password"))
            {
                BoxPassword.Text = "";
            }

        }

        private void BoxPasswordLeave(object sender, EventArgs e)
        {
            if (BoxPassword.Text.Equals(""))
            {
                BoxPassword.Text = "Password";
            }
        }

        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            Visible = false;
            Program.V_SignUp.ShowDialog();
        }

        private void timerEnter_Tick(object sender, EventArgs e)
        {
            timerEnter.Stop();
            this.Visible = false;
            Program.V_MainMenu.ShowDialog();
            Close();
            
        }
       
    }
}
