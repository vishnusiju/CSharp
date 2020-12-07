using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConcurrentCollections
{
    class CurentQ
    {
        public void currQ()
        {
            ConcurrentQueue<string> nameCollection = new ConcurrentQueue<string>();
            nameCollection.Enqueue("Adam Hollioke");
            nameCollection.Enqueue("Ben Hollioke");
            nameCollection.Enqueue("Ronie Irani");
            nameCollection.Enqueue("Patrick");
            nameCollection.Enqueue("Stuart Clarke");
            nameCollection.Enqueue("Mike Gatting");

            Task[] taskList = new Task[2];
         //     TryDequeue
            taskList[0] = Task.Factory.StartNew(() =>
            {
                string name = String.Empty;
                while (nameCollection.TryDequeue(out name))
                    Console.WriteLine("Name {0} is dequeued!", name);
            });

         // TryPeek
            taskList[1] = Task.Factory.StartNew(() =>
            {
                string name = String.Empty;
                while (nameCollection.TryPeek(out name))
                    Console.WriteLine("Name {0} is TryPeek!", name);
            });
            
        }
    }
}


// 

// it is not safe to use with multi-threading environment. 
// To provide thread-safety, we have to implement locking around Queue methods which is always error prone.

//TryPeek - method tries to get an item from the ConcurrentQueue without removing item from the list. 
//     It returns true if operation is successful otherwise returns false.
// TryDequeue - method tries to get an item from the ConcurrentQueue, but it removes item from the list. 
//     It also returns true if operation is successful other returns false.


//int item;

//ConcurrentQueue<int> coll = new ConcurrentQueue<int>();
//coll.Enqueue(1);
//coll.Enqueue(2);
//coll.Enqueue(3);
//coll.Enqueue(4);

//coll.TryPeek(out item); //returns "1"
//coll.TryPeek(out item); //returns "1"
//Console.WriteLine();

//Task.WaitAll();
//Console.ReadLine();
//-----------------------------

//// int count = coll.Count();
//// isEmpty = coll.IsEmpty;







