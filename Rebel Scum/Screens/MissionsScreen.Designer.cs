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
            this.missionNameDropdown = new System.Windows.Forms.ComboBox();
            this.missionNameLabel = new System.Windows.Forms.Label();
            this.activeMissionsTable = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scopeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeMissionsLabel = new System.Windows.Forms.Label();
            this.createMissionButton = new System.Windows.Forms.Button();
            this.btnDeleteMission = new System.Windows.Forms.Button();
            this.targetSystemDropdown = new System.Windows.Forms.ComboBox();
            this.targetPlanetDropdown = new System.Windows.Forms.ComboBox();
            this.targetSystemLabel = new System.Windows.Forms.Label();
            this.targetPlanetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activeMissionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // missionScopeDropdown
            // 
            this.missionScopeDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.missionScopeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.missionScopeDropdown.DropDownWidth = 120;
            this.missionScopeDropdown.FormattingEnabled = true;
            this.missionScopeDropdown.Items.AddRange(new object[] {
            "Galaxy",
            "System",
            "Planet"});
            this.missionScopeDropdown.Location = new System.Drawing.Point(385, 43);
            this.missionScopeDropdown.Name = "missionScopeDropdown";
            this.missionScopeDropdown.Size = new System.Drawing.Size(196, 21);
            this.missionScopeDropdown.TabIndex = 14;
            this.missionScopeDropdown.SelectedIndexChanged += new System.EventHandler(this.missionScopeDropdown_SelectedIndexChanged);
            // 
            // missionScopeLabel
            // 
            this.missionScopeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.missionScopeLabel.AutoSize = true;
            this.missionScopeLabel.Location = new System.Drawing.Point(300, 46);
            this.missionScopeLabel.Name = "missionScopeLabel";
            this.missionScopeLabel.Size = new System.Drawing.Size(79, 13);
            this.missionScopeLabel.TabIndex = 15;
            this.missionScopeLabel.Text = "Mission Scope:";
            // 
            // missionTypeDropdown
            // 
            this.missionTypeDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.missionTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.missionTypeDropdown.FormattingEnabled = true;
            this.missionTypeDropdown.Items.AddRange(new object[] {
            "Diplomatic",
            "Military",
            "Intelligence",
            "Sabotage",
            "Economic",
            "Population"});
            this.missionTypeDropdown.Location = new System.Drawing.Point(385, 70);
            this.missionTypeDropdown.Name = "missionTypeDropdown";
            this.missionTypeDropdown.Size = new System.Drawing.Size(195, 21);
            this.missionTypeDropdown.TabIndex = 16;
            this.missionTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.missionTypeDropdown_SelectedIndexChanged);
            // 
            // missionTypeLabel
            // 
            this.missionTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.missionTypeLabel.AutoSize = true;
            this.missionTypeLabel.Location = new System.Drawing.Point(307, 73);
            this.missionTypeLabel.Name = "missionTypeLabel";
            this.missionTypeLabel.Size = new System.Drawing.Size(72, 13);
            this.missionTypeLabel.TabIndex = 17;
            this.missionTypeLabel.Text = "Mission Type:";
            // 
            // missionNameDropdown
            // 
            this.missionNameDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.missionNameDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.missionNameDropdown.FormattingEnabled = true;
            this.missionNameDropdown.Location = new System.Drawing.Point(385, 97);
            this.missionNameDropdown.Name = "missionNameDropdown";
            this.missionNameDropdown.Size = new System.Drawing.Size(195, 21);
            this.missionNameDropdown.TabIndex = 18;
            this.missionNameDropdown.SelectedIndexChanged += new System.EventHandler(this.missionListDropdown_SelectedIndexChanged);
            // 
            // missionNameLabel
            // 
            this.missionNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.missionNameLabel.AutoSize = true;
            this.missionNameLabel.Location = new System.Drawing.Point(334, 100);
            this.missionNameLabel.Name = "missionNameLabel";
            this.missionNameLabel.Size = new System.Drawing.Size(45, 13);
            this.missionNameLabel.TabIndex = 19;
            this.missionNameLabel.Text = "Mission:";
            // 
            // activeMissionsTable
            // 
            this.activeMissionsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeMissionsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.activeMissionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeMissionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.typeColumn,
            this.targetColumn,
            this.scopeColumn});
            this.activeMissionsTable.Location = new System.Drawing.Point(12, 294);
            this.activeMissionsTable.Name = "activeMissionsTable";
            this.activeMissionsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activeMissionsTable.Size = new System.Drawing.Size(569, 135);
            this.activeMissionsTable.TabIndex = 20;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // typeColumn
            // 
            this.typeColumn.DataPropertyName = "MissionType";
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            // 
            // targetColumn
            // 
            this.targetColumn.DataPropertyName = "TargetPlanet";
            this.targetColumn.HeaderText = "Target";
            this.targetColumn.Name = "targetColumn";
            // 
            // scopeColumn
            // 
            this.scopeColumn.DataPropertyName = "MissionScope";
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
            this.createMissionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createMissionButton.Location = new System.Drawing.Point(462, 224);
            this.createMissionButton.Name = "createMissionButton";
            this.createMissionButton.Size = new System.Drawing.Size(119, 23);
            this.createMissionButton.TabIndex = 22;
            this.createMissionButton.Text = "Create Mission";
            this.createMissionButton.UseVisualStyleBackColor = true;
            this.createMissionButton.Click += new System.EventHandler(this.createMissionButton_Click);
            // 
            // btnDeleteMission
            // 
            this.btnDeleteMission.Location = new System.Drawing.Point(92, 143);
            this.btnDeleteMission.Name = "btnDeleteMission";
            this.btnDeleteMission.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMission.TabIndex = 23;
            this.btnDeleteMission.Text = "delete mis";
            this.btnDeleteMission.UseVisualStyleBackColor = true;
            this.btnDeleteMission.Click += new System.EventHandler(this.btnDeleteMission_Click);
            // 
            // targetSystemDropdown
            // 
            this.targetSystemDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.targetSystemDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetSystemDropdown.FormattingEnabled = true;
            this.targetSystemDropdown.Location = new System.Drawing.Point(385, 124);
            this.targetSystemDropdown.Name = "targetSystemDropdown";
            this.targetSystemDropdown.Size = new System.Drawing.Size(195, 21);
            this.targetSystemDropdown.TabIndex = 24;
            this.targetSystemDropdown.SelectedIndexChanged += new System.EventHandler(this.targetSystemDropdown_SelectedIndexChanged);
            // 
            // targetPlanetDropdown
            // 
            this.targetPlanetDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPlanetDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetPlanetDropdown.FormattingEnabled = true;
            this.targetPlanetDropdown.Location = new System.Drawing.Point(385, 151);
            this.targetPlanetDropdown.Name = "targetPlanetDropdown";
            this.targetPlanetDropdown.Size = new System.Drawing.Size(195, 21);
            this.targetPlanetDropdown.TabIndex = 25;
            // 
            // targetSystemLabel
            // 
            this.targetSystemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.targetSystemLabel.AutoSize = true;
            this.targetSystemLabel.Location = new System.Drawing.Point(301, 127);
            this.targetSystemLabel.Name = "targetSystemLabel";
            this.targetSystemLabel.Size = new System.Drawing.Size(78, 13);
            this.targetSystemLabel.TabIndex = 26;
            this.targetSystemLabel.Text = "Target System:";
            // 
            // targetPlanetLabel
            // 
            this.targetPlanetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPlanetLabel.AutoSize = true;
            this.targetPlanetLabel.Location = new System.Drawing.Point(305, 154);
            this.targetPlanetLabel.Name = "targetPlanetLabel";
            this.targetPlanetLabel.Size = new System.Drawing.Size(74, 13);
            this.targetPlanetLabel.TabIndex = 27;
            this.targetPlanetLabel.Text = "Target Planet:";
            this.targetPlanetLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // MissionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 440);
            this.Controls.Add(this.targetPlanetLabel);
            this.Controls.Add(this.targetSystemLabel);
            this.Controls.Add(this.targetPlanetDropdown);
            this.Controls.Add(this.targetSystemDropdown);
            this.Controls.Add(this.btnDeleteMission);
            this.Controls.Add(this.createMissionButton);
            this.Controls.Add(this.activeMissionsLabel);
            this.Controls.Add(this.activeMissionsTable);
            this.Controls.Add(this.missionNameLabel);
            this.Controls.Add(this.missionNameDropdown);
            this.Controls.Add(this.missionTypeLabel);
            this.Controls.Add(this.missionTypeDropdown);
            this.Controls.Add(this.missionScopeLabel);
            this.Controls.Add(this.missionScopeDropdown);
            this.Name = "MissionsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MissionScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MissionsScreen_FormClosing);
            this.Load += new System.EventHandler(this.MissionsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activeMissionsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox missionScopeDropdown;
        private System.Windows.Forms.Label missionScopeLabel;
        private System.Windows.Forms.ComboBox missionTypeDropdown;
        private System.Windows.Forms.Label missionTypeLabel;
        private System.Windows.Forms.ComboBox missionNameDropdown;
        private System.Windows.Forms.Label missionNameLabel;
        private System.Windows.Forms.DataGridView activeMissionsTable;
        private System.Windows.Forms.Label activeMissionsLabel;
        private System.Windows.Forms.Button createMissionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scopeColumn;
        private System.Windows.Forms.Button btnDeleteMission;
        private System.Windows.Forms.ComboBox targetSystemDropdown;
        private System.Windows.Forms.ComboBox targetPlanetDropdown;
        private System.Windows.Forms.Label targetSystemLabel;
        private System.Windows.Forms.Label targetPlanetLabel;
    }
}