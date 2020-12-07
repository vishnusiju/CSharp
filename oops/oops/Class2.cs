using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class Class1 //parent class
    {
        public void Method1()
        {
            Console.WriteLine("method1 from class2");
        }
    }
    class Class2 : Class1 //class3 is a child class
    {
        public void Method2()
        {
            Console.WriteLine("method2 from class2");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();
            obj1.Method1();
            obj2.Method2();
        }
    }
}


