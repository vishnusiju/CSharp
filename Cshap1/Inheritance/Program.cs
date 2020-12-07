using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{    
    public class Program
    {
        static void Main(string[] args)
        {
                // Calculator function will call here
                CalCulator sq = new CalCulator();
                Console.WriteLine(sq.Square(8).ToString());
                Console.WriteLine(sq.Add(8.3, 9.4).ToString());
                Console.WriteLine(sq.Multiply(5,8).ToString());
                Console.WriteLine(sq.Subtract(22, 42).ToString());

                // creating object of derived class 
                GeeksforGeeks g = new GeeksforGeeks();

                // calling the method of base class  
                // using the derived class object 
                g.readers("Vishnu", "C#");
        }
    }
}
