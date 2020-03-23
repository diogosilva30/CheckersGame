using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject
{
    public class ControllerLogin
    {
        public ControllerLogin()
        {
            
            Program.V_Login.Login_Request += V_Login_Login_Request;
            Program.V_SignUp.SignUp_Request += V_SignUp_SignUp_Request;
        }

       

        private void V_Login_Login_Request(string str1, string str2)
        {
            Program.M_Login.Login_Request(str1, str2);
        }

        private void V_SignUp_SignUp_Request(string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9)
        {
            Program.M_Login.SignUp_Request(str1, str2, str3, str4, str5, str6, str7, str8, str9);
        }


    }
}
