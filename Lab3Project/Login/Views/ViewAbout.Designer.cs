namespace LabProject
{
    partial class ViewAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAbout));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonExit = new System.Windows.Forms.PictureBox();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.PlayerFoto = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.buttonExit);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomTextbox1);
            this.bunifuGradientPanel1.Controls.Add(this.PlayerFoto);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(407, 241);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Location = new System.Drawing.Point(379, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(25, 25);
            this.buttonExit.TabIndex = 60;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.RosyBrown;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(177, 44);
            this.bunifuCustomTextbox1.Multiline = true;
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.ReadOnly = true;
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(225, 170);
            this.bunifuCustomTextbox1.TabIndex = 59;
            this.bunifuCustomTextbox1.TabStop = false;
            this.bunifuCustomTextbox1.Text = "Work done by: \r\n- Carlos Magalhães\r\n- Diogo Silva\r\n- Simão Gonçalves";
            // 
            // PlayerFoto
            // 
            this.PlayerFoto.BackColor = System.Drawing.Color.Transparent;
            this.PlayerFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayerFoto.BackgroundImage")));
            this.PlayerFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerFoto.Location = new System.Drawing.Point(3, 44);
            this.PlayerFoto.Name = "PlayerFoto";
            this.PlayerFoto.Size = new System.Drawing.Size(170, 170);
            this.PlayerFoto.TabIndex = 58;
            this.PlayerFoto.TabStop = false;
            // 
            // ViewAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 241);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About us";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private System.Windows.Forms.PictureBox PlayerFoto;
        private System.Windows.Forms.PictureBox buttonExit;
    }
}