using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class CalCulator
    {
        // All calculation solve here
        public int Square(int num)
        {
            return num * num;

        }
        public int Add(int num1, int num2)
        {
            return num1 + num2;

        }
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public int Multiply(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            return num2 - num1;
        }
    }
    public class Inherit
    {
        // data members 
        public string name;
        public string subject;

        // public method of base class  
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }

    // inheriting the inherit class using :  
    class GeeksforGeeks : Inherit
    {

        // constructor of derived class 
        public GeeksforGeeks()
        {
            Console.WriteLine("GeeksforGeeks");
        }
    }
}

