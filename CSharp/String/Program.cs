using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRING
            //this methoad is known as escape sequence-/(forward slash).
            string s = "C:\\programfile\\myfile.txt"; //this will print like this 'C:\programfile\myfile.txt'..
            Console.WriteLine(s);

            string another = @"C:\programfile\myfile.txt";  //this method is known as Verbatim Literals -@(athrat).
            Console.WriteLine(another);
            Console.WriteLine(another.Length); //to print length.
            Console.WriteLine(another.ToUpper());
            Console.WriteLine(another.ToLower());
            Console.WriteLine(another[0]);
            Console.WriteLine(another[3] + "hai");

            //ARRAY
            int[] nums = { 1, 2, 3 };
            Console.WriteLine(nums[2]);

            //togiving particilar values for that index.
            int[] num = { 1, 2, 3 };
            nums[2] = 100;
            Console.WriteLine(num[2]);
            //this is for printing vales that gives manual.
            /*int[] nums = new int[2];
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 30;
            Console.WriteLine(nums[2]);*/

            string[] names = { "data", "data1" };
            Console.WriteLine(names[1]);
            //array with matrix
            int[,] numss = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(numss[0, 0]);

            /*OPERATORS
             * Assignment operators =
             * Arithmetic +, -, *, /, %.
             * Comparison !=, ==, <, >, <=, >=.
             * Conditional &&,||
             * ternary ?: */
            int number1 = 100;
            int number2 = 50;
            if(number1 != number2)
            {
                Console.WriteLine("Condition 1 is true");
            }
            else
            {
                Console.WriteLine("Condition 2 is true");
            }

            //using conditional operators
            int number3 = 100;
            int number4 = 50;
            if(number3 != number4 && number3 == 100)
            {
                Console.WriteLine("condition 1 is true");
            }
            else
            {
                Console.WriteLine("condition 2 is true");
            }


            //LISTS
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Remove(2); //removing the values.
            Console.WriteLine(numbers.ElementAt(1));

            List<int> numbers2 = new List<int>();
            numbers2.Add(4);
            numbers2.Add(5);
            numbers.AddRange(numbers2); //concatinating list
            Console.WriteLine(numbers.Count);

            //add array to list
            int[] array = new int[] { 10, 20, 30 };
            numbers.AddRange(array);
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.ElementAt(4));

            //list  with strings
            List<string> abc = new List<string>();
            abc.Add("a");
            abc.Add("c");
            Console.WriteLine(abc.ElementAt(1));

        }
    }
}
