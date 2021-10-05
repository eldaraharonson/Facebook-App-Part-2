namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms
{
    partial class FilterOptionsForm
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
            this.preferredGenderCheckList = new System.Windows.Forms.CheckedListBox();
            this.preferredAgesCheckList = new System.Windows.Forms.CheckedListBox();
            this.genderSelectLabel = new System.Windows.Forms.Label();
            this.ageRangeLabel = new System.Windows.Forms.Label();
            this.filterOptionsMainLabel = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // preferredGenderCheckList
            // 
            this.preferredGenderCheckList.BackColor = System.Drawing.SystemColors.Menu;
            this.preferredGenderCheckList.CheckOnClick = true;
            this.preferredGenderCheckList.FormattingEnabled = true;
            this.preferredGenderCheckList.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.preferredGenderCheckList.Location = new System.Drawing.Point(12, 80);
            this.preferredGenderCheckList.Name = "preferredGenderCheckList";
            this.preferredGenderCheckList.Size = new System.Drawing.Size(107, 34);
            this.preferredGenderCheckList.TabIndex = 0;
            // 
            // preferredAgesCheckList
            // 
            this.preferredAgesCheckList.BackColor = System.Drawing.SystemColors.Menu;
            this.preferredAgesCheckList.CheckOnClick = true;
            this.preferredAgesCheckList.FormattingEnabled = true;
            this.preferredAgesCheckList.Items.AddRange(new object[] {
            "18 - 25",
            "26 - 35",
            "36 - 50",
            "50 - 120"});
            this.preferredAgesCheckList.Location = new System.Drawing.Point(225, 80);
            this.preferredAgesCheckList.Name = "preferredAgesCheckList";
            this.preferredAgesCheckList.Size = new System.Drawing.Size(120, 64);
            this.preferredAgesCheckList.TabIndex = 1;
            // 
            // genderSelectLabel
            // 
            this.genderSelectLabel.AutoSize = true;
            this.genderSelectLabel.Location = new System.Drawing.Point(9, 63);
            this.genderSelectLabel.Name = "genderSelectLabel";
            this.genderSelectLabel.Size = new System.Drawing.Size(98, 13);
            this.genderSelectLabel.TabIndex = 2;
            this.genderSelectLabel.Text = "Preferred Gender/s";
            // 
            // ageRangeLabel
            // 
            this.ageRangeLabel.AutoSize = true;
            this.ageRangeLabel.Location = new System.Drawing.Point(222, 63);
            this.ageRangeLabel.Name = "ageRangeLabel";
            this.ageRangeLabel.Size = new System.Drawing.Size(77, 13);
            this.ageRangeLabel.TabIndex = 3;
            this.ageRangeLabel.Text = "Preferred Ages";
            // 
            // filterOptionsMainLabel
            // 
            this.filterOptionsMainLabel.AutoSize = true;
            this.filterOptionsMainLabel.Location = new System.Drawing.Point(97, 9);
            this.filterOptionsMainLabel.Name = "filterOptionsMainLabel";
            this.filterOptionsMainLabel.Size = new System.Drawing.Size(154, 13);
            this.filterOptionsMainLabel.TabIndex = 4;
            this.filterOptionsMainLabel.Text = "Please check your preferences";
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(270, 171);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 5;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // FilterOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 206);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.filterOptionsMainLabel);
            this.Controls.Add(this.ageRangeLabel);
            this.Controls.Add(this.genderSelectLabel);
            this.Controls.Add(this.preferredAgesCheckList);
            this.Controls.Add(this.preferredGenderCheckList);
            this.Name = "FilterOptionsForm";
            this.Text = "Filter Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox preferredGenderCheckList;
        private System.Windows.Forms.CheckedListBox preferredAgesCheckList;
        private System.Windows.Forms.Label genderSelectLabel;
        private System.Windows.Forms.Label ageRangeLabel;
        private System.Windows.Forms.Label filterOptionsMainLabel;
        private System.Windows.Forms.Button finishButton;
    }
}