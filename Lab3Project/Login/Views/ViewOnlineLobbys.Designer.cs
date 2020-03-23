namespace LabProject
{
    partial class ViewOnline
    {
        private const string V = "ViewOnlineLobbys";

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOnline));
            this.FundoPrincipal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PanelSignUp = new System.Windows.Forms.Panel();
            this.SelectedPlayer = new System.Windows.Forms.GroupBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.labelAbandoned = new System.Windows.Forms.Label();
            this.labelTotalGames = new System.Windows.Forms.Label();
            this.labelLosts = new System.Windows.Forms.Label();
            this.labelWins = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.ListViewServers = new System.Windows.Forms.ListView();
            this.ServerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Players = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateServer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonGetServerList = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonGoBack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logo = new System.Windows.Forms.PictureBox();
            this.FundoPrincipal.SuspendLayout();
            this.PanelSignUp.SuspendLayout();
            this.SelectedPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // FundoPrincipal
            // 
            this.FundoPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FundoPrincipal.BackgroundImage")));
            this.FundoPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FundoPrincipal.Controls.Add(this.PanelSignUp);
            this.FundoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FundoPrincipal.GradientBottomLeft = System.Drawing.Color.RoyalBlue;
            this.FundoPrincipal.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.FundoPrincipal.GradientTopLeft = System.Drawing.Color.Plum;
            this.FundoPrincipal.GradientTopRight = System.Drawing.Color.LightSkyBlue;
            this.FundoPrincipal.Location = new System.Drawing.Point(0, 0);
            this.FundoPrincipal.Name = "FundoPrincipal";
            this.FundoPrincipal.Quality = 10;
            this.FundoPrincipal.Size = new System.Drawing.Size(1000, 750);
            this.FundoPrincipal.TabIndex = 3;
            // 
            // PanelSignUp
            // 
            this.PanelSignUp.AutoSize = true;
            this.PanelSignUp.BackColor = System.Drawing.Color.White;
            this.PanelSignUp.Controls.Add(this.SelectedPlayer);
            this.PanelSignUp.Controls.Add(this.listViewPlayers);
            this.PanelSignUp.Controls.Add(this.label2);
            this.PanelSignUp.Controls.Add(this.ListViewServers);
            this.PanelSignUp.Controls.Add(this.label1);
            this.PanelSignUp.Controls.Add(this.buttonCreateServer);
            this.PanelSignUp.Controls.Add(this.buttonGetServerList);
            this.PanelSignUp.Controls.Add(this.ButtonGoBack);
            this.PanelSignUp.Controls.Add(this.logo);
            this.PanelSignUp.ForeColor = System.Drawing.Color.Transparent;
            this.PanelSignUp.Location = new System.Drawing.Point(25, 25);
            this.PanelSignUp.Name = "PanelSignUp";
            this.PanelSignUp.Size = new System.Drawing.Size(950, 725);
            this.PanelSignUp.TabIndex = 2;
            this.PanelSignUp.TabStop = true;
            // 
            // SelectedPlayer
            // 
            this.SelectedPlayer.Controls.Add(this.pictureBoxFoto);
            this.SelectedPlayer.Controls.Add(this.labelAbandoned);
            this.SelectedPlayer.Controls.Add(this.labelTotalGames);
            this.SelectedPlayer.Controls.Add(this.labelLosts);
            this.SelectedPlayer.Controls.Add(this.labelWins);
            this.SelectedPlayer.Controls.Add(this.labelCountry);
            this.SelectedPlayer.Controls.Add(this.labelName);
            this.SelectedPlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPlayer.Location = new System.Drawing.Point(55, 360);
            this.SelectedPlayer.Name = "SelectedPlayer";
            this.SelectedPlayer.Size = new System.Drawing.Size(828, 263);
            this.SelectedPlayer.TabIndex = 67;
            this.SelectedPlayer.TabStop = false;
            this.SelectedPlayer.Text = "Selected Player";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFoto.Location = new System.Drawing.Point(578, 36);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxFoto.TabIndex = 7;
            this.pictureBoxFoto.TabStop = false;
            // 
            // labelAbandoned
            // 
            this.labelAbandoned.AutoSize = true;
            this.labelAbandoned.ForeColor = System.Drawing.Color.Black;
            this.labelAbandoned.Location = new System.Drawing.Point(24, 198);
            this.labelAbandoned.Name = "labelAbandoned";
            this.labelAbandoned.Size = new System.Drawing.Size(97, 21);
            this.labelAbandoned.TabIndex = 6;
            this.labelAbandoned.Text = "Abandoned: ";
            // 
            // labelTotalGames
            // 
            this.labelTotalGames.AutoSize = true;
            this.labelTotalGames.ForeColor = System.Drawing.Color.Black;
            this.labelTotalGames.Location = new System.Drawing.Point(24, 103);
            this.labelTotalGames.Name = "labelTotalGames";
            this.labelTotalGames.Size = new System.Drawing.Size(101, 21);
            this.labelTotalGames.TabIndex = 5;
            this.labelTotalGames.Text = "Total Games: ";
            // 
            // labelLosts
            // 
            this.labelLosts.AutoSize = true;
            this.labelLosts.ForeColor = System.Drawing.Color.Black;
            this.labelLosts.Location = new System.Drawing.Point(24, 166);
            this.labelLosts.Name = "labelLosts";
            this.labelLosts.Size = new System.Drawing.Size(53, 21);
            this.labelLosts.TabIndex = 4;
            this.labelLosts.Text = "Losts: ";
            // 
            // labelWins
            // 
            this.labelWins.AutoSize = true;
            this.labelWins.ForeColor = System.Drawing.Color.Black;
            this.labelWins.Location = new System.Drawing.Point(24, 135);
            this.labelWins.Name = "labelWins";
            this.labelWins.Size = new System.Drawing.Size(52, 21);
            this.labelWins.TabIndex = 3;
            this.labelWins.Text = "Wins: ";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.ForeColor = System.Drawing.Color.Black;
            this.labelCountry.Location = new System.Drawing.Point(24, 68);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(73, 21);
            this.labelCountry.TabIndex = 2;
            this.labelCountry.Text = "Country: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(24, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name: ";
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.username,
            this.PlayerName,
            this.Country});
            this.listViewPlayers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPlayers.FullRowSelect = true;
            this.listViewPlayers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPlayers.Location = new System.Drawing.Point(516, 197);
            this.listViewPlayers.MultiSelect = false;
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(367, 135);
            this.listViewPlayers.TabIndex = 66;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.View = System.Windows.Forms.View.Details;
            this.listViewPlayers.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listViewPlayers.SelectedIndexChanged += new System.EventHandler(this.listViewPlayers_SelectedIndexChanged);
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.Width = 103;
            // 
            // PlayerName
            // 
            this.PlayerName.Text = "Player Name";
            this.PlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerName.Width = 107;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Country.Width = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(512, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Players on Server";
            // 
            // ListViewServers
            // 
            this.ListViewServers.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.ListViewServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ServerID,
            this.ServerName,
            this.Players});
            this.ListViewServers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewServers.FullRowSelect = true;
            this.ListViewServers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewServers.Location = new System.Drawing.Point(54, 197);
            this.ListViewServers.MultiSelect = false;
            this.ListViewServers.Name = "ListViewServers";
            this.ListViewServers.Size = new System.Drawing.Size(355, 135);
            this.ListViewServers.TabIndex = 63;
            this.ListViewServers.UseCompatibleStateImageBehavior = false;
            this.ListViewServers.View = System.Windows.Forms.View.Details;
            this.ListViewServers.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListViewServidores_ColumnWidthChanging);
            this.ListViewServers.SelectedIndexChanged += new System.EventHandler(this.ListViewServidores_SelectedIndexChanged);
            this.ListViewServers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewServers_MouseDoubleClick);
            // 
            // ServerID
            // 
            this.ServerID.Text = "ID";
            this.ServerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServerName
            // 
            this.ServerName.Text = "Server Name";
            this.ServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ServerName.Width = 147;
            // 
            // Players
            // 
            this.Players.Text = "Number of Players";
            this.Players.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Players.Width = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "Server List";
            // 
            // buttonCreateServer
            // 
            this.buttonCreateServer.ActiveBorderThickness = 1;
            this.buttonCreateServer.ActiveCornerRadius = 20;
            this.buttonCreateServer.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.buttonCreateServer.ActiveForecolor = System.Drawing.Color.White;
            this.buttonCreateServer.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonCreateServer.AutoScroll = true;
            this.buttonCreateServer.BackColor = System.Drawing.Color.White;
            this.buttonCreateServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCreateServer.BackgroundImage")));
            this.buttonCreateServer.ButtonText = "Create Server";
            this.buttonCreateServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateServer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateServer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonCreateServer.IdleBorderThickness = 1;
            this.buttonCreateServer.IdleCornerRadius = 20;
            this.buttonCreateServer.IdleFillColor = System.Drawing.Color.White;
            this.buttonCreateServer.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.buttonCreateServer.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonCreateServer.Location = new System.Drawing.Point(54, 67);
            this.buttonCreateServer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCreateServer.Name = "buttonCreateServer";
            this.buttonCreateServer.Size = new System.Drawing.Size(198, 43);
            this.buttonCreateServer.TabIndex = 60;
            this.buttonCreateServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCreateServer.Click += new System.EventHandler(this.buttonCreateServer_Click);
            // 
            // buttonGetServerList
            // 
            this.buttonGetServerList.ActiveBorderThickness = 1;
            this.buttonGetServerList.ActiveCornerRadius = 20;
            this.buttonGetServerList.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.buttonGetServerList.ActiveForecolor = System.Drawing.Color.White;
            this.buttonGetServerList.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonGetServerList.AutoScroll = true;
            this.buttonGetServerList.BackColor = System.Drawing.Color.White;
            this.buttonGetServerList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGetServerList.BackgroundImage")));
            this.buttonGetServerList.ButtonText = "Get Server List";
            this.buttonGetServerList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGetServerList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetServerList.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonGetServerList.IdleBorderThickness = 1;
            this.buttonGetServerList.IdleCornerRadius = 20;
            this.buttonGetServerList.IdleFillColor = System.Drawing.Color.White;
            this.buttonGetServerList.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.buttonGetServerList.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonGetServerList.Location = new System.Drawing.Point(54, 110);
            this.buttonGetServerList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonGetServerList.Name = "buttonGetServerList";
            this.buttonGetServerList.Size = new System.Drawing.Size(198, 43);
            this.buttonGetServerList.TabIndex = 59;
            this.buttonGetServerList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonGetServerList.Click += new System.EventHandler(this.buttonGetServerList_Click);
            // 
            // ButtonGoBack
            // 
            this.ButtonGoBack.ActiveBorderThickness = 1;
            this.ButtonGoBack.ActiveCornerRadius = 20;
            this.ButtonGoBack.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.ButtonGoBack.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonGoBack.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.ButtonGoBack.BackColor = System.Drawing.Color.White;
            this.ButtonGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGoBack.BackgroundImage")));
            this.ButtonGoBack.ButtonText = "Go back";
            this.ButtonGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGoBack.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ButtonGoBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ButtonGoBack.IdleBorderThickness = 1;
            this.ButtonGoBack.IdleCornerRadius = 20;
            this.ButtonGoBack.IdleFillColor = System.Drawing.Color.White;
            this.ButtonGoBack.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.ButtonGoBack.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.ButtonGoBack.Location = new System.Drawing.Point(5, 671);
            this.ButtonGoBack.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonGoBack.Name = "ButtonGoBack";
            this.ButtonGoBack.Size = new System.Drawing.Size(212, 41);
            this.ButtonGoBack.TabIndex = 57;
            this.ButtonGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonGoBack.Click += new System.EventHandler(this.ButtonGoBack_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(358, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(234, 96);
            this.logo.TabIndex = 17;
            this.logo.TabStop = false;
            // 
            // ViewOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.FundoPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewOnline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkers Game";
            this.FundoPrincipal.ResumeLayout(false);
            this.FundoPrincipal.PerformLayout();
            this.PanelSignUp.ResumeLayout(false);
            this.PanelSignUp.PerformLayout();
            this.SelectedPlayer.ResumeLayout(false);
            this.SelectedPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel FundoPrincipal;
        private System.Windows.Forms.Panel PanelSignUp;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonGoBack;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonCreateServer;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonGetServerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ListViewServers;
        private System.Windows.Forms.ColumnHeader ServerName;
        private System.Windows.Forms.ColumnHeader Players;
        private System.Windows.Forms.ColumnHeader ServerID;
        private System.Windows.Forms.ListView listViewPlayers;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader PlayerName;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.GroupBox SelectedPlayer;
        private System.Windows.Forms.Label labelTotalGames;
        private System.Windows.Forms.Label labelLosts;
        private System.Windows.Forms.Label labelWins;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label labelAbandoned;
    }
}