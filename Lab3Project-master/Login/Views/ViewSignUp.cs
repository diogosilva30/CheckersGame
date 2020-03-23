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
    public partial class ViewSignUp : Form
    {
        public event Methods9Strings SignUp_Request;
        public ViewSignUp()
        { 
            InitializeComponent();
            Program.M_Login.Error_SignUp += M_Login_Error_SignUp;
            Program.M_Login.SignUp_Successful += M_Login_SignUp_Successful;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ButtonSignUp_Click(new object(), new EventArgs());
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void M_Login_SignUp_Successful()
        {
            labelStatus.Visible = true;
            labelStatus.BringToFront();
            labelStatus.ForeColor = Color.Green;
            labelStatus.Text = "Sign Up Successful!";
            AuxFunctions.WaitNSeconds(3);
            labelStatus.Visible = false;
            Program.V_Login.Visible = true;
            Close();
        }

        private void M_Login_Error_SignUp(string str)
        {
            labelStatus.Visible = true;
            labelStatus.BringToFront();
            labelStatus.Text = str;
            AuxFunctions.WaitNSeconds(2);
            labelStatus.Visible = false;
        }


        private void ButtonSignUp_Click(object sender, EventArgs e)
        {

            string country;
            if (BoxCountry.SelectedItem != null)
            {
                country = BoxCountry.SelectedItem.ToString();
            }
            else
            {
                country = "";
            }
            SignUp_Request?.Invoke(BoxUserName.Text, boxFirstName.Text, boxLastName.Text, BoxProfilePic.ImageLocation,
            BoxPassword.Text, BoxPasswordReEnter.Text, BoxEmail.Text, BoxEmailReEnter.Text, country);
        }

        

        private void BoxUserNameEnter(object sender, EventArgs e)
        {
            if (BoxUserName.Text.Equals(@"Username"))
            {
                BoxUserName.Text = "";
            }
        }

        private void boxUserNameLeave(object sender, EventArgs e)
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
        private void BoxPasswordReEnter_Enter(object sender, EventArgs e)
        {
            if (BoxPasswordReEnter.Text.Equals("Password"))
            {
                BoxPasswordReEnter.Text = "";
            }
        }

        private void BoxPasswordReEnter_Leave(object sender, EventArgs e)
        {
            if (BoxPasswordReEnter.Text.Equals(""))
            {
                BoxPasswordReEnter.Text = "Password";
            }
        }

        private void BoxFirstNameEnter(object sender, EventArgs e)
        {
            if (boxFirstName.Text.Equals("First Name"))
            {
                boxFirstName.Text = "";
            }
        }

        private void BoxFirstNameLeave(object sender, EventArgs e)
        {
            if (boxFirstName.Text.Equals(""))
            {
                boxFirstName.Text = "First Name";
            }
        }


        private void BoxProfilePic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "jpg files (*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    BoxProfilePic.ImageLocation = dlg.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonGoBack_Click(object sender, EventArgs e)
        {
            Program.V_Login.Visible = true;
            Close();
        }
        
        private void BoxLastNameEnter(object sender, EventArgs e)
        {
            if (boxLastName.Text.Equals("Last Name"))
            {
                boxLastName.Text = "";
            }
        }

        private void BoxLastNameLeave(object sender, EventArgs e)
        {
            if (boxLastName.Text.Equals(""))
            {
                boxLastName.Text = "Last Name";
            }
        }

        private void BoxEmail_Enter(object sender, EventArgs e)
        {
            if (BoxEmail.Text.Equals("Your email"))
            {
                BoxEmail.Text = "";
            }
        }

        private void BoxEmail_Leave(object sender, EventArgs e)
        {
            if (BoxEmail.Text.Equals(""))
            {
                BoxEmail.Text = "Your email";
            }
        }

        private void BoxEmailReEnter_Enter(object sender, EventArgs e)
        {
            if (BoxEmailReEnter.Text.Equals("Re-enter your email"))
            {
                BoxEmailReEnter.Text = "";
            }
        }

        private void BoxEmailReEnter_Leave(object sender, EventArgs e)
        {
            if (BoxEmailReEnter.Text.Equals(""))
            {
                BoxEmailReEnter.Text = "Re-enter your email";
            }
        }

    }
}



