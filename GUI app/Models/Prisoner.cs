using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_app.Models
{
   public class Prisoner
    {
        public int PrisonerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string NIC { get; set; }
        public int Mobile { get; set; }
        public int HomePhone { get; set; }

        public string Crime { get; set; }
        public string MoreInfo { get; set; }
    }
}
