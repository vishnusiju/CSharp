using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Departments { get; set; }
    }
}
