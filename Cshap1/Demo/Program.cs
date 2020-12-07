using System;

namespace polimorphism
{
    class Animal
    {
        public virtual void Animalsound()
        {
            Console.WriteLine("the parent animal says");
        }
    }
    class pig : Animal
    {
        public override void Animalsound()
        {
            Console.WriteLine("the pig say");
            string say = Console.ReadLine();
            Console.WriteLine("THE pig say: " + say);
        }
    }
    class dog : Animal
    {
        public override void Animalsound()
        {
            Console.WriteLine("the dog says");
            string say = Console.ReadLine();
            Console.WriteLine("the dog says" + say);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            pig myPig = new pig();
            dog myDog = new dog();

            myAnimal.Animalsound();
            myPig.Animalsound();
            myDog.Animalsound();

        }
    }
}