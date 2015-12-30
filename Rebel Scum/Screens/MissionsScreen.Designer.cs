namespace RebelScum.Screens
{
    partial class MissionsScreen
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
            this.missionScopeDropdown = new System.Windows.Forms.ComboBox();
            this.missionScopeLabel = new System.Windows.Forms.Label();
            this.missionTypeDropdown = new System.Windows.Forms.ComboBox();
            this.missionTypeLabel = new System.Windows.Forms.Label();
            this.missionListDropdown = new System.Windows.Forms.ComboBox();
            this.missionListLabel = new System.Windows.Forms.Label();
            this.activeMissionsTable = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scopeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeMissionsLabel = new System.Windows.Forms.Label();
            this.createMissionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activeMissionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // missionScopeDropdown
            // 
            this.missionScopeDropdown.DropDownWidth = 120;
            this.missionScopeDropdown.FormattingEnabled = true;
            this.missionScopeDropdown.Items.AddRange(new object[] {
            "Galaxy",
            "System",
            "Planet"});
            this.missionScopeDropdown.Location = new System.Drawing.Point(491, 43);
            this.missionScopeDropdown.Name = "missionScopeDropdown";
            this.missionScopeDropdown.Size = new System.Drawing.Size(121, 21);
            this.missionScopeDropdown.TabIndex = 14;
            this.missionScopeDropdown.SelectedIndexChanged += new System.EventHandler(this.missionScopeDropdown_SelectedIndexChanged);
            // 
            // missionScopeLabel
            // 
            this.missionScopeLabel.AutoSize = true;
            this.missionScopeLabel.Location = new System.Drawing.Point(402, 46);
            this.missionScopeLabel.Name = "missionScopeLabel";
            this.missionScopeLabel.Size = new System.Drawing.Size(79, 13);
            this.missionScopeLabel.TabIndex = 15;
            this.missionScopeLabel.Text = "Mission Scope:";
            // 
            // missionTypeDropdown
            // 
            this.missionTypeDropdown.FormattingEnabled = true;
            this.missionTypeDropdown.Items.AddRange(new object[] {
            "Diplomatic",
            "military",
            "Intelligence",
            "Sabotage",
            "Economic",
            "Population"});
            this.missionTypeDropdown.Location = new System.Drawing.Point(491, 70);
            this.missionTypeDropdown.Name = "missionTypeDropdown";
            this.missionTypeDropdown.Size = new System.Drawing.Size(120, 21);
            this.missionTypeDropdown.TabIndex = 16;
            this.missionTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.missionTypeDropdown_SelectedIndexChanged);
            // 
            // missionTypeLabel
            // 
            this.missionTypeLabel.AutoSize = true;
            this.missionTypeLabel.Location = new System.Drawing.Point(409, 73);
            this.missionTypeLabel.Name = "missionTypeLabel";
            this.missionTypeLabel.Size = new System.Drawing.Size(72, 13);
            this.missionTypeLabel.TabIndex = 17;
            this.missionTypeLabel.Text = "Mission Type:";
            // 
            // missionListDropdown
            // 
            this.missionListDropdown.FormattingEnabled = true;
            this.missionListDropdown.Location = new System.Drawing.Point(491, 97);
            this.missionListDropdown.Name = "missionListDropdown";
            this.missionListDropdown.Size = new System.Drawing.Size(120, 21);
            this.missionListDropdown.TabIndex = 18;
            // 
            // missionListLabel
            // 
            this.missionListLabel.AutoSize = true;
            this.missionListLabel.Location = new System.Drawing.Point(436, 100);
            this.missionListLabel.Name = "missionListLabel";
            this.missionListLabel.Size = new System.Drawing.Size(45, 13);
            this.missionListLabel.TabIndex = 19;
            this.missionListLabel.Text = "Mission:";
            // 
            // activeMissionsTable
            // 
            this.activeMissionsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.activeMissionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeMissionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.typeColumn,
            this.targetColumn,
            this.scopeColumn});
            this.activeMissionsTable.Location = new System.Drawing.Point(12, 294);
            this.activeMissionsTable.Name = "activeMissionsTable";
            this.activeMissionsTable.Size = new System.Drawing.Size(444, 136);
            this.activeMissionsTable.TabIndex = 20;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            // 
            // targetColumn
            // 
            this.targetColumn.HeaderText = "Target";
            this.targetColumn.Name = "targetColumn";
            // 
            // scopeColumn
            // 
            this.scopeColumn.HeaderText = "Scope";
            this.scopeColumn.Name = "scopeColumn";
            // 
            // activeMissionsLabel
            // 
            this.activeMissionsLabel.AutoSize = true;
            this.activeMissionsLabel.Location = new System.Drawing.Point(12, 270);
            this.activeMissionsLabel.Name = "activeMissionsLabel";
            this.activeMissionsLabel.Size = new System.Drawing.Size(83, 13);
            this.activeMissionsLabel.TabIndex = 21;
            this.activeMissionsLabel.Text = "Active Missions:";
            // 
            // createMissionButton
            // 
            this.createMissionButton.Location = new System.Drawing.Point(491, 127);
            this.createMissionButton.Name = "createMissionButton";
            this.createMissionButton.Size = new System.Drawing.Size(119, 23);
            this.createMissionButton.TabIndex = 22;
            this.createMissionButton.Text = "Create Mission";
            this.createMissionButton.UseVisualStyleBackColor = true;
            this.createMissionButton.Click += new System.EventHandler(this.createMissionButton_Click);
            // 
            // MissionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.createMissionButton);
            this.Controls.Add(this.activeMissionsLabel);
            this.Controls.Add(this.activeMissionsTable);
            this.Controls.Add(this.missionListLabel);
            this.Controls.Add(this.missionListDropdown);
            this.Controls.Add(this.missionTypeLabel);
            this.Controls.Add(this.missionTypeDropdown);
            this.Controls.Add(this.missionScopeLabel);
            this.Controls.Add(this.missionScopeDropdown);
            this.Name = "MissionsScreen";
            this.Text = "MissionScreen";
            ((System.ComponentModel.ISupportInitialize)(this.activeMissionsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox missionScopeDropdown;
        private System.Windows.Forms.Label missionScopeLabel;
        private System.Windows.Forms.ComboBox missionTypeDropdown;
        private System.Windows.Forms.Label missionTypeLabel;
        private System.Windows.Forms.ComboBox missionListDropdown;
        private System.Windows.Forms.Label missionListLabel;
        private System.Windows.Forms.DataGridView activeMissionsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scopeColumn;
        private System.Windows.Forms.Label activeMissionsLabel;
        private System.Windows.Forms.Button createMissionButton;
    }
}