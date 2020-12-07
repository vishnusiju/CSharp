using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConcurrentCollections
{
    class CurentD
    {
        public void ConCuD()
        {
                Console.WriteLine("ConcurrentDictionary");
                //Consider this as a list from database which is huge and we need to represent this data as a keyvalue pair using ConcurrentDictionary
                string[] techWebSites = new string[] { "www.codeguru.com", "www.internet.com", "www.devx.com", "www.developer.com" };

                Task[] taskList = new Task[2];

                ConcurrentDictionary<int, string> dictionaryWebsites = new ConcurrentDictionary<int, string>();

                //With the creation of two tasks we have divided the load of populating the collection byt without doing any explicit synchronization
                taskList[0] = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < techWebSites.Length; i++)
                    {
                        if (dictionaryWebsites.TryAdd(i, techWebSites[i]))
                            Console.WriteLine("Website {0} added to the dictionary!", techWebSites[0]);
                    }
                });

                taskList[1] = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < techWebSites.Length; i++)
                    {
                        if (dictionaryWebsites.TryAdd(i, techWebSites[i]))
                            Console.WriteLine("Website {0} added to the dictionary!", techWebSites[0]);
                    }
                });

             // Retrieve all items in ConcurrentDictionary
                ConcurrentDictionary<string, string> dict = new ConcurrentDictionary<string, string>();
             // AddValues   
                bool firstItem = dict.TryAdd("1", "First");
                bool secondItem = dict.TryAdd("2", "Second");
                bool thirdItem = dict.TryAdd("3", "third");
                bool fourthItem = dict.TryAdd("4", "fourth");


                string itemValue1;
                string itemValue2;
                string itemValue3;
                string itemValue4;
            // RetriveValues
                bool isItemExists1 = dict.TryGetValue("1", out itemValue1);  //returns true
                Console.WriteLine(itemValue1); //Print "First"
 
                bool isItemExists2 = dict.TryGetValue("5", out itemValue2);  //returns false
                Console.WriteLine(itemValue2); //Print blank

            // UpdateValues
                bool returnTrue = dict.TryUpdate("3", "New Value", "First"); //Returns true
                dict.TryGetValue("1", out itemValue1);
                Console.WriteLine(itemValue1); //Print "New Value"

            // RemoveValues
                string removedItem;
                bool result = dict.TryRemove("4", out removedItem); //Returns true
                Console.WriteLine(removedItem); //Print "Fourth"

                Task.WaitAll();
                Console.ReadKey();

            
        }
    }
}

// System.Collections.Concurrent namespace.
// ConcurrentDictionary is thread-safe collection class to store key/value pairs. 
//    ConcurrentDictionary can be used with multiple threads concurrently. 
// ConcurrentDictionary uses different methods to add, retrieve, update and remove items.
// threadsafe-when we using the multithreading, threding concept will repeat the access,
//    so that threadsafe will prevent this mistakes.




