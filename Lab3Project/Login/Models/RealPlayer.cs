using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class RealPlayer : Player
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public RealPlayer()
        {
            Email = Password = Name = Country = "";
        }
        public RealPlayer(string username, string email, string password, string name, string surname, string country, string foto, int n_games, int n_wins, int n_left, int n_losts)
            : base(username,n_games, n_wins, n_losts, n_left)
        {
            Foto = Image.FromFile("Fotos\\" + foto);
            Foto.Tag = foto;
            Email = email;
            Password = password;
            Name = name;
            Surname = surname;
            Country = country;
        }

    }
}
