namespace EdgemoTicketSystem
{
    partial class TeamDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamDesigner));
            this.labelTeamName = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.comboBoxTeamManager = new System.Windows.Forms.ComboBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.buttonEditTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTeamName.Location = new System.Drawing.Point(12, 9);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(86, 20);
            this.labelTeamName.TabIndex = 0;
            this.labelTeamName.Text = "Team name";
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTeamName.Location = new System.Drawing.Point(105, 9);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(121, 22);
            this.textBoxTeamName.TabIndex = 1;
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddTeam.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_plus_24;
            this.buttonAddTeam.Location = new System.Drawing.Point(16, 68);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(70, 32);
            this.buttonAddTeam.TabIndex = 2;
            this.buttonAddTeam.Text = "Add";
            this.buttonAddTeam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // comboBoxTeamManager
            // 
            this.comboBoxTeamManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTeamManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeamManager.FormattingEnabled = true;
            this.comboBoxTeamManager.Location = new System.Drawing.Point(105, 38);
            this.comboBoxTeamManager.Name = "comboBoxTeamManager";
            this.comboBoxTeamManager.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTeamManager.TabIndex = 3;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelManager.Location = new System.Drawing.Point(12, 38);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(68, 20);
            this.labelManager.TabIndex = 4;
            this.labelManager.Text = "Manager";
            // 
            // buttonEditTeam
            // 
            this.buttonEditTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEditTeam.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_pencil_24;
            this.buttonEditTeam.Location = new System.Drawing.Point(16, 68);
            this.buttonEditTeam.Name = "buttonEditTeam";
            this.buttonEditTeam.Size = new System.Drawing.Size(70, 32);
            this.buttonEditTeam.TabIndex = 5;
            this.buttonEditTeam.Text = "Edit";
            this.buttonEditTeam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditTeam.UseVisualStyleBackColor = true;
            this.buttonEditTeam.Click += new System.EventHandler(this.buttonEditTeam_Click);
            // 
            // TeamDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 103);
            this.Controls.Add(this.buttonEditTeam);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.comboBoxTeamManager);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.labelTeamName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 150);
            this.MinimumSize = new System.Drawing.Size(258, 150);
            this.Name = "TeamDesigner";
            this.Load += new System.EventHandler(this.TeamDesigner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.ComboBox comboBoxTeamManager;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Button buttonEditTeam;
    }
}