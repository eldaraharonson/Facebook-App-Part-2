namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms
{
    partial class FoundSoulmateForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.soulmateNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soulmateProfilePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soulmateProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::B20_Ex01_Eldar_313371833_Idan_313116543.Properties.Resources.heart;
            this.pictureBox2.Location = new System.Drawing.Point(76, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 163);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // soulmateNameLabel
            // 
            this.soulmateNameLabel.AutoSize = true;
            this.soulmateNameLabel.Location = new System.Drawing.Point(113, 188);
            this.soulmateNameLabel.Name = "soulmateNameLabel";
            this.soulmateNameLabel.Size = new System.Drawing.Size(185, 13);
            this.soulmateNameLabel.TabIndex = 2;
            this.soulmateNameLabel.Text = "{Name} has given you the most likes!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // soulmateProfilePicture
            // 
            this.soulmateProfilePicture.Location = new System.Drawing.Point(192, 53);
            this.soulmateProfilePicture.Name = "soulmateProfilePicture";
            this.soulmateProfilePicture.Size = new System.Drawing.Size(67, 70);
            this.soulmateProfilePicture.TabIndex = 4;
            this.soulmateProfilePicture.TabStop = false;
            // 
            // FoundSoulmateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(455, 315);
            this.Controls.Add(this.soulmateProfilePicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soulmateNameLabel);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FoundSoulmateForm";
            this.Text = "Your Soulmate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soulmateProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label soulmateNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox soulmateProfilePicture;
    }
}