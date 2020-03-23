namespace LabProject
{
    partial class ViewSelectGameMode
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSelectGameMode));
            this.FundoPrincipal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PanelSignUp = new System.Windows.Forms.Panel();
            this.LabelErrorLoading = new System.Windows.Forms.Label();
            this.buttonLoadGame = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonOnline = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonPlayerVsPlayer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonGoBack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonPlayerVsPc = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logo = new System.Windows.Forms.PictureBox();
            this.FundoPrincipal.SuspendLayout();
            this.PanelSignUp.SuspendLayout();
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
            this.FundoPrincipal.TabIndex = 2;
            // 
            // PanelSignUp
            // 
            this.PanelSignUp.AutoSize = true;
            this.PanelSignUp.BackColor = System.Drawing.Color.White;
            this.PanelSignUp.Controls.Add(this.LabelErrorLoading);
            this.PanelSignUp.Controls.Add(this.buttonLoadGame);
            this.PanelSignUp.Controls.Add(this.buttonOnline);
            this.PanelSignUp.Controls.Add(this.buttonPlayerVsPlayer);
            this.PanelSignUp.Controls.Add(this.ButtonGoBack);
            this.PanelSignUp.Controls.Add(this.buttonPlayerVsPc);
            this.PanelSignUp.Controls.Add(this.logo);
            this.PanelSignUp.ForeColor = System.Drawing.Color.Transparent;
            this.PanelSignUp.Location = new System.Drawing.Point(25, 25);
            this.PanelSignUp.Name = "PanelSignUp";
            this.PanelSignUp.Size = new System.Drawing.Size(950, 725);
            this.PanelSignUp.TabIndex = 2;
            this.PanelSignUp.TabStop = true;
            // 
            // LabelErrorLoading
            // 
            this.LabelErrorLoading.AutoSize = true;
            this.LabelErrorLoading.BackColor = System.Drawing.Color.Transparent;
            this.LabelErrorLoading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelErrorLoading.ForeColor = System.Drawing.Color.Red;
            this.LabelErrorLoading.Location = new System.Drawing.Point(351, 596);
            this.LabelErrorLoading.Name = "LabelErrorLoading";
            this.LabelErrorLoading.Size = new System.Drawing.Size(214, 21);
            this.LabelErrorLoading.TabIndex = 61;
            this.LabelErrorLoading.Text = "Game Loaded With Sucess!";
            this.LabelErrorLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelErrorLoading.Visible = false;
            // 
            // buttonLoadGame
            // 
            this.buttonLoadGame.ActiveBorderThickness = 1;
            this.buttonLoadGame.ActiveCornerRadius = 20;
            this.buttonLoadGame.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.buttonLoadGame.ActiveForecolor = System.Drawing.Color.White;
            this.buttonLoadGame.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonLoadGame.AutoScroll = true;
            this.buttonLoadGame.BackColor = System.Drawing.Color.White;
            this.buttonLoadGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLoadGame.BackgroundImage")));
            this.buttonLoadGame.ButtonText = "Load Game";
            this.buttonLoadGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadGame.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadGame.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonLoadGame.IdleBorderThickness = 1;
            this.buttonLoadGame.IdleCornerRadius = 20;
            this.buttonLoadGame.IdleFillColor = System.Drawing.Color.White;
            this.buttonLoadGame.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.buttonLoadGame.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonLoadGame.Location = new System.Drawing.Point(320, 522);
            this.buttonLoadGame.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonLoadGame.Name = "buttonLoadGame";
            this.buttonLoadGame.Size = new System.Drawing.Size(295, 68);
            this.buttonLoadGame.TabIndex = 60;
            this.buttonLoadGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLoadGame.Click += new System.EventHandler(this.buttonLoadGame_Click);
            // 
            // buttonOnline
            // 
            this.buttonOnline.ActiveBorderThickness = 1;
            this.buttonOnline.ActiveCornerRadius = 20;
            this.buttonOnline.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.buttonOnline.ActiveForecolor = System.Drawing.Color.White;
            this.buttonOnline.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonOnline.AutoScroll = true;
            this.buttonOnline.BackColor = System.Drawing.Color.White;
            this.buttonOnline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOnline.BackgroundImage")));
            this.buttonOnline.ButtonText = "Online";
            this.buttonOnline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOnline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOnline.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonOnline.IdleBorderThickness = 1;
            this.buttonOnline.IdleCornerRadius = 20;
            this.buttonOnline.IdleFillColor = System.Drawing.Color.White;
            this.buttonOnline.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.buttonOnline.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonOnline.Location = new System.Drawing.Point(320, 427);
            this.buttonOnline.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonOnline.Name = "buttonOnline";
            this.buttonOnline.Size = new System.Drawing.Size(295, 68);
            this.buttonOnline.TabIndex = 59;
            this.buttonOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOnline.Click += new System.EventHandler(this.buttonOnline_Click);
            // 
            // buttonPlayerVsPlayer
            // 
            this.buttonPlayerVsPlayer.ActiveBorderThickness = 1;
            this.buttonPlayerVsPlayer.ActiveCornerRadius = 20;
            this.buttonPlayerVsPlayer.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.buttonPlayerVsPlayer.ActiveForecolor = System.Drawing.Color.White;
            this.buttonPlayerVsPlayer.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonPlayerVsPlayer.AutoScroll = true;
            this.buttonPlayerVsPlayer.BackColor = System.Drawing.Color.White;
            this.buttonPlayerVsPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayerVsPlayer.BackgroundImage")));
            this.buttonPlayerVsPlayer.ButtonText = "Player VS Player";
            this.buttonPlayerVsPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayerVsPlayer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerVsPlayer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonPlayerVsPlayer.IdleBorderThickness = 1;
            this.buttonPlayerVsPlayer.IdleCornerRadius = 20;
            this.buttonPlayerVsPlayer.IdleFillColor = System.Drawing.Color.White;
            this.buttonPlayerVsPlayer.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.buttonPlayerVsPlayer.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonPlayerVsPlayer.Location = new System.Drawing.Point(320, 328);
            this.buttonPlayerVsPlayer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonPlayerVsPlayer.Name = "buttonPlayerVsPlayer";
            this.buttonPlayerVsPlayer.Size = new System.Drawing.Size(295, 68);
            this.buttonPlayerVsPlayer.TabIndex = 58;
            this.buttonPlayerVsPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPlayerVsPlayer.Click += new System.EventHandler(this.buttonPlayerVsPlayer_Click);
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
            // buttonPlayerVsPc
            // 
            this.buttonPlayerVsPc.ActiveBorderThickness = 1;
            this.buttonPlayerVsPc.ActiveCornerRadius = 20;
            this.buttonPlayerVsPc.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.buttonPlayerVsPc.ActiveForecolor = System.Drawing.Color.White;
            this.buttonPlayerVsPc.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonPlayerVsPc.AutoScroll = true;
            this.buttonPlayerVsPc.BackColor = System.Drawing.Color.White;
            this.buttonPlayerVsPc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayerVsPc.BackgroundImage")));
            this.buttonPlayerVsPc.ButtonText = "Player VS PC";
            this.buttonPlayerVsPc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayerVsPc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerVsPc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonPlayerVsPc.IdleBorderThickness = 1;
            this.buttonPlayerVsPc.IdleCornerRadius = 20;
            this.buttonPlayerVsPc.IdleFillColor = System.Drawing.Color.White;
            this.buttonPlayerVsPc.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.buttonPlayerVsPc.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonPlayerVsPc.Location = new System.Drawing.Point(320, 237);
            this.buttonPlayerVsPc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonPlayerVsPc.Name = "buttonPlayerVsPc";
            this.buttonPlayerVsPc.Size = new System.Drawing.Size(295, 68);
            this.buttonPlayerVsPc.TabIndex = 31;
            this.buttonPlayerVsPc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPlayerVsPc.Click += new System.EventHandler(this.buttonPlayerVsPc_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(288, 16);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(358, 194);
            this.logo.TabIndex = 17;
            this.logo.TabStop = false;
            // 
            // ViewSelectGameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.FundoPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewSelectGameMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkers Game";
            this.FundoPrincipal.ResumeLayout(false);
            this.FundoPrincipal.PerformLayout();
            this.PanelSignUp.ResumeLayout(false);
            this.PanelSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel FundoPrincipal;
        private System.Windows.Forms.Panel PanelSignUp;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonPlayerVsPc;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonGoBack;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonOnline;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonPlayerVsPlayer;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonLoadGame;
        private System.Windows.Forms.Label LabelErrorLoading;
    }
}