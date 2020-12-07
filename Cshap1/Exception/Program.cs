using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ExceptionHandiling
{
    class Cexception
    {
        public void Display()
        {

            try //while executing,define a block of code tested for error.
            {
                Console.WriteLine("Enter the 1st number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the 2nd number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);

            }
            //to define block of code to be executed.
            catch (DivideByZeroException e) //DivideByZeroException
            {
                Console.WriteLine(e.Message);

            }
            catch (FormatException e) //FormatException
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("EXECUTED");
            }   
        }
        
        //FileNotFoundException
        //TimeOutException


        //int[] myNumbers = { 1, 2, 3 };    (-IndexOutOfRangeException-)
        //Console.WriteLine(myNumbers[10]);


        public void DisplayThrow(int age)
        {
            if (age > 18)
            {
                //ArithmeticException
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
            static void Main(string[] args)
            {
                Cexception exp = new Cexception();
                exp.Display();
                exp.DisplayThrow(16);

            }

    }
}
