using System;
using Csharpbasics;

namespace Csharpbasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the inputs");
            string Name = Console.ReadLine();
            Console.WriteLine("hello: " + Name); //string concatination
            Console.WriteLine("hello {0}", Name); //composite formating
            Console.WriteLine($"helo  {Name}"); //sting interpolaton

            Console.WriteLine(Name[1]);


            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            string s4 = "hello  \"hello\"";
            Console.WriteLine(s4);

            string s1 = "c:\\kdfkfkjda\\bkfbkdbf\\hfg.txt";
            Console.WriteLine(s1);


            string s2 = @"c:\\kdfkfkjda\\bkfbkdbf\\hfg.txt";
            Console.WriteLine(s2);

            Console.WriteLine(Name.Length);
            Console.WriteLine(Name.ToLower());
            Console.WriteLine(Name.ToUpper());







        }
    }
}




//{
//    class Program
//    {
       
     
//        static void Main(string[] args)
//        {
//            Class2 xyz = new Class2();
//            xyz.abc();
//            string firstName = "John ";
//            string lastName = "Doe";
//            string fullName = firstName + lastName;
//            Console.WriteLine(fullName); 
            


//        }
//    }
//}
