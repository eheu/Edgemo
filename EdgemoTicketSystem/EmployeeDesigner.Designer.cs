namespace EdgemoTicketSystem
{
    partial class EmployeeDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDesigner));
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.labelTeam = new System.Windows.Forms.Label();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelFirstName.Location = new System.Drawing.Point(12, 12);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(77, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelLastName.Location = new System.Drawing.Point(12, 42);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 20);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstName.Location = new System.Drawing.Point(95, 12);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(170, 22);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastName.Location = new System.Drawing.Point(94, 40);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(171, 22);
            this.textBoxLastName.TabIndex = 3;
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(95, 68);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(171, 24);
            this.comboBoxTeam.TabIndex = 4;
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTeam.Location = new System.Drawing.Point(12, 68);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(45, 20);
            this.labelTeam.TabIndex = 5;
            this.labelTeam.Text = "Team";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddEmployee.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_plus_24;
            this.buttonAddEmployee.Location = new System.Drawing.Point(16, 98);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(75, 32);
            this.buttonAddEmployee.TabIndex = 6;
            this.buttonAddEmployee.Text = "Add";
            this.buttonAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEditEmployee.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_pencil_24;
            this.buttonEditEmployee.Location = new System.Drawing.Point(16, 98);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(75, 32);
            this.buttonEditEmployee.TabIndex = 7;
            this.buttonEditEmployee.Text = "Edit";
            this.buttonEditEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // EmployeeDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 138);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2000, 185);
            this.MinimumSize = new System.Drawing.Size(290, 185);
            this.Name = "EmployeeDesigner";
            this.Load += new System.EventHandler(this.EmployeeDesigner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonEditEmployee;
    }
}