using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_app.Models
{
    public class Officer
    {
        public string Name { get; set; }
        public string Policeid { get; set; }
        [Key]
        public string NIC { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int Mobile { get; set; }
       public int HomePhone { get; set; }
        public string PoliceDivision { get; set; }
    }
}
