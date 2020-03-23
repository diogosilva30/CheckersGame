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
    public partial class ViewStats : Form
    {
        public ViewStats()
        {
            InitializeComponent();
        }
        
        public ViewStats(Player p)
        {
            InitializeComponent();
            BoxGames.Text = p.N_Games.ToString();
            BoxWins.Text = p.N_Wins.ToString();
            BoxLosses.Text = p.N_Losts.ToString();
            boxAbandoned.Text = p.N_Left.ToString();
            if (!(p is VirtualPlayer))
            {
                BoxCountry.Text = (p as RealPlayer).Country.ToString();
            }

        }

        
    }
}
