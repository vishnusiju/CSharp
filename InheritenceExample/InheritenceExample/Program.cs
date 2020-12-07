using System;

namespace InheritenceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            animal an = new animal();
            Bird br = new Bird();
            an.dog();
            br.hen();
            br.dog();
            Console.ReadKey();

        }
    }
}
