using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_app.Models
{
    public class FireArm
    {
        public string Model { get; set; }
        [Key]
        public string SerialNo { get; set; }
        [Column(TypeName="date")]
        public DateTime LastUsed { get; set; }
        [Column(TypeName = "date")]
        public DateTime LastServiced { get; set; }
        public int NewBullets { get; set; }
        public int FiredBullets { get; set; }
        public int BalanceBullets { get; set; }
        public string Notes { get; set; }
    }
}
