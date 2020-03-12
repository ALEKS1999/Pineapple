using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Pineapple
{
    public class SchoolContext : DbContext
    {
        public SchoolContext():base("")
        {

        }
        // Entities        
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Periphery> Periphery { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
}
