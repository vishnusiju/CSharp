using System;
using System.Collections.Generic;
using System.Text;

namespace InheritenceExample
{
    class animal
    {
        public void dog()
        {
            Console.WriteLine("Dog");
        }
    }
    class Bird:animal
    {
        public void hen()
        {
            Console.WriteLine("HEN");
        } 
    }
}
