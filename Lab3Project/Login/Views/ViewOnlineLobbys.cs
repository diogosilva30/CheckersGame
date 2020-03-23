using LabProject.GameServer;
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
    public partial class ViewOnline : Form
    {
        #region PrivateVariables
        private IGameRelayService service = new IGameRelayService();
        #endregion
        public ViewOnline()
        {
            InitializeComponent();
        }
        
        private void buttonGetServerList_Click(object sender, EventArgs e)
        {
            ServerInfo[] List = service.GetServerList();

            ListViewServers.Items.Clear();
            foreach (var item in List)
            {
                var line = new ListViewItem(item.GameId);
                line.SubItems.Add(item.ServerName);
                line.SubItems.Add(item.PlayersCount.ToString());
                ListViewServers.Items.Add(line);
            }


        }

        private void buttonCreateServer_Click(object sender, EventArgs e)
        {
            service.SetupServer();
        }

        private void ButtonGoBack_Click(object sender, EventArgs e)
        {
            Program.V_SelectGameMode.Visible = true;
            Close();
        }

        private void ListViewServidores_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth =ListViewServers.Columns[e.ColumnIndex].Width;
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewPlayers.Columns[e.ColumnIndex].Width;
        }

        private void ListViewServidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewServers.SelectedItems.Count == 0)
                return;

            string name = this.ListViewServers.SelectedItems[0].Text;

            var GameData = service.GetGameData(name);

            listViewPlayers.Items.Clear();
            foreach (var item in GameData.Players)
            {
                var line = new ListViewItem(item.Username);
                line.SubItems.Add(item.Name);
                line.SubItems.Add(item.Country);
                listViewPlayers.Items.Add(line);

            }
        }

        private void listViewPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewPlayers.SelectedItems.Count == 0)
                return;

            string PlayerUsername = this.listViewPlayers.SelectedItems[0].Text;

            if (this.ListViewServers.SelectedItems.Count == 0)
                return;
            

            var GameData = service.GetGameData(ListViewServers.SelectedItems[0].Text);

            var player = GameData.Players.Where(X => X.Username == PlayerUsername).First();

            pictureBoxFoto.Image = (Bitmap)((new ImageConverter()).ConvertFrom(player.PhotoBytes));

            SelectedPlayer.Text = PlayerUsername;
            labelName.Text = "Name: "+ player.Name;
            labelCountry.Text = "Country: "+ player.Country;
            labelTotalGames.Text ="Total Games: " + player.GamesStartedStats;
            labelWins.Text = "Wins: " + player.GamesWonStats;
            labelLosts.Text = "Losts: " + player.GamesLostStats;
            labelAbandoned.Text ="Abandoned: "+ player.GamesAbandonedStats;
            
        }

        private void ListViewServers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.ListViewServers.SelectedItems.Count == 0)
                return;

            string name = this.ListViewServers.SelectedItems[0].Text;

            var profile = new PlayerInfo();

            profile.Country = (Program.M_Game.Game.Players[0] as RealPlayer).Country;
            profile.Username = (Program.M_Game.Game.Players[0] as RealPlayer).Username;
            profile.Name = (Program.M_Game.Game.Players[0] as RealPlayer).Name + " "+ (Program.M_Game.Game.Players[0] as RealPlayer).Surname;
            profile.GamesAbandonedStats = Program.M_Game.Game.Players[0].N_Left;
            profile.GamesLostStats = Program.M_Game.Game.Players[0].N_Losts;
            profile.GamesStartedStats = Program.M_Game.Game.Players[0].N_Games;
            profile.GamesWonStats = Program.M_Game.Game.Players[0].N_Wins;

            service.JoinServer(name, profile);
            int a = this.ListViewServers.SelectedIndices[0];
            ListViewServers.Items[a].Selected = false; // Doesn't fire
            ListViewServers.Items[a].Selected = true; // Does fire.

            //buttonGetServerList_Click(new object(), new EventArgs());

        }
    }
}
