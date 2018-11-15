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
    public partial class EmployeeDesigner : Form
    {
        public bool EditMode { get; set; } = false;
        public ObjectListView ObjectListViewEmployee { get; set; }
        public ObjectListView ObjectListViewTicket { get; set; }
        public Employee EditedEmployee { get; set; }
        public ComboBox ComboBoxBeforeTeam { get; set; }
        public ComboBox ComboBoxAfterTeam { get; set; }

        public EmployeeDesigner()
        {
            InitializeComponent();
        }

        private void EmployeeDesigner_Load(object sender, EventArgs e)
        {
            comboBoxTeam.DisplayMember = "teamName";
            comboBoxTeam.ValueMember = "ID";
            comboBoxTeam.DataSource = Database.teams;
            comboBoxTeam.SelectedIndex = ComboBoxBeforeTeam.SelectedIndex;

            if (!EditMode)
            {
                buttonEditEmployee.Hide();
                Text = "Add employee";
            }
            if (EditMode)
            {
                buttonAddEmployee.Hide();
                Text = "Edit employee";
                textBoxFirstName.Text = EditedEmployee.FirstName;
                textBoxLastName.Text = EditedEmployee.LastName;
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = textBoxFirstName.Text;
            employee.LastName = textBoxLastName.Text;
            employee.TeamID = (string)comboBoxTeam.SelectedValue;
            Database.CreateEmployee(employee);
            Database.ReadAllEmployees();
            Database.FillTeams();
            ObjectListViewEmployee.SetObjects(Database.sortedEmployees.ElementAt(Convert.ToInt32(ComboBoxBeforeTeam.SelectedValue) - 1));
            Hide();
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            EditedEmployee.FirstName = textBoxFirstName.Text;
            EditedEmployee.LastName = textBoxLastName.Text;
            EditedEmployee.TeamID = (string)comboBoxTeam.SelectedValue;
            Database.UpdateEmployee(EditedEmployee);
            Database.ReadAllEmployees();
            Database.FillTeams();
            Database.ReadAllTickets();
            ObjectListViewEmployee.SetObjects(Database.sortedEmployees.ElementAt(Convert.ToInt32(ComboBoxBeforeTeam.SelectedValue) - 1));
            ObjectListViewTicket.SetObjects(Database.tickets);
            Hide();
        }
    }
}
