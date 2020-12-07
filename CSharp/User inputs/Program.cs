using System;

namespace MyFirstProject
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string Name = Console.ReadLine();
            //data type variable name = value of the variable
            Console.WriteLine("Hello:" + Name);
            //printing string and variables  is known as string concatination
            //console.readkey-also we used to display output from user keyboard the console unddile get the input from eyboard.
            Console.WriteLine("Hello {0}", Name);   //here the name is replaced with {0} this value.
            //string interpolation
            Console.WriteLine($"Hello {Name}");
            Console.ReadKey();

        }
    }
}