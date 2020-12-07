using System;

namespace EventsAndDelegates
{

    public partial class Program
	{
        public class ClassA
			{
				public static void MethodA(string message)
				{
					Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
				}
			}

		}
	
}


















//    class SimpleDelegates
//    {

//            myDel del = new myDel(Add);
//            int result = del(10, 20);



//        delegate int myDel Add(int x, int y)
//        class delida
//        {
//            Public static int Add(int x, int y)
//            {
//                return x + y;
//            }
//            Public static in multiply(int x, int y);
//            {
//                return x* y;
//        }
//    }
//}
//}


//the delegates holds the referance of a methods and then calls the method for execution.