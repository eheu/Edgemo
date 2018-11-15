using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BrightIdeasSoftware;

namespace EdgemoTicketSystem
{
    public partial class TicketDesigner : Form
    {
        public bool EditMode { get; set; } = false;
        public Ticket EditedTicket { get; set; }
        public ObjectListView objectListViewTicket { get; set; }
        public static Ticket CreatedTicket { get; set; } //Static so ID can be set from CreateTicket() method (eg. read from database)

        string subjectAfterChange = "";
        string subjectBeforeChange = "";
        string subjectLogEntry = "";

        string descriptionAfterChange = "";
        string descriptionBeforeChange = "";
        string descriptionLogEntry = "";

        string startDateAfterChange = "";
        string startDateBeforeChange = "";
        string startDateLogEntry = "";

        string startTimeAfterChange = "";
        string startTimeBeforeChange = "";
        string startTimeLogEntry = "";

        string endDateAfterChange = "";
        string endDateDateBeforeChange = "";
        string endDateLogEntry = "";

        string endTimeAfterChange = "";
        string endTimeBeforeChange = "";
        string endTimeLogEntry = "";

        string statusAfterChange = "";
        string statusBeforeChange = "";
        string statusLogEntry = "";

        string priorityAfterChange = "";
        string priorityBeforeChange = "";
        string priorityLogEntry = "";

        string teamAfterChange = "";
        string teamBeforeChange = "";
        string teamLogEntry = "";

        string employeeAfterChange = "";
        string employeeBeforeChange = "";
        string employeeLogEntry = "";


        public TicketDesigner()
        {
            InitializeComponent();
        }

        private void TicketDesigner_Load(object sender, EventArgs e)
        {
            comboBoxStatus.DataSource = Database.statuses;
            comboBoxStatus.DisplayMember = "statusName";
            comboBoxStatus.ValueMember = "ID";

            comboBoxPriority.DataSource = Database.priorities;
            comboBoxPriority.DisplayMember = "priorityName";
            comboBoxPriority.ValueMember = "ID";

            comboBoxTeam.DataSource = Database.teams;
            comboBoxTeam.DisplayMember = "teamName";
            comboBoxTeam.ValueMember = "ID";

            comboBoxEmployee.DataSource = Database.sortedEmployees.ElementAt(Convert.ToInt32(comboBoxTeam.SelectedValue) - 1);
            comboBoxEmployee.DisplayMember = "fullName";
            comboBoxEmployee.ValueMember = "ID";

            if (!EditMode)
            {
                Text = "Add Ticket";
                buttonEditTicket.Hide();
                buttonViewLog.Hide();
            }

            if (EditMode)
            {
                Text = "Edit Ticket";
                buttonCreateTicket.Hide();


                textBoxSubject.Text = subjectBeforeChange = EditedTicket.Subject;
                textBoxDescription.Text = descriptionBeforeChange = EditedTicket.Description;
                comboBoxStatus.SelectedValue = statusBeforeChange = EditedTicket.StatusID;
                comboBoxPriority.SelectedValue = priorityBeforeChange = EditedTicket.PriorityID;
                comboBoxTeam.SelectedValue = EditedTicket.TeamID;
                Team team = (Team)comboBoxTeam.SelectedItem;
                teamBeforeChange = team.TeamName;
                comboBoxEmployee.DataSource = Database.sortedEmployees.ElementAt(Convert.ToInt32(comboBoxTeam.SelectedValue) - 1);
                comboBoxEmployee.SelectedValue = EditedTicket.EmployeeID;
                employeeBeforeChange = comboBoxEmployee.SelectedText;
                dateTimePickerStartDatePortion.Text = startDateBeforeChange = EditedTicket.StartDate;
                dateTimePickerStartTimePortion.Text = startTimeBeforeChange = EditedTicket.StartDate;
                dateTimePickerEndDatePortion.Text = endDateDateBeforeChange = EditedTicket.EndDate;
                dateTimePickerEndTimePortion.Text = endTimeBeforeChange = EditedTicket.EndDate;
            }
        }


        private void buttonCreateTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Subject = textBoxSubject.Text;
            ticket.Description = textBoxDescription.Text;
            ticket.Log += DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n- created ticket \"" + textBoxSubject.Text + "\".";
            ticket.StartDate = dateTimePickerStartDatePortion.Text + " " + dateTimePickerStartTimePortion.Text;
            ticket.EndDate = dateTimePickerEndDatePortion.Text + " " + dateTimePickerEndTimePortion.Text;
            ticket.StatusID = comboBoxStatus.SelectedValue.ToString();
            ticket.PriorityID = comboBoxPriority.SelectedValue.ToString();
            ticket.TeamID = comboBoxTeam.SelectedValue.ToString();
            ticket.EmployeeID = comboBoxEmployee.SelectedValue.ToString();
            ticket.SourceID = "2";
            Database.CreateTicket(ticket);
            objectListViewTicket.AddObject(CreatedTicket);
            Close();
        }


        private void buttonEditTicket_Click(object sender, EventArgs e)
        {
            EditedTicket.Subject = textBoxSubject.Text;
            EditedTicket.Description = textBoxDescription.Text;
            EditedTicket.Log += $"\n" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + subjectLogEntry + descriptionLogEntry + startDateLogEntry + startTimeLogEntry + endDateLogEntry + endTimeLogEntry + statusLogEntry + priorityLogEntry + teamLogEntry + employeeLogEntry;
            EditedTicket.PriorityID = comboBoxPriority.SelectedValue.ToString();
            EditedTicket.SourceID = "2"; //User-created tickets are always from tlf.
            EditedTicket.StatusID = comboBoxStatus.SelectedValue.ToString();
            EditedTicket.OrderID = "NULL";
            EditedTicket.EmployeeID = comboBoxEmployee.SelectedValue.ToString();
            EditedTicket.TeamID = comboBoxTeam.SelectedValue.ToString();
            EditedTicket.StartDate = dateTimePickerStartDatePortion.Text + " " + dateTimePickerStartTimePortion.Text;
            EditedTicket.EndDate = dateTimePickerEndDatePortion.Text + " " + dateTimePickerEndTimePortion.Text;
            Database.UpdateTicket(EditedTicket);
            Database.ReadAllTickets();
            objectListViewTicket.SetObjects(Database.tickets);
            objectListViewTicket.RefreshObject(EditedTicket);
            Close();
        }

        private void buttonViewLog_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EditedTicket.Log);
        }

        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {
            // Log entry
            if (textBoxSubject == ActiveControl) //Workaround so log is only made if value change is by user (value change is initially by loading in value from ticket).
            {
                subjectAfterChange = textBoxSubject.Text;
                if (subjectBeforeChange != subjectAfterChange)
                {
                    subjectLogEntry = "\n- changed subject from \"" + subjectBeforeChange + "\" to \"" + textBoxSubject.Text + "\".";
                }
                else //No log entry if value wasn't actually changed.
                {
                    subjectLogEntry = "";
                }
            }
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDescription == ActiveControl) //Workaround so that log is only made if value change is from user (value change is initially from loading in value from ticket).
            {
                descriptionAfterChange = textBoxDescription.Text;
                if (descriptionBeforeChange != descriptionAfterChange)
                    descriptionLogEntry = "\n- changed the description.";
                else
                    descriptionLogEntry = "";
            }
        }

        private void dateTimePickerStartDatePortion_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerStartDatePortion == ActiveControl) //Workaround so that log is only made if value change is from user (value change is initially from loading in value from ticket).
            {
                startDateAfterChange = dateTimePickerStartDatePortion.Text;
                if (startDateBeforeChange != startDateAfterChange)
                    startDateLogEntry = "\n- start date was changed to: " + dateTimePickerStartDatePortion.Text + ".";
                else
                    descriptionLogEntry = "";
            }
        }

        private void dateTimePickerStartTimePortion_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerStartTimePortion == ActiveControl) //Workaround so that log is only made if value change is by user (value change is initially by loading in value from ticket).
            {
                startTimeAfterChange = dateTimePickerStartTimePortion.Text;
                if (startTimeBeforeChange != startTimeAfterChange)
                    startTimeLogEntry = "\n- start time was changed to: " + dateTimePickerStartTimePortion.Text;
                else
                    startTimeLogEntry = "";
            }
        }

        private void dateTimePickerEndDatePortion_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerEndDatePortion == ActiveControl) //Workaround so that log is only made if value change is by user (value change is initially by loading in value from ticket).
            {
                endDateAfterChange = dateTimePickerEndDatePortion.Text;
                if (endDateDateBeforeChange != endDateAfterChange)
                    endDateLogEntry = "\n- end date was changed to: " + dateTimePickerEndDatePortion.Text + ".";
                else
                    endDateLogEntry = "";
            }
        }

        private void dateTimePickerEndTimePortion_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerEndTimePortion == ActiveControl) //Workaround so that log is only made if value change is by user (value change is initially by loading in value from ticket).
            {
                endTimeAfterChange = dateTimePickerEndTimePortion.Text;
                if (endTimeBeforeChange != endTimeAfterChange)
                    endTimeLogEntry = "\n- end time was changed to: " + dateTimePickerEndTimePortion.Text;
                else
                    endTimeLogEntry = "";
            }
        }

        private void comboBoxStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            statusAfterChange = comboBoxStatus.Text;
            if (statusBeforeChange != statusAfterChange)
                statusLogEntry = "\n- status was changed to:  " + comboBoxStatus.Text + ".";
        }

        private void comboBoxPriority_SelectionChangeCommitted(object sender, EventArgs e)
        {
            priorityAfterChange = comboBoxPriority.Text;
            if (priorityBeforeChange != priorityAfterChange)
                priorityLogEntry = "\n- priority was changed to: " + comboBoxPriority.Text + ".";
        }

        private void comboBoxTeam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            teamAfterChange = comboBoxTeam.Text;
            if (teamBeforeChange != teamAfterChange)
                teamLogEntry = "\n- team was changed to: " + comboBoxTeam.Text + ".";

            comboBoxEmployee.DataSource = Database.sortedEmployees.ElementAt(Convert.ToInt32(comboBoxTeam.SelectedValue) - 1);
            comboBoxEmployee.Refresh();
        }

        private void comboBoxEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            employeeAfterChange = comboBoxEmployee.Text;
            if (employeeBeforeChange != employeeAfterChange)
                employeeLogEntry = "\n- employee was changed to: " + comboBoxEmployee.Text + ".";
        }
    }
}
