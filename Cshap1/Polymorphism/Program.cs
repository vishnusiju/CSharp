using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Pig myPig = new Pig();
            Dog myDog = new Dog();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

        }
    }
}
