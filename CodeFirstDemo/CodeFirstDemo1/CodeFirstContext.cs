using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication9
{
    class CodeFirstContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Department> Departments { get; set; }

    }
}
