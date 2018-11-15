using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdgemoTicketSystem
{
    public partial class List_Ticket : Form
    {
        public List_Ticket()
        {
            InitializeComponent();
            listViewTicket.MouseDoubleClick += new MouseEventHandler(listViewTicket_MouseDoubleClick);
        }

        private void listViewTicket_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Edit_Ticket editTicketForm = new Edit_Ticket();
            editTicketForm.TicketData = ((ListView)sender).SelectedItems[0] ;
            editTicketForm.Show();
            Hide();
        }

        private void List_Ticket_Load(object sender, EventArgs e)
        {
            DataTable dataTable = Database.ListTickets();
            listViewTicket.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                var list = listViewTicket.Items.Add(row["ticketID"].ToString());
                list.SubItems.Add(row["ticketName"].ToString());
            }
        }
    }

}
