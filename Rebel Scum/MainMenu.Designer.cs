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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 81);
            this.Controls.Add(this.MissionsButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu   --- Rebel Scum V 0.1";
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MissionsButton;
    }
}

