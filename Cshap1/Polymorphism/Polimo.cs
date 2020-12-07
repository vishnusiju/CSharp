using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("THE ANIMAL MAKE SOUND");
            
            
        }
    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Enter pig says: ");
            string say = Console.ReadLine();
            Console.WriteLine("Pig say: " + say);
        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Enter dog say: ");
            string say = Console.ReadLine();
            Console.WriteLine("Dog say: " + say);
        }
    }
}
