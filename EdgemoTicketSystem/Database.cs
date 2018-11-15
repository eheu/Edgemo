using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace EdgemoTicketSystem
{
    static class Database
    {
        public static List<Ticket> tickets;
        public static List<Status> statuses;
        public static List<Priority> priorities;
        public static List<Team> teams;
        public static List<List<Employee>> sortedEmployees;
        public static List<Employee> employees;
        public static int TeamDeleteCount;
        public static int EmployeeDeleteCount;

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["EdgemoTicketSystem.Properties.Settings.connString"].ConnectionString;
        }

        // Methods for table: Ticket
        // Create
        public static void CreateTicket(Ticket ticket)
        {
            int ID;
            string query = "INSERT INTO Ticket " +
                           "VALUES (@Subject, @Description, @Log, @StartDate, @EndDate, @StatusID, @PriorityID, @EmployeeID, @SourceID, null) " +
                           "SELECT SCOPE_IDENTITY()";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("Subject", SqlDbType.VarChar, 255).Value = ticket.Subject;
                command.Parameters.Add("Description", SqlDbType.NVarChar).Value = ticket.Description;
                command.Parameters.Add("Log", SqlDbType.NVarChar).Value = ticket.Log;
                command.Parameters.Add("StartDate", SqlDbType.DateTime).Value = ticket.StartDate;
                command.Parameters.Add("EndDate", SqlDbType.DateTime).Value = ticket.EndDate;
                command.Parameters.Add("StatusID", SqlDbType.Int).Value = ticket.StatusID;
                command.Parameters.Add("PriorityID", SqlDbType.Int).Value = ticket.PriorityID;
                command.Parameters.Add("EmployeeID", SqlDbType.Int).Value = ticket.EmployeeID;
                command.Parameters.Add("SourceID", SqlDbType.Int).Value = ticket.SourceID;
                //command.Parameters.Add("OrderID", SqlDbType.Int).Value = ticket.OrderID;
                connection.Open();
                ID = Convert.ToInt32(command.ExecuteScalar());
                TicketDesigner.CreatedTicket = ReadTicket(ID);
            }
        }


        // Read
        public static void ReadAllTickets()
        {
            string query = "SELECT Ticket.ID, tSubject, tDescription, tLog, startDate, endDate, isOverdue, statusID, statusName, priorityID, priorityName, employee.teamID, teamName, employee.ID AS employeeID, employee.firstName + ' ' + employee.lastName AS employeeName, manager.ID AS managerID, manager.firstName + ' ' + manager.lastName AS managerName, sourceID, sourceName, orderID FROM Ticket " +
                           "JOIN StatusList ON ticket.statusID = StatusList.ID " +
                           "JOIN PriorityList ON Ticket.priorityID = PriorityList.ID " +
                           "JOIN Employee employee ON Ticket.employeeID = employee.ID " +
                           "JOIN Team ON employee.teamID = Team.ID " +
                           "JOIN Employee manager ON Team.managerID = manager.ID " +
                           "JOIN SourceList ON ticket.sourceID = SourceList.ID";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    tickets = new List<Ticket>();
                    while (dataReader.Read())
                    {
                        Ticket t = new Ticket();
                        t.ID = dataReader["ID"].ToString();
                        t.Subject = dataReader["tSubject"].ToString();
                        t.Description = dataReader["tDescription"].ToString();
                        t.Log = dataReader["tLog"].ToString();
                        t.StartDate = ((DateTime)dataReader["startDate"]).ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                        t.EndDate = ((DateTime)dataReader["endDate"]).ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                        t.IsOverdue = dataReader["isOverdue"].ToString();
                        t.StatusID = dataReader["statusID"].ToString();
                        t.StatusName = dataReader["statusName"].ToString();
                        t.PriorityID = dataReader["priorityID"].ToString();
                        t.PriorityName = dataReader["priorityName"].ToString();
                        t.TeamID = dataReader["teamID"].ToString();
                        t.TeamName = dataReader["teamName"].ToString();
                        t.EmployeeID = dataReader["employeeID"].ToString();
                        t.EmployeeName = dataReader["employeeName"].ToString();
                        t.ManagerID = dataReader["managerID"].ToString();
                        t.ManagerName = dataReader["managerName"].ToString();
                        t.SourceID = dataReader["sourceID"].ToString(); // Redundant (always "1").
                        t.SourceName = dataReader["sourceName"].ToString(); // Redundant (always "tlf").
                        t.OrderID = dataReader["orderID"].ToString(); //Not yet implemented.
                        tickets.Add(t);
                    }
                }
            }
        }


        public static Ticket ReadTicket(int ID)
        {
            string query = "SELECT Ticket.ID, tSubject, tDescription, tLog, startDate, endDate, isOverdue, statusID, statusName, priorityID, priorityName, employee.teamID, teamName, employee.ID AS employeeID, employee.firstName + ' ' + employee.lastName AS employeeName, manager.ID AS managerID, manager.firstName + ' ' + manager.lastName AS managerName, sourceID, sourceName, orderID FROM Ticket " +
                           "JOIN StatusList ON ticket.statusID = StatusList.ID " +
                           "JOIN PriorityList ON Ticket.priorityID = PriorityList.ID " +
                           "JOIN Employee employee ON Ticket.employeeID = employee.ID " +
                           "JOIN Team ON employee.teamID = Team.ID " +
                           "JOIN Employee manager ON Team.managerID = manager.ID " +
                           "JOIN SourceList ON ticket.sourceID = SourceList.ID " +
                           "WHERE Ticket.ID = @ID";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("ID", SqlDbType.Int).Value = ID;
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    Ticket t = new Ticket();
                    while (dataReader.Read())
                    {
                        t.ID = dataReader["ID"].ToString();
                        t.Subject = dataReader["tSubject"].ToString();
                        t.Description = dataReader["tDescription"].ToString();
                        t.Log = dataReader["tLog"].ToString();
                        t.StartDate = ((DateTime)dataReader["startDate"]).ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                        t.EndDate = ((DateTime)dataReader["endDate"]).ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                        t.IsOverdue = dataReader["isOverdue"].ToString();
                        t.StatusID = dataReader["statusID"].ToString();
                        t.StatusName = dataReader["statusName"].ToString();
                        t.PriorityID = dataReader["priorityID"].ToString();
                        t.PriorityName = dataReader["priorityName"].ToString();
                        t.TeamID = dataReader["teamID"].ToString();
                        t.TeamName = dataReader["teamName"].ToString();
                        t.EmployeeID = dataReader["employeeID"].ToString();
                        t.EmployeeName = dataReader["employeeName"].ToString();
                        t.ManagerID = dataReader["managerID"].ToString();
                        t.ManagerName = dataReader["managerName"].ToString();
                        t.SourceID = dataReader["sourceID"].ToString(); // Redundant (always "1").
                        t.SourceName = dataReader["sourceName"].ToString(); // Redundant (always "tlf").
                        t.OrderID = dataReader["orderID"].ToString(); //Not yet implemented.
                    }
                    return t;
                }
            }
        }

        // Update
        public static void UpdateTicket(Ticket ticket)
        {
            string query = "UPDATE Ticket " +
                           "SET tSubject = @Subject, tDescription = @Description, tLog = @Log, startDate = @StartDate, endDate = @EndDate, statusID = @StatusID, priorityID = @PriorityID, employeeID = @EmployeeID, sourceID = @SourceID, orderID = null " +
                           "WHERE ID = @ID";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("Subject", SqlDbType.VarChar, 255).Value = ticket.Subject;
                command.Parameters.Add("Description", SqlDbType.NVarChar).Value = ticket.Description;
                command.Parameters.Add("Log", SqlDbType.NVarChar).Value = ticket.Log;
                command.Parameters.Add("StartDate", SqlDbType.DateTime).Value = ticket.StartDate;
                command.Parameters.Add("EndDate", SqlDbType.DateTime).Value = ticket.EndDate;
                command.Parameters.Add("StatusID", SqlDbType.Int).Value = ticket.StatusID;
                command.Parameters.Add("PriorityID", SqlDbType.Int).Value = ticket.PriorityID;
                command.Parameters.Add("EmployeeID", SqlDbType.Int).Value = ticket.EmployeeID;
                command.Parameters.Add("SourceID", SqlDbType.Int).Value = ticket.SourceID;
                command.Parameters.Add("ID", SqlDbType.Int).Value = ticket.ID;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete
        public static void DeleteTicket(Ticket ticket)
        {
            string query = $"DELETE FROM Ticket " +
                           $"WHERE ID = @ID";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("ID", SqlDbType.Int).Value = ticket.ID;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteTickets(List<String> ticketIDs)
        {
            string query = $"DELETE FROM Ticket " +
                           $"WHERE ID IN ({string.Join(",", ticketIDs)})";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Methods for table: StatusList
        // Read
        public static void ReadAllStatuses()
        {
            string query = "SELECT * FROM StatusList";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    statuses = new List<Status>();
                    while (dataReader.Read())
                    {
                        Status status = new Status();
                        status.ID = dataReader["ID"].ToString();
                        status.statusName = dataReader["statusName"].ToString();
                        statuses.Add(status);
                    }
                }
            }
        }

        // Methods for table: PriorityList
        // Read
        public static void ReadAllPriorities()
        {
            string query = "SELECT * FROM PriorityList";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    priorities = new List<Priority>();

                    while (dataReader.Read())
                    {
                        Priority priority = new Priority();
                        priority.ID = dataReader["ID"].ToString();
                        priority.priorityName = dataReader["priorityName"].ToString();
                        priorities.Add(priority);
                    }
                }
            }
        }

        // Methods for table: Team
        //Create
        public static void CreateTeam(Team team)
        {
            string query = "INSERT INTO Team " +
                           "VALUES(@TeamName, @ManagerID)";

            string reseedquery = "DECLARE @Max int " +
                                 "SELECT @Max = MAX([ID]) FROM[Team]" +
                                 "IF @Max IS NULL " +
                                    "SET @Max = 0 " +
                                 "dbcc CHECKIDENT('[Team]', RESEED, @Max)";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("TeamName", SqlDbType.VarChar, 255).Value = team.TeamName;
                command.Parameters.Add("ManagerID", SqlDbType.Int).Value = team.ManagerID;
                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException exception) when (exception.Number == 2627) // Primary key violation, cannot insert duplicate key.
                {
                    command.CommandText = reseedquery + " " + query;
                    command.ExecuteNonQuery();
                    TeamDeleteCount = 0;
                }
            }
        }

        // Read
        public static void ReadAllTeams()
        {
            string query = "SELECT * FROM Team";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    teams = new List<Team>();
                    while (dataReader.Read())
                    {
                        Team team = new Team();
                        team.ID = dataReader["ID"].ToString();
                        team.TeamName = dataReader["teamName"].ToString();
                        team.ManagerID = dataReader["managerID"].ToString();
                        teams.Add(team);
                    }
                }
            }
        }

        //Update
        public static void UpdateTeam(Team team)
        {
            string query = "UPDATE Team " +
                           "SET teamName = @TeamName, managerID = @ManagerID " +
                           "WHERE ID = @TeamID";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("TeamName", SqlDbType.VarChar, 255).Value = team.TeamName;
                command.Parameters.Add("ManagerID", SqlDbType.Int).Value = team.ManagerID;
                command.Parameters.Add("TeamID", SqlDbType.Int).Value = team.ID;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void UpdateTeamManager(string employeeID, string teamID)
        {
            string query = "UPDATE Team " +
                           "SET managerID = " + employeeID + " " +
                           "WHERE ID = " + teamID;
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //Delete
        public static void DeleteTeam(Team team)
        {
            TeamDeleteCount += 1;
            string query = "DELETE FROM Team " +
                           "WHERE ID = @TeamID " +
                           "DBCC CHECKIDENT('[Team]', RESEED, @NewSeed)";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("TeamID", SqlDbType.Int).Value = team.ID;
                command.Parameters.Add("NewSeed", SqlDbType.Int).Value = Convert.ToInt32(team.ID) - TeamDeleteCount;
                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException exception) when (exception.Number == 547) // Statement conflicted with foreign key constraint.
                {
                    System.Windows.Forms.MessageBox.Show("You can only delete an empty team.");
                }
            }
        }

        // Method for table: Employee
        //Create

        public static void CreateEmployee(Employee employee)
        {
            string query = "INSERT INTO Employee " +
                           "VALUES(@FirstName, @LastName, @TeamID)";

            string reseedquery = "DECLARE @Max int " +
                                 "SELECT @Max = MAX([ID]) FROM[Employee]" +
                                 "IF @Max IS NULL " +
                                    "SET @Max = 0 " +
                                 "dbcc CHECKIDENT('[Employee]', RESEED, @Max)";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("FirstName", SqlDbType.VarChar, 255).Value = employee.FirstName;
                command.Parameters.Add("LastName", SqlDbType.VarChar, 255).Value = employee.LastName;
                command.Parameters.Add("TeamID", SqlDbType.Int).Value = employee.TeamID;
                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException exception) when (exception.Number == 2627) // Primary key violation, cannot insert duplicate key.
                {
                    command.CommandText = reseedquery + " " + query;
                    command.ExecuteNonQuery();
                    EmployeeDeleteCount = 0;
                }
            }
        }
    

        // Read
        public static void FillTeams()
        {
            string query = "SELECT * FROM Employee " +
                           "WHERE teamID = @TeamID";
            SqlParameter teamID = new SqlParameter("TeamID", SqlDbType.Int);
            sortedEmployees = new List<List<Employee>>();

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.Add(teamID);
                foreach (Team team in teams)
                {
                    teamID.Value = team.ID;
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        List<Employee> teamMembers = new List<Employee>();
                        while (dataReader.Read())
                        {
                            Employee member = new Employee();
                            member.ID = dataReader["ID"].ToString();
                            member.FirstName = dataReader["firstName"].ToString();
                            member.LastName = dataReader["lastName"].ToString();
                            member.TeamID = dataReader["teamID"].ToString();
                            teamMembers.Add(member);
                        }
                        sortedEmployees.Add(teamMembers);
                    }
                }
            }
        }

        public static void ReadAllEmployees()
        {

            string query = "SELECT * FROM Employee";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    employees = new List<Employee>();
                    while (dataReader.Read())
                    {
                        Employee employee = new Employee();
                        employee.ID = dataReader["ID"].ToString();
                        employee.FirstName = dataReader["firstName"].ToString();
                        employee.LastName = dataReader["lastName"].ToString();
                        employee.TeamID = dataReader["lastName"].ToString();
                        employees.Add(employee);
                    }
                }
            }

        }

        //Update
        public static void UpdateEmployee(Employee employee)
        {
            string query = "UPDATE Employee " +
                           "SET firstName = @FirstName, lastName = @LastName, teamID = @TeamID " +
                           "WHERE ID = @TeamID";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("FirstName", SqlDbType.VarChar, 255).Value = employee.FirstName;
                command.Parameters.Add("LastName", SqlDbType.VarChar, 255).Value = employee.LastName;
                command.Parameters.Add("TeamID", SqlDbType.Int).Value = employee.TeamID;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void ChangeEmployeeTeam(string teamID, string employeeID)
        {
            string query = "UPDATE Employee " +
                           "SET teamID = " + teamID + " " +
                           "WHERE ID = " + employeeID; ;
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //Delete
        public static void DeleteEmployee(Employee Employee)
        {
            TeamDeleteCount += 1;
            string query = "DELETE FROM Employee " +
                           "WHERE ID = @EmployeeID " +
                           "DBCC CHECKIDENT('[Employee]', RESEED, @NewSeed)";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("EmployeeID", SqlDbType.Int).Value = Employee.ID;
                command.Parameters.Add("NewSeed", SqlDbType.Int).Value = Convert.ToInt32(Employee.ID) - TeamDeleteCount;
                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException exception) when (exception.Number == 547) // Statement conflicted with foreign key constraint.
                {
                    System.Windows.Forms.MessageBox.Show("Employee must neither be manager of a team nor working on a ticket.");
                }
            }
        }
    }
}
