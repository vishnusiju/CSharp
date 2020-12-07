using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConcurrentCollections
{
    class CurentS
    {
        public void ConCuQ()
        {
            Console.WriteLine("ConCurrentQueue");
            ConcurrentStack<int> numberCollection = new ConcurrentStack<int>();
            for (int i = 10; i <= 20; i++)
            {
                numberCollection.Push(i);
            }

            Parallel.For(0, 10, i =>
            {
                int value = 0;
                if (numberCollection.TryPop(out value))
                    Console.WriteLine("Value {0} is popped out!", value);
            });
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(1);
            stack.Push(2);

            int item;
            bool isSuccess = stack.TryPeek(out item);
            Console.WriteLine(isSuccess); //Print True
            Console.WriteLine(item); //Print 2

            isSuccess = stack.TryPeek(out item);
            Console.WriteLine(isSuccess); //Print True
            Console.WriteLine(item); //Print 2

            Console.ReadLine();
        }
    }
}


