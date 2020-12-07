using System;

using System.Collections.Generic;
using System.Text;
using Threading;


namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread obj1 = new Thread(Function1);
            Thread obj2 = new Thread(Function2);
            obj1.start();
            obj2.start();
        }
        static void Function1()
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("the function 1 executed" + i.ToString());
            }
        }

        static void Function2()
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("the function 2 executed" + i.ToString());
            }
        }
    }
}
