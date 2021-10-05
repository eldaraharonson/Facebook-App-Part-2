namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    partial class GroupPopularityForm
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
            this.header = new System.Windows.Forms.Label();
            this.memberCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(315, 141);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(59, 40);
            this.header.TabIndex = 0;
            this.header.Text = "header\r\n\r\n";
            // 
            // memberCount
            // 
            this.memberCount.AutoSize = true;
            this.memberCount.Location = new System.Drawing.Point(299, 249);
            this.memberCount.Name = "memberCount";
            this.memberCount.Size = new System.Drawing.Size(111, 20);
            this.memberCount.TabIndex = 1;
            this.memberCount.Text = "member count";
            // 
            // GroupPopularityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memberCount);
            this.Controls.Add(this.header);
            this.Name = "GroupPopularityForm";
            this.Text = "GroupPopularityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label memberCount;
    }
}