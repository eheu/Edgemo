namespace EdgemoTicketSystem
{
    partial class TicketDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketDesigner));
            this.labelTicketSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.buttonCreateTicket = new System.Windows.Forms.Button();
            this.labelticketStatus = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.buttonEditTicket = new System.Windows.Forms.Button();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDatePortion = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTimePortion = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartTimePortion = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDatePortion = new System.Windows.Forms.DateTimePicker();
            this.buttonViewLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTicketSubject
            // 
            this.labelTicketSubject.AutoSize = true;
            this.labelTicketSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelTicketSubject.Location = new System.Drawing.Point(10, 13);
            this.labelTicketSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTicketSubject.Name = "labelTicketSubject";
            this.labelTicketSubject.Size = new System.Drawing.Size(57, 18);
            this.labelTicketSubject.TabIndex = 0;
            this.labelTicketSubject.Text = "Subject";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.AcceptsTab = true;
            this.textBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubject.Location = new System.Drawing.Point(104, 13);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(200, 22);
            this.textBoxSubject.TabIndex = 1;
            this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
            // 
            // buttonCreateTicket
            // 
            this.buttonCreateTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCreateTicket.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_plus_24;
            this.buttonCreateTicket.Location = new System.Drawing.Point(13, 360);
            this.buttonCreateTicket.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateTicket.Name = "buttonCreateTicket";
            this.buttonCreateTicket.Size = new System.Drawing.Size(100, 32);
            this.buttonCreateTicket.TabIndex = 11;
            this.buttonCreateTicket.Text = "Create";
            this.buttonCreateTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCreateTicket.UseVisualStyleBackColor = true;
            this.buttonCreateTicket.Click += new System.EventHandler(this.buttonCreateTicket_Click);
            // 
            // labelticketStatus
            // 
            this.labelticketStatus.AutoSize = true;
            this.labelticketStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelticketStatus.Location = new System.Drawing.Point(9, 233);
            this.labelticketStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelticketStatus.Name = "labelticketStatus";
            this.labelticketStatus.Size = new System.Drawing.Size(49, 20);
            this.labelticketStatus.TabIndex = 0;
            this.labelticketStatus.Text = "Status";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelStartDate.Location = new System.Drawing.Point(9, 173);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(74, 20);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "Start date";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(104, 43);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(200, 122);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDescription.Location = new System.Drawing.Point(9, 43);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(85, 20);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Description";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(104, 233);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 24);
            this.comboBoxStatus.TabIndex = 7;
            this.comboBoxStatus.SelectionChangeCommitted += new System.EventHandler(this.comboBoxStatus_SelectionChangeCommitted);
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(104, 265);
            this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(200, 24);
            this.comboBoxPriority.TabIndex = 8;
            this.comboBoxPriority.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPriority_SelectionChangeCommitted);
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPriority.Location = new System.Drawing.Point(9, 265);
            this.labelPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(56, 20);
            this.labelPriority.TabIndex = 0;
            this.labelPriority.Text = "Priority";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(104, 329);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(200, 24);
            this.comboBoxEmployee.TabIndex = 10;
            this.comboBoxEmployee.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEmployee_SelectionChangeCommitted);
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(104, 297);
            this.comboBoxTeam.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTeam.TabIndex = 9;
            this.comboBoxTeam.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTeam_SelectionChangeCommitted);
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTeam.Location = new System.Drawing.Point(9, 297);
            this.labelTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(45, 20);
            this.labelTeam.TabIndex = 0;
            this.labelTeam.Text = "Team";
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelEmployee.Location = new System.Drawing.Point(9, 329);
            this.labelEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(75, 20);
            this.labelEmployee.TabIndex = 0;
            this.labelEmployee.Text = "Employee";
            // 
            // buttonEditTicket
            // 
            this.buttonEditTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEditTicket.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_pencil_24;
            this.buttonEditTicket.Location = new System.Drawing.Point(13, 360);
            this.buttonEditTicket.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditTicket.Name = "buttonEditTicket";
            this.buttonEditTicket.Size = new System.Drawing.Size(100, 32);
            this.buttonEditTicket.TabIndex = 11;
            this.buttonEditTicket.Text = "Edit";
            this.buttonEditTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditTicket.UseVisualStyleBackColor = true;
            this.buttonEditTicket.Click += new System.EventHandler(this.buttonEditTicket_Click);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelEndDate.Location = new System.Drawing.Point(9, 203);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(68, 20);
            this.labelEndDate.TabIndex = 0;
            this.labelEndDate.Text = "End date";
            // 
            // dateTimePickerEndDatePortion
            // 
            this.dateTimePickerEndDatePortion.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEndDatePortion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDatePortion.Location = new System.Drawing.Point(104, 203);
            this.dateTimePickerEndDatePortion.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEndDatePortion.Name = "dateTimePickerEndDatePortion";
            this.dateTimePickerEndDatePortion.Size = new System.Drawing.Size(100, 22);
            this.dateTimePickerEndDatePortion.TabIndex = 5;
            this.dateTimePickerEndDatePortion.ValueChanged += new System.EventHandler(this.dateTimePickerEndDatePortion_ValueChanged);
            // 
            // dateTimePickerEndTimePortion
            // 
            this.dateTimePickerEndTimePortion.CustomFormat = "HH:mm";
            this.dateTimePickerEndTimePortion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndTimePortion.Location = new System.Drawing.Point(204, 203);
            this.dateTimePickerEndTimePortion.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEndTimePortion.Name = "dateTimePickerEndTimePortion";
            this.dateTimePickerEndTimePortion.ShowUpDown = true;
            this.dateTimePickerEndTimePortion.Size = new System.Drawing.Size(100, 22);
            this.dateTimePickerEndTimePortion.TabIndex = 6;
            this.dateTimePickerEndTimePortion.ValueChanged += new System.EventHandler(this.dateTimePickerEndTimePortion_ValueChanged);
            // 
            // dateTimePickerStartTimePortion
            // 
            this.dateTimePickerStartTimePortion.CustomFormat = "HH:mm";
            this.dateTimePickerStartTimePortion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartTimePortion.Location = new System.Drawing.Point(204, 173);
            this.dateTimePickerStartTimePortion.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStartTimePortion.Name = "dateTimePickerStartTimePortion";
            this.dateTimePickerStartTimePortion.ShowUpDown = true;
            this.dateTimePickerStartTimePortion.Size = new System.Drawing.Size(100, 22);
            this.dateTimePickerStartTimePortion.TabIndex = 4;
            this.dateTimePickerStartTimePortion.ValueChanged += new System.EventHandler(this.dateTimePickerStartTimePortion_ValueChanged);
            // 
            // dateTimePickerStartDatePortion
            // 
            this.dateTimePickerStartDatePortion.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerStartDatePortion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDatePortion.Location = new System.Drawing.Point(104, 173);
            this.dateTimePickerStartDatePortion.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStartDatePortion.Name = "dateTimePickerStartDatePortion";
            this.dateTimePickerStartDatePortion.Size = new System.Drawing.Size(100, 22);
            this.dateTimePickerStartDatePortion.TabIndex = 3;
            this.dateTimePickerStartDatePortion.ValueChanged += new System.EventHandler(this.dateTimePickerStartDatePortion_ValueChanged);
            // 
            // buttonViewLog
            // 
            this.buttonViewLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonViewLog.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_index_24;
            this.buttonViewLog.Location = new System.Drawing.Point(120, 360);
            this.buttonViewLog.Name = "buttonViewLog";
            this.buttonViewLog.Size = new System.Drawing.Size(100, 32);
            this.buttonViewLog.TabIndex = 12;
            this.buttonViewLog.Text = "View log";
            this.buttonViewLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonViewLog.UseVisualStyleBackColor = true;
            this.buttonViewLog.Click += new System.EventHandler(this.buttonViewLog_Click);
            // 
            // TicketDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 401);
            this.Controls.Add(this.buttonViewLog);
            this.Controls.Add(this.dateTimePickerStartTimePortion);
            this.Controls.Add(this.dateTimePickerStartDatePortion);
            this.Controls.Add(this.dateTimePickerEndTimePortion);
            this.Controls.Add(this.dateTimePickerEndDatePortion);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.buttonEditTicket);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelticketStatus);
            this.Controls.Add(this.buttonCreateTicket);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.labelTicketSubject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(2000, 448);
            this.MinimumSize = new System.Drawing.Size(341, 448);
            this.Name = "TicketDesigner";
            this.Load += new System.EventHandler(this.TicketDesigner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTicketSubject;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button buttonCreateTicket;
        private System.Windows.Forms.Label labelticketStatus;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Button buttonEditTicket;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDatePortion;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTimePortion;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTimePortion;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDatePortion;
        private System.Windows.Forms.Button buttonViewLog;
    }
}