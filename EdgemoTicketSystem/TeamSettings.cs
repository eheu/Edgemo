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
    public partial class TeamSettings : Form
    {
        public ObjectListView ObjectListViewTicket { get; set; }
        public Team SelectedTeam { get; set; }
        public Employee CurrentManager { get; set; }
        public int SelectedBeforeTeamIndex { get; set; } = 0;

        public TeamSettings()
        {
            InitializeComponent();
        }

        private void TeamSettings_Load(object sender, EventArgs e)
        {
            RefreshComboBoxBeforeTeamDataSource();
            RefreshComboBoxAfterTeamDataSource();
            RefreshCurrentManagerLabel();

            objectListViewEmployee.SetObjects(Database.sortedEmployees.ElementAt(Convert.ToInt32(comboBoxBeforeTeam.SelectedValue) - 1));
        }

        private void RefreshCurrentManagerLabel()
        {
            SelectedTeam = (Team)comboBoxBeforeTeam.SelectedItem;
            comboBoxEmployees.SelectedValue = SelectedTeam.ManagerID;
            CurrentManager = (Employee)comboBoxEmployees.SelectedItem;
            labelCurrentTeamManager.Text = "Manager of team " + SelectedTeam.TeamName + " is " + CurrentManager.fullName;
        }

        private void RefreshComboBoxBeforeTeamDataSource()
        {
            comboBoxBeforeTeam.DisplayMember = "teamName";
            comboBoxAfterTeam.DisplayMember = "teamName";
            comboBoxBeforeTeam.ValueMember = "ID";
            comboBoxAfterTeam.ValueMember = "ID";

            comboBoxBeforeTeam.DataSource = Database.teams;
            comboBoxBeforeTeam.SelectedIndex = SelectedBeforeTeamIndex;

            // Not visible combobox in order to build team manager label for display in UI.
            comboBoxEmployees.DisplayMember = "fullName";
            comboBoxEmployees.ValueMember = "ID";
            comboBoxEmployees.DataSource = Database.employees;
        }

        private void RefreshComboBoxAfterTeamDataSource()
        {
            // Don't have the before team in comboboxAfterTeam
            List<Team> afterTeamDataSource = new List<Team>();
            afterTeamDataSource.AddRange(Database.teams);
            afterTeamDataSource.RemoveAt(comboBoxBeforeTeam.SelectedIndex);
            comboBoxAfterTeam.DataSource = afterTeamDataSource;
        }

        private void comboBoxBeforeTeam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            objectListViewEmployee.SetObjects(Database.sortedEmployees.ElementAt(Convert.ToInt32(comboBoxBeforeTeam.SelectedValue) - 1));
            RefreshComboBoxAfterTeamDataSource();
            RefreshCurrentManagerLabel();
        }

        private void buttonMoveEmployee_Click(object sender, EventArgs e)
        {
            if (objectListViewEmployee.SelectedObjects.Count == 1)
            {
                Team team = (Team)comboBoxAfterTeam.SelectedItem;
                Employee employee = (Employee)objectListViewEmployee.SelectedObject;

                DialogResult confirmResult = MessageBox.Show("Are you sure you want to move " + employee.FirstName + " to team " + team.TeamName + "?", "Confirm Team Change", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Database.ChangeEmployeeTeam(team.ID, employee.ID);
                }
                Database.FillTeams();
                Database.ReadAllTickets();
                objectListViewEmployee.SetObjects(Database.sortedEmployees.ElementAt(Convert.ToInt32(comboBoxBeforeTeam.SelectedValue) - 1));
                ObjectListViewTicket.SetObjects(Database.tickets);  
            }
            else if (objectListViewEmployee.SelectedObjects.Count > 1)
            {
                Team team = (Team)comboBoxAfterTeam.SelectedItem;
                List<Employee> selectedEmployeesList = new List<Employee>();
                foreach (var employeeObject in objectListViewEmployee.SelectedObjects)
                {
                    Employee employee = (Employee)employeeObject;
                    selectedEmployeesList.Add(employee);
                }
                string selectedEmployeesString = String.Join(", ", selectedEmployeesList);
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to move " + selectedEmployeesString + " to team " + team.TeamName + "?", "Confirm Team Change", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (var employeeObject in objectListViewEmployee.SelectedObjects)
                    {
                        Employee employee = (Employee)employeeObject;
                        Database.ChangeEmployeeTeam(team.ID, employee.ID);
                        objectListViewEmployee.RemoveObject(objectListViewEmployee.SelectedObject);
                    }
                    Database.FillTeams();
                    Database.ReadAllTickets();
                    objectListViewEmployee.SetObjects(Database.sortedEmployees.ElementAt(Convert.ToInt32(comboBoxBeforeTeam.SelectedValue) - 1));
                    ObjectListViewTicket.SetObjects(Database.tickets);
                }
            }
            else
            {
                MessageBox.Show("You must select an employee to move.");
            }
        }


        private void buttonMakeManager_Click(object sender, EventArgs e)
        {
            if (objectListViewEmployee.SelectedObjects.Count == 1)
            {
                Employee employee = (Employee)objectListViewEmployee.SelectedObject;
                Team team = (Team)comboBoxBeforeTeam.SelectedItem;
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to make " + employee.FirstName + " the manager of team " + team.TeamName + "?", "Confirm Manager Change", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Database.UpdateTeamManager(employee.ID, team.ID);
                    Database.ReadAllTeams();
                    Database.FillTeams();
                    Database.ReadAllTickets();
                    SelectedBeforeTeamIndex = comboBoxBeforeTeam.SelectedIndex;
                    RefreshComboBoxBeforeTeamDataSource();
                    RefreshCurrentManagerLabel();
                    ObjectListViewTicket.SetObjects(Database.tickets);
                }
            }
            else if (objectListViewEmployee.SelectedObjects.Count > 1)
            {
                MessageBox.Show("You can only make one employee the team manager.");
            }
            else
            {
                MessageBox.Show("You must select an employee before making him/her the team manager.");
            }
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            TeamDesigner formAddTeam = new TeamDesigner();
            AddOwnedForm(formAddTeam);
            formAddTeam.ComboBoxBeforeTeam = comboBoxBeforeTeam;
            formAddTeam.ComboBoxAfterTeam = comboBoxAfterTeam;
            formAddTeam.ObjectListViewTicket = ObjectListViewTicket;
            formAddTeam.Show();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeDesigner formAddEmployee = new EmployeeDesigner();
            AddOwnedForm(formAddEmployee);
            formAddEmployee.ComboBoxBeforeTeam = comboBoxBeforeTeam;
            formAddEmployee.ObjectListViewEmployee = objectListViewEmployee;
            formAddEmployee.Show();

        }

        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            Team team = (Team)comboBoxBeforeTeam.SelectedItem;
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete team " + team.TeamName + "?", "Confirm Team Deletion", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Database.DeleteTeam(team);
                Database.ReadAllTeams();
                comboBoxBeforeTeam.DataSource = Database.teams;
                comboBoxBeforeTeam.Refresh();
                comboBoxBeforeTeam.ResetText();
            }
        }

        private void buttonEditTeam_Click(object sender, EventArgs e)
        {
            TeamDesigner editTeams = new TeamDesigner();
            editTeams.EditMode = true;
            editTeams.EditedTeam = (Team)comboBoxBeforeTeam.SelectedItem;
            editTeams.ComboBoxBeforeTeam = comboBoxBeforeTeam;
            editTeams.ComboBoxAfterTeam = comboBoxAfterTeam;
            editTeams.ObjectListViewTicket = ObjectListViewTicket;
            AddOwnedForm(editTeams);
            editTeams.Show();
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            if (objectListViewEmployee.SelectedObjects.Count > 0)
            {
                foreach (var Employee in objectListViewEmployee.SelectedObjects)
                {
                    EmployeeDesigner formEditEmployee = new EmployeeDesigner();
                    AddOwnedForm(formEditEmployee);
                    formEditEmployee.EditMode = true;
                    formEditEmployee.ComboBoxBeforeTeam = comboBoxBeforeTeam;
                    formEditEmployee.ComboBoxAfterTeam = comboBoxAfterTeam;
                    formEditEmployee.ObjectListViewTicket = ObjectListViewTicket;
                    formEditEmployee.ObjectListViewEmployee = objectListViewEmployee;
                    formEditEmployee.EditedEmployee = (Employee)Employee;
                    formEditEmployee.Show();
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any employee(s).");
            }
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (objectListViewEmployee.SelectedObjects.Count == 1)
            {
                Employee employee = (Employee)objectListViewEmployee.SelectedObject;
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete employee " + employee.FirstName + "?", "Confirm Employee Deletion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Database.DeleteEmployee(employee);
                    Database.ReadAllEmployees();
                    Database.FillTeams();
                    objectListViewEmployee.SetObjects(Database.sortedEmployees.ElementAt(Convert.ToInt32(comboBoxBeforeTeam.SelectedValue) - 1));
                }
            }
            else if (objectListViewEmployee.SelectedObjects.Count > 1)
            {
                List<Employee> selectedEmployeesList = new List<Employee>();
                foreach (var employeeObject in objectListViewEmployee.SelectedObjects)
                {
                    Employee employee = (Employee)employeeObject;
                    selectedEmployeesList.Add(employee);
                }
                string selectedEmployeesString = string.Join(", ", selectedEmployeesList);
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete employees " + selectedEmployeesString + "?", "Confirm Employee Deletion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (var employeeObject in objectListViewEmployee.SelectedObjects)
                    {
                        Employee employee = (Employee)employeeObject;
                        Database.DeleteEmployee(employee);
                        Database.ReadAllEmployees();
                        Database.FillTeams();
                        objectListViewEmployee.SetObjects(Database.sortedEmployees.ElementAt(Convert.ToInt32(comboBoxBeforeTeam.SelectedValue) - 1));
                    }
                }

            }
            else
            {
                MessageBox.Show("You haven't selected any employee(s).");
            }
        }
    }
}

