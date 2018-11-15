namespace EdgemoTicketSystem
{
    partial class TeamSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamSettings));
            this.comboBoxBeforeTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxAfterTeam = new System.Windows.Forms.ComboBox();
            this.objectListViewEmployee = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnEmployeeName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.labelTo = new System.Windows.Forms.Label();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.buttonEditTeam = new System.Windows.Forms.Button();
            this.buttonDeleteTeam = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonMakeManager = new System.Windows.Forms.Button();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonMoveEmployee = new System.Windows.Forms.Button();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.labelCurrentTeamManager = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBeforeTeam
            // 
            this.comboBoxBeforeTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxBeforeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBeforeTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxBeforeTeam.FormattingEnabled = true;
            this.comboBoxBeforeTeam.Location = new System.Drawing.Point(12, 214);
            this.comboBoxBeforeTeam.Name = "comboBoxBeforeTeam";
            this.comboBoxBeforeTeam.Size = new System.Drawing.Size(132, 28);
            this.comboBoxBeforeTeam.TabIndex = 4;
            this.comboBoxBeforeTeam.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBeforeTeam_SelectionChangeCommitted);
            // 
            // comboBoxAfterTeam
            // 
            this.comboBoxAfterTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxAfterTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAfterTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxAfterTeam.FormattingEnabled = true;
            this.comboBoxAfterTeam.Location = new System.Drawing.Point(179, 213);
            this.comboBoxAfterTeam.Name = "comboBoxAfterTeam";
            this.comboBoxAfterTeam.Size = new System.Drawing.Size(132, 28);
            this.comboBoxAfterTeam.TabIndex = 5;
            // 
            // objectListViewEmployee
            // 
            this.objectListViewEmployee.AllColumns.Add(this.olvColumnEmployeeName);
            this.objectListViewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.objectListViewEmployee.CellEditUseWholeCell = false;
            this.objectListViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnEmployeeName});
            this.objectListViewEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectListViewEmployee.FullRowSelect = true;
            this.objectListViewEmployee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.objectListViewEmployee.Location = new System.Drawing.Point(12, 88);
            this.objectListViewEmployee.Name = "objectListViewEmployee";
            this.objectListViewEmployee.ShowGroups = false;
            this.objectListViewEmployee.Size = new System.Drawing.Size(482, 79);
            this.objectListViewEmployee.TabIndex = 4;
            this.objectListViewEmployee.UseCompatibleStateImageBehavior = false;
            this.objectListViewEmployee.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnEmployeeName
            // 
            this.olvColumnEmployeeName.AspectName = "fullName";
            this.olvColumnEmployeeName.FillsFreeSpace = true;
            this.olvColumnEmployeeName.Text = "Employee";
            this.olvColumnEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTo
            // 
            this.labelTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTo.Location = new System.Drawing.Point(150, 217);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(23, 20);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "to";
            this.labelTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEditEmployee.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_registration_24;
            this.buttonEditEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditEmployee.Location = new System.Drawing.Point(158, 50);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(153, 32);
            this.buttonEditEmployee.TabIndex = 9;
            this.buttonEditEmployee.Text = "Edit employee(s)";
            this.buttonEditEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // buttonEditTeam
            // 
            this.buttonEditTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEditTeam.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_modified_edit_user_group_man_man_24;
            this.buttonEditTeam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditTeam.Location = new System.Drawing.Point(158, 12);
            this.buttonEditTeam.Name = "buttonEditTeam";
            this.buttonEditTeam.Size = new System.Drawing.Size(153, 32);
            this.buttonEditTeam.TabIndex = 8;
            this.buttonEditTeam.Text = "Edit team";
            this.buttonEditTeam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditTeam.UseVisualStyleBackColor = true;
            this.buttonEditTeam.Click += new System.EventHandler(this.buttonEditTeam_Click);
            // 
            // buttonDeleteTeam
            // 
            this.buttonDeleteTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDeleteTeam.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_remove_user_group_man_man_24;
            this.buttonDeleteTeam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteTeam.Location = new System.Drawing.Point(317, 12);
            this.buttonDeleteTeam.Name = "buttonDeleteTeam";
            this.buttonDeleteTeam.Size = new System.Drawing.Size(177, 32);
            this.buttonDeleteTeam.TabIndex = 1;
            this.buttonDeleteTeam.Text = "Delete team";
            this.buttonDeleteTeam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteTeam.UseVisualStyleBackColor = true;
            this.buttonDeleteTeam.Click += new System.EventHandler(this.buttonDeleteTeam_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDeleteEmployee.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_delete_user_male_24;
            this.buttonDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(317, 50);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(177, 32);
            this.buttonDeleteEmployee.TabIndex = 3;
            this.buttonDeleteEmployee.Text = "Delete employee(s)";
            this.buttonDeleteEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddEmployee.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_add_user_male_24;
            this.buttonAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddEmployee.Location = new System.Drawing.Point(12, 50);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(140, 32);
            this.buttonAddEmployee.TabIndex = 2;
            this.buttonAddEmployee.Text = "Add employee";
            this.buttonAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonMakeManager
            // 
            this.buttonMakeManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMakeManager.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMakeManager.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_moderator_24;
            this.buttonMakeManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMakeManager.Location = new System.Drawing.Point(319, 173);
            this.buttonMakeManager.Name = "buttonMakeManager";
            this.buttonMakeManager.Size = new System.Drawing.Size(175, 32);
            this.buttonMakeManager.TabIndex = 7;
            this.buttonMakeManager.Text = "Make manager";
            this.buttonMakeManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMakeManager.UseVisualStyleBackColor = true;
            this.buttonMakeManager.Click += new System.EventHandler(this.buttonMakeManager_Click);
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddTeam.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_add_user_group_man_man_24;
            this.buttonAddTeam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddTeam.Location = new System.Drawing.Point(12, 12);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(140, 32);
            this.buttonAddTeam.TabIndex = 0;
            this.buttonAddTeam.Text = "Add team";
            this.buttonAddTeam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonMoveEmployee
            // 
            this.buttonMoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMoveEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMoveEmployee.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_right_2_24;
            this.buttonMoveEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMoveEmployee.Location = new System.Drawing.Point(319, 211);
            this.buttonMoveEmployee.Name = "buttonMoveEmployee";
            this.buttonMoveEmployee.Size = new System.Drawing.Size(175, 32);
            this.buttonMoveEmployee.TabIndex = 6;
            this.buttonMoveEmployee.Text = "Move employee(s)";
            this.buttonMoveEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMoveEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMoveEmployee.UseVisualStyleBackColor = true;
            this.buttonMoveEmployee.Click += new System.EventHandler(this.buttonMoveEmployee_Click);
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(158, 179);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEmployees.TabIndex = 10;
            this.comboBoxEmployees.Visible = false;
            // 
            // labelCurrentTeamManager
            // 
            this.labelCurrentTeamManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCurrentTeamManager.AutoSize = true;
            this.labelCurrentTeamManager.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentTeamManager.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCurrentTeamManager.Location = new System.Drawing.Point(8, 179);
            this.labelCurrentTeamManager.Name = "labelCurrentTeamManager";
            this.labelCurrentTeamManager.Size = new System.Drawing.Size(377, 20);
            this.labelCurrentTeamManager.TabIndex = 11;
            this.labelCurrentTeamManager.Text = "The manager of team [team] is: [firstName] [lastName] ";
            // 
            // TeamSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 253);
            this.Controls.Add(this.labelCurrentTeamManager);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonEditTeam);
            this.Controls.Add(this.buttonDeleteTeam);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonMakeManager);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.objectListViewEmployee);
            this.Controls.Add(this.comboBoxAfterTeam);
            this.Controls.Add(this.buttonMoveEmployee);
            this.Controls.Add(this.comboBoxBeforeTeam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(520, 2000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 300);
            this.Name = "TeamSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.TeamSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBeforeTeam;
        private System.Windows.Forms.Button buttonMoveEmployee;
        private System.Windows.Forms.ComboBox comboBoxAfterTeam;
        private BrightIdeasSoftware.ObjectListView objectListViewEmployee;
        private BrightIdeasSoftware.OLVColumn olvColumnEmployeeName;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonMakeManager;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonDeleteTeam;
        private System.Windows.Forms.Button buttonEditTeam;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.Label labelCurrentTeamManager;
    }
}