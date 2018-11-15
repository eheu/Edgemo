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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Ticket));
            this.ticketID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTicket = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ticketID
            // 
            resources.ApplyResources(this.ticketID, "ticketID");
            // 
            // ticketName
            // 
            resources.ApplyResources(this.ticketName, "ticketName");
            // 
            // listViewTicket
            // 
            this.listViewTicket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ticketID,
            this.ticketName});
            this.listViewTicket.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listViewTicket.Items")))});
            resources.ApplyResources(this.listViewTicket, "listViewTicket");
            this.listViewTicket.Name = "listViewTicket";
            this.listViewTicket.UseCompatibleStateImageBehavior = false;
            this.listViewTicket.View = System.Windows.Forms.View.Details;
            // 
            // List_Ticket
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewTicket);
            this.Name = "List_Ticket";
            this.Load += new System.EventHandler(this.List_Ticket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader ticketID;
        private System.Windows.Forms.ColumnHeader ticketName;
        private System.Windows.Forms.ListView listViewTicket;
    }
}