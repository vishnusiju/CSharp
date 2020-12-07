using System;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;


namespace asyncawait
{
    // AsynchronousProgramming
    class Program
    {
        static async Task Main(string[] args)
        {
            string cup = PourCoffee();

            Console.WriteLine("coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var allTasks = new List<Task> { eggsTask, baconTask, toastTask };

            while (allTasks.Any())
            {
                Task finished = await Task.WhenAny(allTasks);
                if (finished == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finished == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finished == toastTask)
                {
                    Console.WriteLine("toast is ready");
                }


                allTasks.Remove(finished);
            }

            Console.WriteLine("Breakfast is ready!");

            async Task<string> MakeToastWithButterAndJamAsync(int number)
            {
                var toast = await ToastBreadAsync(number);
                return toast;
            }
        }

        static void ttt()
        {
            Console.WriteLine(Thread.CurrentThread.Name + ": " + (10281.834483255407).ToString());
        }

        static int hardloop()
        {
            for (var i = 0; i < 10000; i++) { }
            return 0;
        }

        static string PourCoffee()
        {
            int i = hardloop();
            return "coffe";
        }

        static string PourOJ()
        {
            int i = hardloop();
            return "OJ";
        }

        static async Task<string> FryEggsAsync(int i)
        {
            int j = 0;
            await Task.Run(() => { j = hardloop(); });
            return "egg";
        }

        static async Task<string> FryBaconAsync(int i)
        {
            int j = 0;
            await Task.Run(() => { j = hardloop(); });
            return "bacon";
        }

        static async Task<string> ToastBreadAsync(int i)
        {
            int j = 0;
            await Task.Run(() => { j = hardloop(); });
            return "toast";
        }
    }
}

////OUTPUT
//    // coffee is ready
//    // eggs are ready
//    // bacon is ready
//    // toast is ready
//    //Breakfast is ready!





////  WhenAll:-, which returns a Task that completes when all the tasks in its argument list have completed,
////  WhenAny:-, which returns a Task<Task> that completes when any of its arguments completes. 



//namespace AsyncBreakfast
//{
//    class Program
//    {
//        static async Task Main(string[] args)
//        {
//            Coffee cup = PourCoffee();
//            Console.WriteLine("coffee is ready");

//            var eggsTask = FryEggsAsync(2);
//            var baconTask = FryBaconAsync(3);
//            var toastTask = MakeToastWithButterAndJamAsync(2);

//            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
//            while (breakfastTasks.Count > 0)
//            {
//                Task finishedTask = await Task.WhenAny(breakfastTasks);
//                if (finishedTask == eggsTask)
//                {
//                    Console.WriteLine("eggs are ready");
//                }
//                else if (finishedTask == baconTask)
//                {
//                    Console.WriteLine("bacon is ready");
//                }
//                else if (finishedTask == toastTask)
//                {
//                    Console.WriteLine("toast is ready");
//                }
//                breakfastTasks.Remove(finishedTask);
//            }

//            Juice oj = PourOJ();
//            Console.WriteLine("oj is ready");
//            Console.WriteLine("Breakfast is ready!");
//        }

//        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
//        {
//            var toast = await ToastBreadAsync(number);
//            ApplyButter(toast);
//            ApplyJam(toast);

//            return toast;
//        }

//        private static Juice PourOJ()
//        {
//            Console.WriteLine("Pouring orange juice");
//            return new Juice();
//        }

//        private static void ApplyJam(Toast toast) =>
//            Console.WriteLine("Putting jam on the toast");

//        private static void ApplyButter(Toast toast) =>
//            Console.WriteLine("Putting butter on the toast");

//        private static async Task<Toast> ToastBreadAsync(int slices)
//        {
//            for (int slice = 0; slice < slices; slice++)
//            {
//                Console.WriteLine("Putting a slice of bread in the toaster");
//            }
//            Console.WriteLine("Start toasting...");
//            await Task.Delay(3000);
//            Console.WriteLine("Remove toast from toaster");

//            return new Toast();
//        }

//        private static async Task<Bacon> FryBaconAsync(int slices)
//        {
//            Console.WriteLine($"putting {slices} slices of bacon in the pan");
//            Console.WriteLine("cooking first side of bacon...");
//            await Task.Delay(3000);
//            for (int slice = 0; slice < slices; slice++)
//            {
//                Console.WriteLine("flipping a slice of bacon");
//            }
//            Console.WriteLine("cooking the second side of bacon...");
//            await Task.Delay(3000);
//            Console.WriteLine("Put bacon on plate");

//            return new Bacon();
//        }

//        private static async Task<Egg> FryEggsAsync(int howMany)
//        {
//            Console.WriteLine("Warming the egg pan...");
//            await Task.Delay(3000);
//            Console.WriteLine($"cracking {howMany} eggs");
//            Console.WriteLine("cooking the eggs ...");
//            await Task.Delay(3000);
//            Console.WriteLine("Put eggs on plate");

//            return new Egg();
//        }

//        private static Coffee PourCoffee()
//        {
//            Console.WriteLine("Pouring coffee");                            
//            return new Coffee();
//        }
//    }
//}