using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Employee : Person
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public void IntroduceSelf()
        {
            Console.WriteLine($"Hello my name is {Name} and my id is {ID}");
        }
    }
}
