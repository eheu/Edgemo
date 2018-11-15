using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightIdeasSoftware;
using System.Windows.Forms;
using System.Globalization;

namespace EdgemoTicketSystem
{
    // Search/filter functionality
    class AspectFilter : IModelFilter
    {
        public string Aspect { get; set; }
        public string Input { get; set; }

        public AspectFilter(string aspect, string input)
        {
            Aspect = aspect;
            Input = input;
        }

        public bool Filter(object modelObject)
        {
            switch(Aspect)
            {
                //Using case-insensitive alternative to string.Contains, see: https://stackoverflow.com/a/15464440
                case "Subject":
                    return CultureInfo.InvariantCulture.CompareInfo.IndexOf(((Ticket)modelObject).Subject, Input, CompareOptions.IgnoreCase) >= 0;
                case "Description":
                    return CultureInfo.InvariantCulture.CompareInfo.IndexOf(((Ticket)modelObject).Description, Input, CompareOptions.IgnoreCase) >= 0;
                default:
                    return true;
            }
        }
    }
}
