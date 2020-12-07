using System;
using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DemoApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ArrayList a1 = new ArrayList();
//            a1.Add(1);
//            a1.Add("Example");
//            a1.Add(true);

//            Console.WriteLine(a1[0]);
//            Console.WriteLine(a1[1]);
//            Console.WriteLine(a1[2]);
//            Console.ReadKey();
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;


namespace ConsoleApp1
{
    class Program
    {
        //static char ShowMenu()
        //{
        //    Console.WriteLine("\nEnter the letter of operation: \n(o)Print, (s)Search, (i)Insertion, (d)Deletion, (u)Update, (e)Exit\n");
        //    return char.Parse(Console.ReadLine());
        //}
        static void Main(string[] args)
        {
            //char sel = ' ';
            Console.Write("Enter number of Employees; ");
            int i = 0;
            int s = int.Parse(Console.ReadLine());

            while (i < s)
            {


                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Enter id: ");
                int _id = int.Parse(Console.ReadLine());


                Console.WriteLine("");
                Console.WriteLine("Enter Name: ");
                string nm = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Enter Salary: ");
                double sal = int.Parse(Console.ReadLine());

                EmployeeArray arr = new EmployeeArray(s, _id, nm, sal);


                i++;
            }



        }
    }
}

//========================================







