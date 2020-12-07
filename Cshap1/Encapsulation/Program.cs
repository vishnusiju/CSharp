using System;

namespace MyApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Vishnu";
            Console.WriteLine(myObj.Name);
        }
    }
}