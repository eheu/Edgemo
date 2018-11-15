using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgemoTicketSystem
{
    public class Ticket
    {
        public string ID { get; set; } // Auto-generated.
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Log { get; set; }
        public string StartDate { get; set; } 
        public string EndDate { get; set; }
        public string IsOverdue { get; set; } // Auto-calculated.
        public string StatusID { get; set; }
        public string StatusName { get; set; }
        public string PriorityID { get; set; }
        public string PriorityName { get; set; }
        public string TeamID { get; set; }
        public string TeamName { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string ManagerID { get; set; }
        public string ManagerName { get; set; }
        public string SourceID { get; set; } // Redundant (always 1).
        public string SourceName { get; set; } // Redundant (always "tlf").
        public string OrderID { get; set; }
    }
}
