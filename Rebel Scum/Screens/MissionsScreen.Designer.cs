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
            this.MissionTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScopeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetSystemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeMissionsLabel = new System.Windows.Forms.Label();
            this.btnCreateMission = new System.Windows.Forms.Button();
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
            this.missionScopeDropdown.Location = new System.Drawing.Point(588, 43);
            this.missionScopeDropdown.Name = "missionScopeDropdown";
            this.missionScopeDropdown.Size = new System.Drawing.Size(196, 21);
            this.missionScopeDropdown.TabIndex = 14;
            this.missionScopeDropdown.SelectedIndexChanged += new System.EventHandler(this.missionScopeDropdown_SelectedIndexChanged);
            // 
            // missionScopeLabel
            // 
            this.missionScopeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.missionScopeLabel.AutoSize = true;
            this.missionScopeLabel.Location = new System.Drawing.Point(503, 46);
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
            this.missionTypeDropdown.Location = new System.Drawing.Point(588, 70);
            this.missionTypeDropdown.Name = "missionTypeDropdown";
            this.missionTypeDropdown.Size = new System.Drawing.Size(195, 21);
            this.missionTypeDropdown.TabIndex = 16;
            this.missionTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.missionTypeDropdown_SelectedIndexChanged);
            // 
            // missionTypeLabel
            // 
            this.missionTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.missionTypeLabel.AutoSize = true;
            this.missionTypeLabel.Location = new System.Drawing.Point(510, 73);
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
            this.missionNameDropdown.Location = new System.Drawing.Point(588, 97);
            this.missionNameDropdown.Name = "missionNameDropdown";
            this.missionNameDropdown.Size = new System.Drawing.Size(195, 21);
            this.missionNameDropdown.TabIndex = 18;
            this.missionNameDropdown.SelectedIndexChanged += new System.EventHandler(this.missionListDropdown_SelectedIndexChanged);
            // 
            // missionNameLabel
            // 
            this.missionNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.missionNameLabel.AutoSize = true;
            this.missionNameLabel.Location = new System.Drawing.Point(537, 100);
            this.missionNameLabel.Name = "missionNameLabel";
            this.missionNameLabel.Size = new System.Drawing.Size(45, 13);
            this.missionNameLabel.TabIndex = 19;
            this.missionNameLabel.Text = "Mission:";
            // 
            // activeMissionsTable
            // 
            this.activeMissionsTable.AllowUserToAddRows = false;
            this.activeMissionsTable.AllowUserToDeleteRows = false;
            this.activeMissionsTable.AllowUserToResizeColumns = false;
            this.activeMissionsTable.AllowUserToResizeRows = false;
            this.activeMissionsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeMissionsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.activeMissionsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.activeMissionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeMissionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MissionTypeColumn,
            this.ScopeColumn,
            this.TargetSystemColumn,
            this.NameColumn});
            this.activeMissionsTable.Location = new System.Drawing.Point(12, 294);
            this.activeMissionsTable.Name = "activeMissionsTable";
            this.activeMissionsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activeMissionsTable.Size = new System.Drawing.Size(772, 135);
            this.activeMissionsTable.TabIndex = 20;
            // 
            // MissionTypeColumn
            // 
            this.MissionTypeColumn.DataPropertyName = "Type";
            this.MissionTypeColumn.HeaderText = "Type";
            this.MissionTypeColumn.Name = "MissionTypeColumn";
            this.MissionTypeColumn.ReadOnly = true;
            this.MissionTypeColumn.Width = 56;
            // 
            // ScopeColumn
            // 
            this.ScopeColumn.DataPropertyName = "Scope";
            this.ScopeColumn.HeaderText = "Scope";
            this.ScopeColumn.Name = "ScopeColumn";
            this.ScopeColumn.ReadOnly = true;
            this.ScopeColumn.Width = 63;
            // 
            // TargetSystemColumn
            // 
            this.TargetSystemColumn.DataPropertyName = "summarizedTarget";
            this.TargetSystemColumn.HeaderText = "Target";
            this.TargetSystemColumn.Name = "TargetSystemColumn";
            this.TargetSystemColumn.ReadOnly = true;
            this.TargetSystemColumn.Width = 63;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
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
            // btnCreateMission
            // 
            this.btnCreateMission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateMission.Location = new System.Drawing.Point(588, 178);
            this.btnCreateMission.Name = "btnCreateMission";
            this.btnCreateMission.Size = new System.Drawing.Size(119, 23);
            this.btnCreateMission.TabIndex = 22;
            this.btnCreateMission.Text = "Create Mission";
            this.btnCreateMission.UseVisualStyleBackColor = true;
            this.btnCreateMission.Click += new System.EventHandler(this.createMissionButton_Click);
            // 
            // btnDeleteMission
            // 
            this.btnDeleteMission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMission.Location = new System.Drawing.Point(588, 207);
            this.btnDeleteMission.Name = "btnDeleteMission";
            this.btnDeleteMission.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteMission.TabIndex = 23;
            this.btnDeleteMission.Text = "Delete Mission";
            this.btnDeleteMission.UseVisualStyleBackColor = true;
            this.btnDeleteMission.Click += new System.EventHandler(this.btnDeleteMission_Click);
            // 
            // targetSystemDropdown
            // 
            this.targetSystemDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.targetSystemDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetSystemDropdown.FormattingEnabled = true;
            this.targetSystemDropdown.Location = new System.Drawing.Point(588, 124);
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
            this.targetPlanetDropdown.Location = new System.Drawing.Point(588, 151);
            this.targetPlanetDropdown.Name = "targetPlanetDropdown";
            this.targetPlanetDropdown.Size = new System.Drawing.Size(195, 21);
            this.targetPlanetDropdown.TabIndex = 25;
            // 
            // targetSystemLabel
            // 
            this.targetSystemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.targetSystemLabel.AutoSize = true;
            this.targetSystemLabel.Location = new System.Drawing.Point(504, 127);
            this.targetSystemLabel.Name = "targetSystemLabel";
            this.targetSystemLabel.Size = new System.Drawing.Size(78, 13);
            this.targetSystemLabel.TabIndex = 26;
            this.targetSystemLabel.Text = "Target System:";
            // 
            // targetPlanetLabel
            // 
            this.targetPlanetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPlanetLabel.AutoSize = true;
            this.targetPlanetLabel.Location = new System.Drawing.Point(508, 154);
            this.targetPlanetLabel.Name = "targetPlanetLabel";
            this.targetPlanetLabel.Size = new System.Drawing.Size(74, 13);
            this.targetPlanetLabel.TabIndex = 27;
            this.targetPlanetLabel.Text = "Target Planet:";
            // 
            // MissionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 440);
            this.Controls.Add(this.targetPlanetLabel);
            this.Controls.Add(this.targetSystemLabel);
            this.Controls.Add(this.targetPlanetDropdown);
            this.Controls.Add(this.targetSystemDropdown);
            this.Controls.Add(this.btnDeleteMission);
            this.Controls.Add(this.btnCreateMission);
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
        private System.Windows.Forms.Button btnCreateMission;
        private System.Windows.Forms.Button btnDeleteMission;
        private System.Windows.Forms.ComboBox targetSystemDropdown;
        private System.Windows.Forms.ComboBox targetPlanetDropdown;
        private System.Windows.Forms.Label targetSystemLabel;
        private System.Windows.Forms.Label targetPlanetLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MissionTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScopeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetSystemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
    }
}