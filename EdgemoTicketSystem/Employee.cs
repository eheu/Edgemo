using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgemoTicketSystem
{
    public class Employee
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string fullName => FirstName + " " + LastName; //C# 6.0 Expression-bodied Members
        public string TeamID { get; set; }

        public override string ToString()
        {
            return FirstName;
        }
    }
}
