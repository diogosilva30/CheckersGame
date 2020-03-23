namespace LabProject
{
    partial class ViewLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLogin));
            this.BackPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonExit = new System.Windows.Forms.PictureBox();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.BoxUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.ButtonSignUp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.timerEnter = new System.Windows.Forms.Timer(this.components);
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.White;
            this.BackPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackPanel.BackgroundImage")));
            this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackPanel.CausesValidation = false;
            this.BackPanel.Controls.Add(this.buttonExit);
            this.BackPanel.Controls.Add(this.PanelLogin);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.GradientBottomLeft = System.Drawing.Color.RoyalBlue;
            this.BackPanel.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.BackPanel.GradientTopLeft = System.Drawing.Color.Plum;
            this.BackPanel.GradientTopRight = System.Drawing.Color.LightSkyBlue;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Quality = 10;
            this.BackPanel.Size = new System.Drawing.Size(1000, 750);
            this.BackPanel.TabIndex = 4;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Location = new System.Drawing.Point(972, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(25, 25);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // PanelLogin
            // 
            this.PanelLogin.AutoSize = true;
            this.PanelLogin.BackColor = System.Drawing.Color.White;
            this.PanelLogin.Controls.Add(this.ErrorLabel);
            this.PanelLogin.Controls.Add(this.BoxUserName);
            this.PanelLogin.Controls.Add(this.labelWelcome);
            this.PanelLogin.Controls.Add(this.ButtonSignUp);
            this.PanelLogin.Controls.Add(this.buttonLogin);
            this.PanelLogin.Controls.Add(this.BoxPassword);
            this.PanelLogin.Controls.Add(this.logo);
            this.PanelLogin.ForeColor = System.Drawing.Color.Transparent;
            this.PanelLogin.Location = new System.Drawing.Point(282, 100);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(438, 550);
            this.PanelLogin.TabIndex = 0;
            this.PanelLogin.TabStop = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorLabel.Location = new System.Drawing.Point(65, 510);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(325, 21);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "Error: The password or username is incorrect!";
            this.ErrorLabel.Visible = false;
            // 
            // BoxUserName
            // 
            this.BoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BoxUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BoxUserName.HintForeColor = System.Drawing.Color.Transparent;
            this.BoxUserName.HintText = "";
            this.BoxUserName.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.BoxUserName.isPassword = false;
            this.BoxUserName.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.BoxUserName.LineIdleColor = System.Drawing.Color.Gray;
            this.BoxUserName.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.BoxUserName.LineThickness = 4;
            this.BoxUserName.Location = new System.Drawing.Point(45, 247);
            this.BoxUserName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BoxUserName.Name = "BoxUserName";
            this.BoxUserName.Size = new System.Drawing.Size(346, 60);
            this.BoxUserName.TabIndex = 1;
            this.BoxUserName.Text = "Username";
            this.BoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BoxUserName.Enter += new System.EventHandler(this.BoxUsernameEnter);
            this.BoxUserName.Leave += new System.EventHandler(this.BoxUsernameLeave);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(175, 138);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(35, 13);
            this.labelWelcome.TabIndex = 6;
            this.labelWelcome.Text = "label1";
            this.labelWelcome.Visible = false;
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.AutoSize = true;
            this.ButtonSignUp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonSignUp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ButtonSignUp.Location = new System.Drawing.Point(326, 415);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(65, 21);
            this.ButtonSignUp.TabIndex = 4;
            this.ButtonSignUp.Text = "Sign Up";
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.ActiveBorderThickness = 1;
            this.buttonLogin.ActiveCornerRadius = 20;
            this.buttonLogin.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.ActiveForecolor = System.Drawing.Color.White;
            this.buttonLogin.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.ButtonText = "Login";
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.IdleBorderThickness = 1;
            this.buttonLogin.IdleCornerRadius = 20;
            this.buttonLogin.IdleFillColor = System.Drawing.Color.White;
            this.buttonLogin.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.Location = new System.Drawing.Point(111, 464);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(212, 41);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLogin.Click += new System.EventHandler(this.ClickButtonLogin);
            // 
            // BoxPassword
            // 
            this.BoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BoxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.BoxPassword.HintText = "";
            this.BoxPassword.isPassword = true;
            this.BoxPassword.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.BoxPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.BoxPassword.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.BoxPassword.LineThickness = 4;
            this.BoxPassword.Location = new System.Drawing.Point(45, 323);
            this.BoxPassword.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.Size = new System.Drawing.Size(346, 60);
            this.BoxPassword.TabIndex = 2;
            this.BoxPassword.Text = "Password";
            this.BoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BoxPassword.Enter += new System.EventHandler(this.BoxPasswordEnter);
            this.BoxPassword.Leave += new System.EventHandler(this.BoxPasswordLeave);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(112, -2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(212, 200);
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // timerEnter
            // 
            this.timerEnter.Interval = 3000;
            this.timerEnter.Tick += new System.EventHandler(this.timerEnter_Tick);
            // 
            // ViewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.BackPanel);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo das Damas";
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel BackPanel;
        private System.Windows.Forms.Panel PanelLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BoxUserName;
        private System.Windows.Forms.Label labelWelcome;
        private Bunifu.Framework.UI.BunifuCustomLabel ButtonSignUp;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BoxPassword;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox buttonExit;
        private System.Windows.Forms.Timer timerEnter;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

