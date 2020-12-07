//using System;

//namespace taskks
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

using System;
using System.Collections.Generic;

namespace generic_collectio
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name = "No Name")
        {
            Name = name;

        }
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();


            animalList.Add(new Animal() { Name = "Lion" });
            animalList.Add(new Animal() { Name = "tig" });


            animalList.Insert(1, new Animal() { Name = "cccc" });


            Console.WriteLine("No of animals:{0},animalList.Count()");
            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }
        }
    }
}
