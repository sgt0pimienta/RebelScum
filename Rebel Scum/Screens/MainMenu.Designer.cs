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
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnAdvanceDay.Click += new System.EventHandler(this.btnAdvanceDay_Click);
            // 
            // btnAdvanceWeek
            // 
            this.btnAdvanceWeek.Location = new System.Drawing.Point(112, 79);
            this.btnAdvanceWeek.Name = "btnAdvanceWeek";
            this.btnAdvanceWeek.Size = new System.Drawing.Size(93, 36);
            this.btnAdvanceWeek.TabIndex = 2;
            this.btnAdvanceWeek.Text = "+1 Week";
            this.btnAdvanceWeek.UseVisualStyleBackColor = true;
            this.btnAdvanceWeek.Click += new System.EventHandler(this.btnAdvanceWeek_Click);
            // 
            // btnAdvanceMonth
            // 
            this.btnAdvanceMonth.Location = new System.Drawing.Point(211, 79);
            this.btnAdvanceMonth.Name = "btnAdvanceMonth";
            this.btnAdvanceMonth.Size = new System.Drawing.Size(93, 36);
            this.btnAdvanceMonth.TabIndex = 3;
            this.btnAdvanceMonth.Text = "+1 Month";
            this.btnAdvanceMonth.UseVisualStyleBackColor = true;
            this.btnAdvanceMonth.Click += new System.EventHandler(this.btnAdvanceMonth_Click);
            // 
            // btnAdvanceSemester
            // 
            this.btnAdvanceSemester.Location = new System.Drawing.Point(310, 79);
            this.btnAdvanceSemester.Name = "btnAdvanceSemester";
            this.btnAdvanceSemester.Size = new System.Drawing.Size(93, 36);
            this.btnAdvanceSemester.TabIndex = 4;
            this.btnAdvanceSemester.Text = "+6 Months";
            this.btnAdvanceSemester.UseVisualStyleBackColor = true;
            this.btnAdvanceSemester.Click += new System.EventHandler(this.btnAdvanceSemester_Click);
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.Location = new System.Drawing.Point(908, 88);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(157, 28);
            this.btnSaveGame.TabIndex = 5;
            this.btnSaveGame.Text = "Save Game";
            this.btnSaveGame.UseVisualStyleBackColor = true;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(908, 50);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(157, 23);
            this.btnLoadGame.TabIndex = 6;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLoadGame_MouseClick);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(100, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 126);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnSaveGame);
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
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button button1;
    }
}

