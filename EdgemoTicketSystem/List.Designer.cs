namespace EdgemoTicketSystem
{
    partial class List_Ticket
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Ticket));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dataListViewColumnTicketID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.objectListViewTicket = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnSubject = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnStartDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEndDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPriority = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTeam = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEmployee = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnManagerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxAspectPicker = new System.Windows.Forms.ComboBox();
            this.contextMenuStripSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonPrintTickets = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.olvColumnIsOverdue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewTicket)).BeginInit();
            this.contextMenuStripSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "ticketName";
            // 
            // dataListViewColumnTicketID
            // 
            this.dataListViewColumnTicketID.AspectName = "ticketID";
            resources.ApplyResources(this.dataListViewColumnTicketID, "dataListViewColumnTicketID");
            this.dataListViewColumnTicketID.Groupable = false;
            this.dataListViewColumnTicketID.IsVisible = false;
            // 
            // objectListViewTicket
            // 
            this.objectListViewTicket.AllColumns.Add(this.olvColumnSubject);
            this.objectListViewTicket.AllColumns.Add(this.olvColumnStartDate);
            this.objectListViewTicket.AllColumns.Add(this.olvColumnEndDate);
            this.objectListViewTicket.AllColumns.Add(this.olvColumnStatus);
            this.objectListViewTicket.AllColumns.Add(this.olvColumnPriority);
            this.objectListViewTicket.AllColumns.Add(this.olvColumnTeam);
            this.objectListViewTicket.AllColumns.Add(this.olvColumnEmployee);
            this.objectListViewTicket.AllColumns.Add(this.olvColumnManagerName);
            this.objectListViewTicket.AllColumns.Add(this.olvColumnID);
            this.objectListViewTicket.AllColumns.Add(this.olvColumnIsOverdue);
            resources.ApplyResources(this.objectListViewTicket, "objectListViewTicket");
            this.objectListViewTicket.CellEditUseWholeCell = false;
            this.objectListViewTicket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnSubject,
            this.olvColumnStartDate,
            this.olvColumnEndDate,
            this.olvColumnStatus,
            this.olvColumnPriority,
            this.olvColumnTeam,
            this.olvColumnEmployee,
            this.olvColumnManagerName,
            this.olvColumnIsOverdue});
            this.objectListViewTicket.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewTicket.FullRowSelect = true;
            this.objectListViewTicket.HasCollapsibleGroups = false;
            this.objectListViewTicket.Name = "objectListViewTicket";
            this.objectListViewTicket.RowHeight = 52;
            this.objectListViewTicket.ShowGroups = false;
            this.objectListViewTicket.TintSortColumn = true;
            this.objectListViewTicket.UseCellFormatEvents = true;
            this.objectListViewTicket.UseCompatibleStateImageBehavior = false;
            this.objectListViewTicket.UseFiltering = true;
            this.objectListViewTicket.View = System.Windows.Forms.View.Details;
            this.objectListViewTicket.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.objectListViewTicket_CellRightClick);
            this.objectListViewTicket.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.objectListViewTicket_FormatCell);
            this.objectListViewTicket.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.objectListViewTicket_FormatRow);
            this.objectListViewTicket.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListViewTicket_MouseDoubleClick);
            // 
            // olvColumnSubject
            // 
            this.olvColumnSubject.AspectName = "Subject";
            this.olvColumnSubject.FillsFreeSpace = true;
            resources.ApplyResources(this.olvColumnSubject, "olvColumnSubject");
            this.olvColumnSubject.WordWrap = true;
            // 
            // olvColumnStartDate
            // 
            this.olvColumnStartDate.AspectName = "StartDate";
            this.olvColumnStartDate.FillsFreeSpace = true;
            resources.ApplyResources(this.olvColumnStartDate, "olvColumnStartDate");
            // 
            // olvColumnEndDate
            // 
            this.olvColumnEndDate.AspectName = "EndDate";
            this.olvColumnEndDate.FillsFreeSpace = true;
            resources.ApplyResources(this.olvColumnEndDate, "olvColumnEndDate");
            // 
            // olvColumnStatus
            // 
            this.olvColumnStatus.AspectName = "StatusName";
            this.olvColumnStatus.FillsFreeSpace = true;
            resources.ApplyResources(this.olvColumnStatus, "olvColumnStatus");
            // 
            // olvColumnPriority
            // 
            this.olvColumnPriority.AspectName = "PriorityName";
            this.olvColumnPriority.FillsFreeSpace = true;
            resources.ApplyResources(this.olvColumnPriority, "olvColumnPriority");
            // 
            // olvColumnTeam
            // 
            this.olvColumnTeam.AspectName = "TeamName";
            this.olvColumnTeam.FillsFreeSpace = true;
            resources.ApplyResources(this.olvColumnTeam, "olvColumnTeam");
            // 
            // olvColumnEmployee
            // 
            this.olvColumnEmployee.AspectName = "EmployeeName";
            this.olvColumnEmployee.FillsFreeSpace = true;
            resources.ApplyResources(this.olvColumnEmployee, "olvColumnEmployee");
            // 
            // olvColumnManagerName
            // 
            this.olvColumnManagerName.AspectName = "ManagerName";
            this.olvColumnManagerName.FillsFreeSpace = true;
            resources.ApplyResources(this.olvColumnManagerName, "olvColumnManagerName");
            // 
            // olvColumnID
            // 
            this.olvColumnID.AspectName = "ID";
            resources.ApplyResources(this.olvColumnID, "olvColumnID");
            this.olvColumnID.IsVisible = false;
            // 
            // textBoxSearch
            // 
            resources.ApplyResources(this.textBoxSearch, "textBoxSearch");
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // comboBoxAspectPicker
            // 
            resources.ApplyResources(this.comboBoxAspectPicker, "comboBoxAspectPicker");
            this.comboBoxAspectPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAspectPicker.FormattingEnabled = true;
            this.comboBoxAspectPicker.Name = "comboBoxAspectPicker";
            // 
            // contextMenuStripSettings
            // 
            this.contextMenuStripSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamsToolStripMenuItem});
            this.contextMenuStripSettings.Name = "contextMenuStripSettings";
            resources.ApplyResources(this.contextMenuStripSettings, "contextMenuStripSettings");
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_people_24;
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            resources.ApplyResources(this.teamsToolStripMenuItem, "teamsToolStripMenuItem");
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            resources.ApplyResources(this.subjectToolStripMenuItem, "subjectToolStripMenuItem");
            // 
            // buttonSettings
            // 
            resources.ApplyResources(this.buttonSettings, "buttonSettings");
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_people_24;
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_delete_document_24;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            resources.ApplyResources(this.buttonEdit, "buttonEdit");
            this.buttonEdit.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_edit_property_24;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonPrintTickets
            // 
            resources.ApplyResources(this.buttonPrintTickets, "buttonPrintTickets");
            this.buttonPrintTickets.ForeColor = System.Drawing.Color.Black;
            this.buttonPrintTickets.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_print_24;
            this.buttonPrintTickets.Name = "buttonPrintTickets";
            this.buttonPrintTickets.UseVisualStyleBackColor = true;
            this.buttonPrintTickets.Click += new System.EventHandler(this.buttonPrintTickets_Click);
            // 
            // buttonCreate
            // 
            resources.ApplyResources(this.buttonCreate, "buttonCreate");
            this.buttonCreate.Image = global::EdgemoTicketSystem.Properties.Resources.icons8_add_property_24;
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreateTicket_Click);
            // 
            // olvColumnIsOverdue
            // 
            this.olvColumnIsOverdue.AspectName = "IsOverdue";
            // 
            // List_Ticket
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxAspectPicker);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonPrintTickets);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.objectListViewTicket);
            this.Name = "List_Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewTicket)).EndInit();
            this.contextMenuStripSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn dataListViewColumnTicketID;
        private BrightIdeasSoftware.ObjectListView objectListViewTicket;
        private BrightIdeasSoftware.OLVColumn olvColumnID;
        private BrightIdeasSoftware.OLVColumn olvColumnSubject;
        private BrightIdeasSoftware.OLVColumn olvColumnStartDate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonPrintTickets;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxAspectPicker;
        private BrightIdeasSoftware.OLVColumn olvColumnEndDate;
        private BrightIdeasSoftware.OLVColumn olvColumnPriority;
        private BrightIdeasSoftware.OLVColumn olvColumnEmployee;
        private BrightIdeasSoftware.OLVColumn olvColumnTeam;
        private BrightIdeasSoftware.OLVColumn olvColumnManagerName;
        private BrightIdeasSoftware.OLVColumn olvColumnStatus;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSettings;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn olvColumnIsOverdue;
    }
}