using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject
{
    public partial class PreLoader : UserControl
    {
        public PreLoader()
        {
            InitializeComponent();
        }
        int dir = 1;

        private void stretch_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value==100)
            {
                dir -= 1;
            }
            else if(bunifuCircleProgressbar1.Value == 0)
            {
                dir += 1;
            }
            bunifuCircleProgressbar1.Value += dir;

        }
    }
}
