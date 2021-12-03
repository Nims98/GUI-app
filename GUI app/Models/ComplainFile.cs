using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_app.Models
{
   public class ComplainFile
    {   public int ComplainFileID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string NIC { get; set; }
        public int Telephone { get; set; }
        public string PoliceDivision { get; set; }
        public string ComplainText { get; set; }
    }
}
