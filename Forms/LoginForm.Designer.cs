﻿namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    partial class LoginForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.facebookGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.facebookGif)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LoginButton.Location = new System.Drawing.Point(498, 383);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(146, 29);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login with Facebook";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // facebookGif
            // 
            this.facebookGif.Image = global::B20_Ex01_Eldar_313371833_Idan_313116543.Properties.Resources.facebookGif;
            this.facebookGif.Location = new System.Drawing.Point(12, 39);
            this.facebookGif.Name = "facebookGif";
            this.facebookGif.Size = new System.Drawing.Size(467, 373);
            this.facebookGif.TabIndex = 2;
            this.facebookGif.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(656, 424);
            this.Controls.Add(this.facebookGif);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.facebookGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox facebookGif;
    }
}

