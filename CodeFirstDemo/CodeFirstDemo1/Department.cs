using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9     //CodeFirstDemo1
{
    class Department
    {
        public int DepartmentId { get; set; }

        public string Dep { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
