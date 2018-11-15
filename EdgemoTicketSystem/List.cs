using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace EdgemoTicketSystem
{
    public partial class List_Ticket : Form
    {
        private Timer timer;

        public List_Ticket()
        {
            InitializeComponent();
            //Load database
            Database.ReadAllTickets();
            Database.ReadAllStatuses();
            Database.ReadAllPriorities();
            Database.ReadAllTeams();
            Database.ReadAllEmployees();
            Database.FillTeams();

            // Suppress the string contents of the subject column since we are going to use
            // a decoration to draw it.
            olvColumnSubject.AspectToStringConverter = delegate (object modelObject)
            {
                return "";
            };

            // Set collection of objects OLV should display.
            objectListViewTicket.SetObjects(Database.tickets);

            // Pick aspect to filter by.
            comboBoxAspectPicker.Items.Add("Subject");
            comboBoxAspectPicker.Items.Add("Description");
            comboBoxAspectPicker.SelectedItem = "Subject";
        }

        private void objectListViewTicket_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            Ticket ticket = (Ticket)e.Model;
            if (e.ColumnIndex == 0)
            {
                NameDescriptionDecoration decoration = new NameDescriptionDecoration();
                decoration.Title = ticket.Subject;
                decoration.Description = ticket.Description;
                e.SubItem.Decoration = decoration;
            }
        }

        private void objectListViewTicket_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TicketDesigner formEditTicket = new TicketDesigner();
            AddOwnedForm(formEditTicket);
            formEditTicket.EditMode = true;
            formEditTicket.objectListViewTicket = objectListViewTicket;
            formEditTicket.EditedTicket = (Ticket)objectListViewTicket.SelectedObject;
            formEditTicket.Show();
        }


        private void objectListViewTicket_CellRightClick(object sender, CellRightClickEventArgs e)
        {
            if (e.Model != null)
            {
                ContextMenuStrip menuStrip = new ContextMenuStrip();
                if (objectListViewTicket.SelectedObjects.Count == 1)
                {
                    menuStrip.Items.Add("Delete ticket", Properties.Resources.icons8_trash_24, new EventHandler(DeleteTicket_Click));
                }
                if (objectListViewTicket.SelectedObjects.Count > 1)
                {
                    menuStrip.Items.Add("Delete tickets", Properties.Resources.icons8_trash_24, new EventHandler(DeleteTickets_Click));
                }

                e.MenuStrip = menuStrip;
            }
        }


        private void DeleteTicket_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this ticket?",
                                     "Confirm deletion",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Database.DeleteTicket((Ticket)objectListViewTicket.SelectedObject);
                objectListViewTicket.RemoveObject(objectListViewTicket.SelectedObject);
            }
        }

        private void DeleteTickets_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete " + objectListViewTicket.SelectedObjects.Count + " tickets?",
                         "Confirm deletion",
                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                List<string> ticketIDs = new List<string>();
                foreach (object o in objectListViewTicket.SelectedObjects)
                {
                    Ticket t = (Ticket)o;
                    ticketIDs.Add(t.ID);
                    objectListViewTicket.RemoveObject(o);
                }
                Database.DeleteTickets(ticketIDs);
            }
        }

        private void buttonCreateTicket_Click(object sender, EventArgs e)
        {
            TicketDesigner formCreateTicket = new TicketDesigner();
            AddOwnedForm(formCreateTicket);
            formCreateTicket.objectListViewTicket = objectListViewTicket;
            formCreateTicket.Show();
        }

        private void buttonPrintTickets_Click(object sender, EventArgs e)
        {
            olvColumnSubject.AspectToStringConverter = null; // Remove suppression of string contents of the subject column since ListViewPrinter relies on it
            objectListViewTicket.RebuildColumns();
            ListViewPrinter listViewPrinter = new ListViewPrinter();
            listViewPrinter.ListView = objectListViewTicket;
            listViewPrinter.PrintPreview();
            olvColumnSubject.AspectToStringConverter = delegate (object modelObject) // Suppress string contents of the subject column again
            {
                return "";
            };
            objectListViewTicket.RebuildColumns();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            RestartTimer(); // See: https://stackoverflow.com/a/15416653
        }

        public void RestartTimer()
        {
            if (timer == null)
            {
                timer = new Timer { Enabled = true, Interval = 500 };
                timer.Tick += Timer_Tick;
            }
            else
            {
                timer.Stop();
                timer.Start();
            }
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            RevokeTimer();
            if (textBoxSearch.Text != "Search...")
            {
                objectListViewTicket.ModelFilter = new AspectFilter(comboBoxAspectPicker.Text, textBoxSearch.Text);
            }
        }

        public void RevokeTimer()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Tick -= Timer_Tick;
                timer = null;
            }
        }

        private void objectListViewTicket_FormatRow(object sender, FormatRowEventArgs e)
        {
            Ticket ticket = (Ticket)e.Model;
            if (ticket.IsOverdue == "1")
            {
                e.Item.BackColor = Color.Yellow;
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Search...";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (objectListViewTicket.SelectedObjects.Count == 1)
            {
                DeleteTicket_Click(sender, e);
            }
            if (objectListViewTicket.SelectedObjects.Count > 1)
            {
                DeleteTickets_Click(sender, e);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            foreach (var Ticket in objectListViewTicket.SelectedObjects)
            {
                TicketDesigner formEditTicket = new TicketDesigner();
                AddOwnedForm(formEditTicket);
                formEditTicket.EditedTicket = (Ticket)objectListViewTicket.SelectedObject;
                formEditTicket.EditMode = true;
                formEditTicket.Show();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            TeamSettings teamEditor = new TeamSettings();
            AddOwnedForm(teamEditor);
            teamEditor.ObjectListViewTicket = objectListViewTicket;
            teamEditor.Show();
        }

        private void TeamEditor_FormClosed(object sender, EventArgs e)
        {
            objectListViewTicket.SetObjects(Database.tickets);
        }
    }
}
