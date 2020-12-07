using inheritance;
using System;
using System.Collections.Generic;



namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> emps = new List<Person>();

            Student s = new Student();
            s.Name = "names";
            s.Age = 30;
            s.GradeLevel = 0;

            Employee e = new Employee();
            e.Name = "nameas";
            e.Age = 40;
            e.GradeLevel = 9;

            emps.Add(s);
            emps.Add(e);

            foreach (Person p in emps)
            {
                if (p is Student)
                {
                    Student temp = p as Student;
                    Console.WriteLine(temp.GradeLevel);
                }
                else if (p is Employee)
                {
                    Employee temp = p as Employee;
                    Console.WriteLine(temp.ID);
                }
            }
        }
    }
}

