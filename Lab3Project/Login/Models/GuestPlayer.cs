using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    public class GuestPlayer : Player
    {

        public GuestPlayer(string username)
        {
            Username = username;
            Foto = Properties.Resources.user_icon;
        }
    }
}
