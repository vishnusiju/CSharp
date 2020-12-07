using System;

namespace CustomExceptionInCshap
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            try
            {
                int res = checkAge();
                Console.WriteLine(res);
                Console.ReadLine();
            }
            catch (CustomAge ag)
            {
                Console.WriteLine(ag.Message);

            }
        }
        //create a method
        static int checkAge()
        {
            Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age > 18)
            {
                throw new Exception("Age should be above 18");

            }
            return age;

            
        }
    }
    public class CustomAge : Exception
    {
        //create constructor customage
        //pass the parameter msg
        //base class msg
        public CustomAge(string msg) : base(msg)
        {

        }
    }

}
