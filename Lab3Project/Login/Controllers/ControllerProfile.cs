using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    public class ControllerProfile
    {
        public ControllerProfile()
        {
            Program.V_PlayerProfile.AskChangeProfile += V_PlayerProfile_AskChangeProfile;
            Program.V_PlayerProfile.FotoChange_Request += V_PlayerProfile_FotoChange_Request;
        }

        private void V_PlayerProfile_FotoChange_Request(string str1, string str2)
        {
            Program.M_Profile.ChangeProfileFoto(str1, str2);
        }

        private void V_PlayerProfile_AskChangeProfile(string str1, string str2, string str3, string str4, string str5, string str6)
        {
            Program.M_Profile.ChangeProfile(str1, str2, str3, str4, str5, str6);
        }
    }
}
