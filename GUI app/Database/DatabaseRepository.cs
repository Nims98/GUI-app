using GUI_app.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_app.Database
{
    class DatabaseRepository : DbContext
    {
        public DbSet<Officer> Officers { get; set; }
    }
}
