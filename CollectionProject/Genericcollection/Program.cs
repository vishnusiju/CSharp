using System;
using System.Linq;
using System.Collections.Generic;
// LINQ - (language integrated query)
// query and update data source in memory.
namespace Genericcollection
{
    class LinQ
    {
        static void Main(string[] args)
        {
            SimpleLinQ LQ = new SimpleLinQ();
            LQ.LinQS();

            SimpleLinQQ LM = new SimpleLinQQ();
            LM.LinQM();
        }
        // by using Query Syntax
    class SimpleLinQ
        {
            public void LinQS()
            {

                // Query #1.
                Console.WriteLine("LinQ using Query Syntax ");
                List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                // The query variable can also be implicitly typed by using var
                IEnumerable<int> filteringQuery =
                    from num in numbers             //all num object in numbers
                    where num < 3 || num > 7        //all num with the condithion (num<3||num>7)
                    select num;                     //print the num, after the conditions
                foreach (var str in filteringQuery)
                {
                    Console.WriteLine(str);
                }

                // Query #2.
                Console.WriteLine("----------");
                IEnumerable<int> orderingQuery =
                    from num in numbers       
                    where num < 3 || num > 7
                    orderby num ascending
                    select num;
                foreach (var str in orderingQuery)
                {
                    Console.WriteLine(str);
                }

                // Query #3.
                Console.WriteLine("------------");
                string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
                IEnumerable<IGrouping<char, string>> queryFoodGroups =
                    from item in groupingQuery
                    group item by item[0];
                foreach (var str in groupingQuery)
                {
                    Console.WriteLine(str);
                }
            }
        }



    }

    

    //By using Method Syntax
    class SimpleLinQQ
    {
        public void LinQM()
        {
            // string collection
            Console.WriteLine("-----------------");
            Console.WriteLine("LinQ Using Method Syntax:");
            IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };

            // LINQ Method Syntax
            var result = stringList.Where(s => s.Contains("Tutorials"));


            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
        }

    }
}


//// Query #1.
//List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//// The query variable can also be implicitly typed by using var
//IEnumerable<int> filteringQuery =
//    from num in numbers
//    where num < 3 || num > 7
//    select num;

//// Query #2.
//IEnumerable<int> orderingQuery =
//    from num in numbers
//    where num < 3 || num > 7
//    orderby num ascending
//    select num;

//// Query #3.
//string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
//IEnumerable<IGrouping<char, string>> queryFoodGroups =
//    from item in groupingQuery
//    group item by item[0];






// three-way linq we can write
// 1.using query syntax
// 2.using method syntax
// 3.combination of query and method


//IEnumerable is an interface defining a single method 
//        GetEnumerator() that returns an IEnumerator interface.


