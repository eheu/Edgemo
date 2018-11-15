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
    public partial class TeamDesigner : Form
    {
        public bool EditMode { get; set; } = false;
        public Team EditedTeam { get; set; }
        public ObjectListView ObjectListViewTicket { get; set; }
        public ComboBox ComboBoxBeforeTeam { get; set; }
        public ComboBox ComboBoxAfterTeam { get; set; }

        public TeamDesigner()
        {
            InitializeComponent();
        }

        private void TeamDesigner_Load(object sender, EventArgs e)
        {
            comboBoxTeamManager.DisplayMember = "fullName";
            comboBoxTeamManager.ValueMember = "ID";
            comboBoxTeamManager.DataSource = Database.employees;

            if(!EditMode)
            {
                buttonEditTeam.Hide();
                Text = "Add Team";
            }
            if (EditMode)
            {
                buttonAddTeam.Hide();
                Text = "Edit Team";
                textBoxTeamName.Text = EditedTeam.TeamName;
                comboBoxTeamManager.SelectedValue = EditedTeam.ManagerID;
            }
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            team.TeamName = textBoxTeamName.Text;
            team.ManagerID = (string)comboBoxTeamManager.SelectedValue;
            Database.CreateTeam(team);
            Database.ReadAllTeams();
            Database.FillTeams();
            RefreshControls();
            Hide();
        }

        private void buttonEditTeam_Click(object sender, EventArgs e)
        {
            EditedTeam.TeamName = textBoxTeamName.Text;
            EditedTeam.ManagerID = (string)comboBoxTeamManager.SelectedValue;
            Database.UpdateTeam(EditedTeam);
            Database.ReadAllTeams();
            Database.ReadAllTickets();
            RefreshControls();
            Hide();
        }

        public void RefreshControls()
        {
            ObjectListViewTicket.SetObjects(Database.tickets);
            ComboBoxBeforeTeam.DataSource = Database.teams;
            List<Team> afterTeamDataSource = new List<Team>();
            afterTeamDataSource.AddRange(Database.teams);
            afterTeamDataSource.RemoveAt(ComboBoxBeforeTeam.SelectedIndex);
            ComboBoxAfterTeam.DataSource = afterTeamDataSource;
        }
    }
}
