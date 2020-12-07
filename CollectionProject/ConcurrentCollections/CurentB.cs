using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;

namespace ConcurrentCollections
{
    class CurentB
    {
        private static object _entityCollection;

        public void ConCuB()
        {
            ConcurrentBag<string> concurrentBags = new ConcurrentBag<string>();
            static ConcurrentBag<string> _entityCollection = concurrentBags;
            _entityCollection.Add("Company1");
            _entityCollection.Add("Catalog1");
            _entityCollection.Add("Order1");
            _entityCollection.Add("Company2");
            _entityCollection.Add("Catalog2");
            _entityCollection.Add("Order2");
            _entityCollection.Add("Company3");
            _entityCollection.Add("Catalog3");
            _entityCollection.Add("Order3");

            ThreadStart threadStart = new ThreadStart(PrintEntities);
            Thread thread1 = new Thread(threadStart);
            thread1.Start();
            Thread thread2 = new Thread(threadStart);
            thread2.Start();

            Console.ReadLine();
        }

        static void PrintEntities()
        {
            string entity = String.Empty;
            while (_entityCollection.TryPeek(out entity))
            {
                if (_entityCollection.TryTake(out entity))
                    Console.WriteLine(entity);
            }
        }
    }
}




// ConcurrentBag is a thread-safe collection class.
//  ConcurrentBag allows you to store objects in unordered way.
//  it allows you to store duplicate objects.
//  ConcurrentBag allows multiple threads to store the objects.
// the same thread act as producer and consumer. That means same thread is adding and retrieving the data.
// TryTake method returns one item from the bag and removes that item from the bag.



