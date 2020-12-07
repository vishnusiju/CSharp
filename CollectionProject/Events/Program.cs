using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tutlane

{

    class Maths

    {

        // Declare the delegate

        public delegate void SampleDelegate();

        //Declare an event

        public event SampleDelegate SampleEvent;

        public void Add(int a, int b)

        {

            // Calling event delegate to check subscription

            if (SampleEvent != null)

            {

                // Raise the event by using () operator

                SampleEvent();

                Console.WriteLine("Add Result: {0}", a + b);

            }

            else

            {

                Console.WriteLine("Not Subscribed to Event");

            }

        }

        public void Subtract(int x, int y)

        {

            // Calling event delegate to check subscription

            if (SampleEvent != null)

            {

                // Raise the event by using () operator

                SampleEvent();

                Console.WriteLine("Subtract Result: {0}", x - y);

            }

            else

            {

                Console.WriteLine("Not Subscribed to Event");

            }

        }

    }

    class Operations

    {

        Maths m;

        public int a { get; set; }

        public int b { get; set; }

        public Operations(int x, int y)

        {

            m = new Maths();

            // Subscribe to SampleEvent event

            m.SampleEvent += SampleEventHandler;

            a = x;

            b = y;

        }

        // SampleEvent Handler

        public void SampleEventHandler()

        {

            Console.WriteLine("SampleEvent Handler: Calling Method");

        }

        public void AddOperation()

        {

            m.Add(a, b);

        }

        public void SubOperation()

        {

            m.Subtract(a, b);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("****Events Example****");

            Operations op = new Operations(10, 20);

            op.AddOperation();

            op.SubOperation();

            Console.ReadLine();

        }

    }

}
// ===OUTPUT===
//  ****Events Example****
//  SampleEvent Handler: Calling Method
//  Add Result: 30
//  SampleEvent Handler: Calling Method
//  Subtract Result: -10
// ==================================


//namespace event_programming
//{
//    //This is Subscriber Class
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            AddTwoNumbers a = new AddTwoNumbers();
//            //Event gets binded with delegates
//            a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
//            a.Add();
//            Console.Read();
//        }
//        //Delegates calls this method when event raised.  
//        static void EventMessage()
//        {
//            Console.WriteLine("********Event Executed : This is Odd Number**********");
//        }
//    }
//    //This is Publisher Class
//    class AddTwoNumbers
//    {
//        public delegate void dg_OddNumber(); //Declared Delegate     
//        public event dg_OddNumber ev_OddNumber; //Declared Events

//        public void Add()
//        {
//            int result;
//            result = 5 + 4;
//            Console.WriteLine(result.ToString());
//            //Check if result is odd number then raise event
//            if ((result % 2 != 0) && (ev_OddNumber != null))
//            {
//                ev_OddNumber(); //Raised Event
//            }
//        }
//    }
//}

//namespace Events
//{
//    public delegate string myDelegate(string str);

//    class EventProgram
//    {
//        event myDelegate newEvent;

//        public EventProgram()
//        {
//            this.newEvent += new myDelegate(this.WelcomeUser);   //subscribe(+=),unsubscribe(-=).
//        }

//        public string WelcomeUser(string username)
//        {
//            return "Welcome " + username;
//        }

//        static void Main(string[] args)
//        {
//            EventProgram obj1 = new EventProgram();
//            string result = obj1.newEvent("My Website!");
//            Console.WriteLine(result);
//        }
//    }
//}






//public class Program
//{
//    public static void Main()
//    {
//        ProcessBusinessLogic bl = new ProcessBusinessLogic();
//        bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
//        bl.StartProcess();
//    }

//    // event handler
//    public static void bl_ProcessCompleted()
//    {
//        Console.WriteLine("Process Completed!");
//    }
//}

//public delegate void Notify();  // delegate

//public class ProcessBusinessLogic
//{
//    public event Notify ProcessCompleted; // event

//    public void StartProcess()
//    {
//        Console.WriteLine("Process Started!");
//        // some code here..
//        OnProcessCompleted();
//    }


//    protected virtual void OnProcessCompleted()
//    {
//        ProcessCompleted?.Invoke();
//    }
//}



//The class that sends (or raises) the event is called the publisher and 
//the classes that receive (or handle) the event are called subscribers.


// The class who raises events is called Publisher, and the class who receives the notification 
//     is called Subscriber. There can be multiple subscribers of a single event.
//     Typically, a publisher raises an event when some action occurred. The subscribers,
//      who are interested in getting a notification when an action occurred, 
//     should register with an event and handle it.