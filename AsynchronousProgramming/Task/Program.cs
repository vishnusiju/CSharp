using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    // TASK
    class Program
    {
        static void Main(string[] args)
        {
            Action<object> action = (object obj) =>
                                     {
                                         Console.WriteLine("Task ={0}, obj={1}, Thread={2}",
                                          Task.CurrentId, obj,
                                          Thread.CurrentThread.ManagedThreadId);
                                     };
            // create a task but do not start it.
            Task t1 = new Task(action, "alpha");

            // construct a started task.
            Task t2 = Task.Factory.StartNew(action, "beta");
            // block the main thread to demonstrate that t2 is executing.
            t2.Wait();

            // luanch t1
            t1.Start();
            Console.WriteLine("t1 has been launched. (Main Thread={0})",
                                Thread.CurrentThread.ManagedThreadId);
            // wait for the task to finish
            t1.Wait();

            // constuct a started task using task.run
            string taskData = "delta";
            Task t3 = Task.Run(() =>
            {
                Console.WriteLine("Task={0}, obj={1}, thread={2}",
                                  Task.CurrentId, taskData,
                                  Thread.CurrentThread.ManagedThreadId);
            });
            //wait for the task to finish.
            t3.Wait();

            // construct an unstarted task
            Task t4 = new Task(action, "gamma");
            // run it synchronously
            t4.RunSynchronously();
            t4.Wait(); 


            //OUTPUT:-
            // The example displays output like the following:
            //       Task=1, obj=beta, Thread=3
            //       t1 has been launched. (Main Thread=1)
            //       Task=2, obj=alpha, Thread=4
            //       Task=3, obj=delta, Thread=3
            //       Task=4, obj=gamma, Thread=1





            // Task t = Task.Factory.StartNew(() =>
            //{
            //     //just loop
            //     int ctr = 0;
            //    for (ctr = 0; ctr <= 1000000; ctr++)
            //    { }
            //    Console.WriteLine("Finished {0} loop iterations", ctr);
            //});
            // t.Wait();

            //OUTPUT:-
            //Finished 1000001 loop iterations



            //Task taskA = Task.Run(() => Thread.Sleep(2000));
            //try
            //{
            //    taskA.Wait(1000);
            //    bool completed = taskA.IsCompleted;
            //    Console.WriteLine("Task A completed: {0}, Status: {1}",
            //                            completed, taskA.Status);
            //    if (!completed)
            //        Console.WriteLine("Timed out before task A completed.");

            //}
            //catch (AggregateException)
            //{
            //    Console.WriteLine("Exception in taskA.");
            //}

            //OUTPUT:-
            //Task A completed: false, status: running
            //timedout brfore task a completed
        }
    }
}



