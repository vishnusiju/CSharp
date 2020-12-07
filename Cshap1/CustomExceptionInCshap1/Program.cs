using System;
using System.Threading;

namespace user_defined_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int acceptorder;
            Console.WriteLine("Welcome to Shopping Site:\nHow many headphone you want to buy (Total 10 in Stock):");
            acceptorder = Convert.ToInt32(Console.ReadLine());
            try
            {
                //the acceptorder is maximum 10 by default
                if (acceptorder == 10 || acceptorder < 10) 
                {
                    Console.WriteLine("Congratulations! You have bought {0} headphones", acceptorder);
                    Console.ReadLine();
                }

                else
                {
                    throw (new OutofStockException("OutofStockException Generated: The number of item you want to buy is out of stock. Please enter total item number within stock"));
                }
            }
            catch (OutofStockException oex)
            {
                Console.WriteLine(oex.Message.ToString());

                Console.ReadLine();
            }

        }
    }

    //Creating Custome Exception - OutofStockException
    //The custom exception inherite from the base Exception
    public class OutofStockException : Exception
    {
        //To passing the msg 
        public OutofStockException(string message)
            : base(message)
        {
        }
    }

}
