using System;
//object oriented programming
//1.inheritance
//2.polymorphism
//3.abstraction
//4.encapsulation
namespace Inheritance
{
    using System;
    // Creating a simple Calculator class
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class CalCulator
    {
        // Square function
        public int Square(int num)
        {
            return num * num;
        }
        // Add two integers and returns the sum
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        // Add two integers and returns the sum
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        // Multiply two integers and retuns the result
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        // Subtracts small number from big number
        public int Subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            return num2 - num1;
        }
    }
    // This shows how to use CalCulator class from Main C# program.
    public class Class1
    {
        static void Main()
        {
            CalCulator sq = new CalCulator();
            Console.WriteLine(sq.Square(8).ToString());
            Console.WriteLine(sq.Add(8.3, 9.24).ToString());
            Console.WriteLine(sq.Multiply(5, 8).ToString());
            Console.WriteLine(sq.Subtract(22, 42).ToString());
        }
    }
}
