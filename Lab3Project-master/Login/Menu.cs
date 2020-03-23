using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    public class Menu
    {
        public Game NewGame { get; set; }
        public Menu()
        {
            NewGame = new Game();
        }
    }
}
