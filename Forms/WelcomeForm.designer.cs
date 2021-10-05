namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    partial class WelcomeForm
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
            this.userProfilePicture = new System.Windows.Forms.PictureBox();
            this.findStalkerButton = new System.Windows.Forms.Button();
            this.groupPopularityButtom = new System.Windows.Forms.Button();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userProfilePicture
            // 
            this.userProfilePicture.Location = new System.Drawing.Point(286, 12);
            this.userProfilePicture.Name = "userProfilePicture";
            this.userProfilePicture.Size = new System.Drawing.Size(152, 142);
            this.userProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userProfilePicture.TabIndex = 0;
            this.userProfilePicture.TabStop = false;
            // 
            // findStalkerButton
            // 
            this.findStalkerButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.findStalkerButton.Location = new System.Drawing.Point(12, 250);
            this.findStalkerButton.Name = "findStalkerButton";
            this.findStalkerButton.Size = new System.Drawing.Size(158, 44);
            this.findStalkerButton.TabIndex = 1;
            this.findStalkerButton.Text = "Find Your Soulmate";
            this.findStalkerButton.UseVisualStyleBackColor = true;
            this.findStalkerButton.Click += new System.EventHandler(this.findStalkerButton_Click);
            // 
            // groupPopularityButtom
            // 
            this.groupPopularityButtom.Location = new System.Drawing.Point(286, 250);
            this.groupPopularityButtom.Name = "groupPopularityButtom";
            this.groupPopularityButtom.Size = new System.Drawing.Size(152, 44);
            this.groupPopularityButtom.TabIndex = 2;
            this.groupPopularityButtom.Text = "Group Popularity";
            this.groupPopularityButtom.UseVisualStyleBackColor = true;
            this.groupPopularityButtom.Click += new System.EventHandler(this.groupPopularityButtom_Click);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 306);
            this.Controls.Add(this.groupPopularityButtom);
            this.Controls.Add(this.findStalkerButton);
            this.Controls.Add(this.userProfilePicture);
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox userProfilePicture;
        private System.Windows.Forms.Button findStalkerButton;
        private System.Windows.Forms.Button groupPopularityButtom;
        private System.Windows.Forms.BindingSource groupBindingSource;
    }
}