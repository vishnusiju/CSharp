using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication9
{
    class Program
    {
        static void Main(String[] args)
        {
            using (CodeFirstContext context = new CodeFirstContext())
            {
                Department dept = new Department()
                {
                    Dep = "Physics",
                    Students = new List<Student>
                    {
                        new Student(){Name = "AnilL"},
                        new Student(){Name = "imane"}

                    }
                };

                context.Departments.Add(dept);
                context.SaveChanges();
                Console.WriteLine("Data entered successfully");
                Console.ReadKey();
            }

        }
    }
}
//namespace CodeFirstDemo1
//{
//    public class Post
//    {
//        public int Id { get; set; }
//        public DateTime DatePublised { get; set; }
//        public string Title { get; set; }
//        public string body { get; set; }
//    }

//    public class BlogDbContext : DbContext
//    {
//        public DbSet<Post> Posts { get; set; }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}
