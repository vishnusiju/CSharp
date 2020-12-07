using System;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace DelegateAppl
{

    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        // delegate declaration
        public delegate void printString(string s);

        // this method prints to the console
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        //this method prints to a file
        public static void WriteToFile(string s)
        {
        //  the message is write to the location.
            fs = new FileStream("C:\\Users\\VISHNU SIJU\\delegate\\message.txt",
            FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        // this method takes the delegate as parameter and uses it to
        // call the methods as required
        public static void sendString(printString ps)
        {
            ps("Hello World");
        }

        static void Main(string[] args)
        {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);
            Console.ReadKey();
        }
    }
    // ====OUTPUT=====
    // The String is: Hello World

    // ===========================
}



//namespace EventsAndDelegates
//{
//	//There are three types of delegates that can be used in C#.
//	//1.Single Delegate.
//	//2.Multicast Delegate.
//	//3.Generic Delegate.

//	// Delegates are used to pass methods as arguments to other methods.



//	public delegate void MyDelegate(string msg);

//	public class SimpleDelegate
//	{
//		public static void Main(string[] args)
//		{
//			MyDelegate del = ClassA.MethodA;
//			del("Hello World");

//			del = ClassB.MethodB;
//			del("Hello World");

//			del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
//			del("Hello World");

//		}



//		public class ClassA
//		{
//			public static void MethodA(string message)
//			{
//				Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
//			}
//		}

//		public class ClassB
//		{
//			public static void MethodB(string message)
//			{
//				Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
//			}
//		}
//	}


//}



//Delegates allow methods to be passed as parameters.

//Delegates can be used to define callback methods.

//Delegates can be chained together; for example, multiple methods can be called on a single event.

















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