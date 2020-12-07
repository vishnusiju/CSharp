using System;

namespace Abstraction
{
    abstract class Animal
    {
        public abstract void Animalsound();

        public void sleep()
        {
            Console.WriteLine("zzzz");
        }
    }
    class pig : Animal
    {
        public override void Animalsound()
        {
            Console.WriteLine("gufufu uuyuyg ugugu");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            pig myPig = new pig();
            myPig.Animalsound();
            myPig.sleep(); 
        }
    }
}