namespace RebelScum
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.MissionsButton = new System.Windows.Forms.Button();
            this.btnAdvanceDay = new System.Windows.Forms.Button();
            this.btnAdvanceWeek = new System.Windows.Forms.Button();
            this.btnAdvanceMonth = new System.Windows.Forms.Button();
            this.btnAdvanceSemester = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MissionsButton
            // 
            this.MissionsButton.Image = ((System.Drawing.Image)(resources.GetObject("MissionsButton.Image")));
            this.MissionsButton.Location = new System.Drawing.Point(13, 13);
            this.MissionsButton.Name = "MissionsButton";
            this.MissionsButton.Size = new System.Drawing.Size(60, 60);
            this.MissionsButton.TabIndex = 0;
            this.MissionsButton.UseVisualStyleBackColor = true;
            this.MissionsButton.Click += new System.EventHandler(this.MissionsButton_Click);
            // 
            // btnAdvanceDay
            // 
            this.btnAdvanceDay.Location = new System.Drawing.Point(13, 79);
            this.btnAdvanceDay.Name = "btnAdvanceDay";
            this.btnAdvanceDay.Size = new System.Drawing.Size(93, 36);
            this.btnAdvanceDay.TabIndex = 1;
            this.btnAdvanceDay.Text = "+1 Day";
            this.btnAdvanceDay.UseVisualStyleBackColor = true;
            // 
            // btnAdvanceWeek
            // 
            this.btnAdvanceWeek.Location = new System.Drawing.Point(112, 79);
            this.btnAdvanceWeek.Name = "btnAdvanceWeek";
            this.btnAdvanceWeek.Size = new System.Drawing.Size(93, 36);
            this.btnAdvanceWeek.TabIndex = 2;
            this.btnAdvanceWeek.Text = "+1 Week";
            this.btnAdvanceWeek.UseVisualStyleBackColor = true;
            // 
            // btnAdvanceMonth
            // 
            this.btnAdvanceMonth.Location = new System.Drawing.Point(211, 79);
            this.btnAdvanceMonth.Name = "btnAdvanceMonth";
            this.btnAdvanceMonth.Size = new System.Drawing.Size(93, 36);
            this.btnAdvanceMonth.TabIndex = 3;
            this.btnAdvanceMonth.Text = "+1 Month";
            this.btnAdvanceMonth.UseVisualStyleBackColor = true;
            // 
            // btnAdvanceSemester
            // 
            this.btnAdvanceSemester.Location = new System.Drawing.Point(310, 79);
            this.btnAdvanceSemester.Name = "btnAdvanceSemester";
            this.btnAdvanceSemester.Size = new System.Drawing.Size(93, 36);
            this.btnAdvanceSemester.TabIndex = 4;
            this.btnAdvanceSemester.Text = "+6 Months";
            this.btnAdvanceSemester.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 126);
            this.Controls.Add(this.btnAdvanceSemester);
            this.Controls.Add(this.btnAdvanceMonth);
            this.Controls.Add(this.btnAdvanceWeek);
            this.Controls.Add(this.btnAdvanceDay);
            this.Controls.Add(this.MissionsButton);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu   --- Rebel Scum V 0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MissionsButton;
        private System.Windows.Forms.Button btnAdvanceDay;
        private System.Windows.Forms.Button btnAdvanceWeek;
        private System.Windows.Forms.Button btnAdvanceMonth;
        private System.Windows.Forms.Button btnAdvanceSemester;
    }
}

