namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    partial class ChooseGroupForm
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
            this.userGroups = new System.Windows.Forms.ListBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.checkGroupPopularity_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userGroups
            // 
            this.userGroups.FormattingEnabled = true;
            this.userGroups.ItemHeight = 20;
            this.userGroups.Location = new System.Drawing.Point(175, 120);
            this.userGroups.Name = "userGroups";
            this.userGroups.Size = new System.Drawing.Size(357, 164);
            this.userGroups.TabIndex = 0;
            this.userGroups.SelectedIndexChanged += new System.EventHandler(this.userGroups_SelectedIndexChanged);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(143, 69);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(415, 20);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "This is all the grops your a member of choose one of them";
            // 
            // checkGroupPopularity_button
            // 
            this.checkGroupPopularity_button.Location = new System.Drawing.Point(239, 352);
            this.checkGroupPopularity_button.Name = "checkGroupPopularity_button";
            this.checkGroupPopularity_button.Size = new System.Drawing.Size(235, 49);
            this.checkGroupPopularity_button.TabIndex = 2;
            this.checkGroupPopularity_button.Text = "Check group popularity";
            this.checkGroupPopularity_button.UseVisualStyleBackColor = true;
            this.checkGroupPopularity_button.Click += new System.EventHandler(this.checkGroupPopularity_button_Click);
            // 
            // ChooseGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkGroupPopularity_button);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.userGroups);
            this.Name = "ChooseGroupForm";
            this.Text = "ChooseGroupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userGroups;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button checkGroupPopularity_button;
    }
}