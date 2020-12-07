//using System;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}


//================


//class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] S_No = new int[20];
//            int[] Employee_ID = new int[20];
//            String[] Employee_Name = new string[20];
//            int[] Company_ID = new int[20];
//            String[] Company_Name = new string[20];
//            String[] Designation = new String[20];
//            String[] Department = new string[20];

//            int n;
//            Console.WriteLine("Number of employees:");
//            n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                S_No[i] = Convert.ToInt32(Console.ReadLine());
//                Employee_ID[i] = Convert.ToInt32(Console.ReadLine());
//                Employee_Name[i] = Console.ReadLine();
//                Company_ID[i] = Convert.ToInt32(Console.ReadLine());
//                Company_Name[i] = Console.ReadLine();
//                Designation[i] = Console.ReadLine();
//                Department[i] = Console.ReadLine();
//            }
//            for (int j = 0; j < n; j++)
//            {

//                Console.WriteLine(S_No + "," + Employee_ID + "," + Employee_Name + "," + Company_ID + "," + Company_Name + "," + Designation + "," + Department);


//            }

//            StringBuilder csvContent = new StringBuilder();
//            csvContent.AppendLine("SLNo,EmpIloyeeID,EmployeeName,CompanyID,ComapnyName,Designation,Department");
//            Console.WriteLine("Enter Employee datails...");

//            // Console.WriteLine(S_No + "SLNo" + Employee_ID + "EmpIloyeeID" + Employee_Name + "EmployeeName" + Company_ID + ",CompanyID" + Company_Name + "ComapnyName" + Designation + "Designation" + Department+ "Department");
//            csvContent.Append(S_No + "," + Employee_ID + "," + Employee_Name + "," + Company_ID + "," + Company_Name + "," + Designation + "," + Department + Environment.NewLine);


//            //string st = File.ReadAllText("D:\\Data.csv");
//            //Console.WriteLine(st);


//            string csvPath = "D:\\File.csv";
//            File.AppendAllText(csvPath, csvContent.ToString());



//        }


//    }
//}



//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Data;



//===============================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{

    class Employee
    {
        protected int id;
        protected string name;
        protected double salary;


        public Employee()
        {
        }

        public Employee(int _id, string nm, double sal)
        {
            id = _id;
            name = nm;
            salary = sal;
        }


        public void PrintEmployee()
        {

            Console.WriteLine("id: {0}", id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Salary: {0}", salary);


        }


    }


    class EmployeeArray : Employee
    {
        private Employee[] a;
        private int currSize;
        private const int SIZE = 100;

        public EmployeeArray()
            : base()
        {

        }
        public EmployeeArray(int s, int _id, string nm, double sal)
            : base(_id, nm, sal)
        {
            a = new Employee[SIZE];
            if (s > SIZE)
                Console.WriteLine("Array size is overflow!");
            else if (s == SIZE)
                Console.WriteLine("Array is full.");
            else
                currSize = s;




        }

        public void Input()
        {
            a = new Employee[3];
            for (int i = 0; i < currSize; i++)
            {
                a[i] = new Employee(id, name, salary);
            }



        }
        public void Output()
        {
            Console.WriteLine("Array is: ");
            foreach (Employee x in a)
                Console.WriteLine("a[{0}]= {1}", name, x);


        }




        public int Search(int key)
        {
            for (int i = 0; i < currSize; i++)
            {
                //if (a[i] == key)
                //    return i;
            }
            return -1;
        }

        public void Insert()
        {
            if (currSize == SIZE)
            {
                Console.Write("Array is full! ");
                return;
            }
            Console.WriteLine("Enter a number to insert: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter the index to where it is to insert: ");
            int pos = int.Parse(Console.ReadLine());
            for (int i = currSize; i > pos; i--)
                a[i] = a[i - 1];


            //a[pos] = y;
            currSize++;
        }

        public void Delete()
        {
            if (currSize == 0)
            {
                Console.WriteLine("Array is empty! ");
                return;
            }
            Console.Write("Delete by value (1) or by index (2):  ");
            int key = int.Parse(Console.ReadLine());
            int pos = -1;
            if (key == 1)
            {
                Console.WriteLine("Enter the number to delete: ");
                int d = int.Parse(Console.ReadLine());
                pos = Search(d);
                while (pos == -1)
                {
                    Console.WriteLine("The number does not exist, enter again: ");
                    d = int.Parse(Console.ReadLine());
                    pos = Search(d);
                }
            }
            else if (key == 2)
            {
                Console.WriteLine("Enter the index to delete from: ");
                pos = int.Parse(Console.ReadLine());

                while (pos < 0 || pos > currSize)
                {
                    Console.WriteLine("The index is out of range, enter again: ");
                    pos = int.Parse(Console.ReadLine());
                }

            }
            else
                return;

            for (int i = pos; i < currSize; i++)
                a[i] = a[i + 1];

            currSize--;
            if (currSize <= 0)
                Console.Write("Array is empty! ");
        }

        public void Update()
        {
            Console.WriteLine("Enter the index where to update: ");
            int pos = int.Parse(Console.ReadLine());
            while (pos < 0 || pos >= currSize)
            {
                Console.WriteLine("The index you entered is not valid, enter again: ");
                pos = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the new value: ");
            int x = int.Parse(Console.ReadLine());
            //a[pos] = x;
            Console.Write("Update complete! ");
        }


    }
    class Program
    {
        //static char ShowMenu()
        //{
        //    Console.WriteLine("\nEnter the letter of operation: \n(o)Print, (s)Search, (i)Insertion, (d)Deletion, (u)Update, (e)Exit\n");
        //    return char.Parse(Console.ReadLine());
        //}
        static void Main(string[] args)
        {
            //char sel = ' ';
            Console.Write("Enter number of Employees; ");
            int i = 0;
            int s = int.Parse(Console.ReadLine());

            while (i < s)
            {


                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Enter id: ");
                int _id = int.Parse(Console.ReadLine());


                Console.WriteLine("");
                Console.WriteLine("Enter Name: ");
                string nm = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Enter Salary: ");
                double sal = int.Parse(Console.ReadLine());

                EmployeeArray arr = new EmployeeArray(s, _id, nm, sal);


                i++;
            }



        }
    }
}
////=====================

//using System;
//using System.Collections.Generic;

//namespace collection_ex
//{
//    public class InitializationSample
//    {
//        public class Cat
//        {

//            public int Age { get; set; }
//            public string Name { get; set; }

//            public Cat() { }

//            public Cat(string name)
//            {
//                Name = name;
//            }
//        }

//        public static void Main()
//        {
//            Cat cat = new Cat { Age = 10, Name = "Fluffy" };
//            Cat sameCat = new Cat("Fluffy") { Age = 10 };

//            List<Cat> cats = new List<Cat>
//        {
//            new Cat { Name = "Sylvester", Age = 8 },
//            new Cat { Name = "Whiskers", Age = 2 },
//            new Cat { Name = "Sasha", Age = 14 }
//        };

//            List<Cat> moreCats = new List<Cat>
//        {
//            new Cat { Name = "Furrytail", Age = 5 },
//            new Cat { Name = "Peaches", Age = 4 },
//            null
//        };

//            // Display results.
//            System.Console.WriteLine(cat.Name);

//            foreach (Cat c in cats)
//                System.Console.WriteLine(c.Name);

//            foreach (Cat c in moreCats)
//                if (c != null)
//                    System.Console.WriteLine(c.Name);
//                else
//                    System.Console.WriteLine("List element has null value.");
//        }
//    }
//}
////-----------out----
////Fluffy
////Sylvester
////Whiskers
////Sasha
////Furrytail
////Peaches
////List element has null value.



//=======================
//using System;
//using System.Collections;
//using System.Collections.Generic;


//namespace array_collections
//{
//    class CollectionArray
//    {
//        static void Main(string[] args)
//        {
//            ArrayList a1 = new ArrayList();
//            a1.Add("Bob");
//            a1.Add("20");

//            Console.WriteLine("Count:{0}", a1.Count);

//            Console.WriteLine("Capacity:{0}", a1.Capacity);

//            ArrayList a2 = new ArrayList();
//            a2.AddRange(new object[] { "mike", "Sally", "jkj" });
//            a1.AddRange(a2);
//            a2.Sort();
//            a2.Reverse();

//            a2.Insert(1, "turkey");
//            ArrayList range = a2.GetRange(0, 2);
//            foreach (object o in range)
//            {
//                Console.WriteLine(o);
//            }
//            a2.RemoveAt(0);
//            a2.RemoveRange(0, 2);

//            Console.WriteLine("turkey Index:{0}", a2.IndexOf("turkey", 0));
//            string[] myArray = (string[])
//                a2.ToArray(typeof(string));

//            string[] customer = { "bob", "sally", "sue" };
//            ArrayList custArrayList = new ArrayList();
//            custArrayList.AddRange(customer);

//            foreach (string s in custArrayList)
//            {
//                Console.WriteLine(s);
//            }
//        }
//    }
//}
//=======================

//=================================
//using System;
//using System.Collections.Generic;

//namespace generic_collectio
//{
//    class Animal
//    {
//        public string Name { get; set; }
//        public Animal(string name = "No Name")
//        {
//            Name = name;

//        }
//        static void Main(string[] args)
//        {
//            List<Animal> animalList = new List<Animal>();


//            animalList.Add(new Animal() { Name = "Lion" });
//            animalList.Add(new Animal() { Name = "tig" });


//            animalList.Insert(1, new Animal() { Name = "cccc" });


//            Console.WriteLine("No of animals:{0},animalList.Count()");
//            foreach (Animal a in animalList)
//            {
//                Console.WriteLine(a.Name);
//            }
//        }
//    }
//}
//============================

//namespace EmployeeDetails


//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication13
//{
//    class Register
//    {
//        public string name;
//        public string surname;

//        public void RegisterData()
//        {
//            Console.Write("Enter your name: "); name = Console.ReadLine();
//            Console.Write("Enter your surname: "); surname = Console.ReadLine();
//        }

//        public void PrintData()
//        {
//            Console.WriteLine("Name: " + name + " Surname: " + surname);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            ArrayList list = new ArrayList();

//            Register temp = new Register();

//            temp.RegisterData();

//            list.Add(temp);

//            for (int i = 0; i < list.Count; i++)
//            {
//                // How can I use the PrintData (without modifying it) method to print the ArrayList values?
//            }
//        }
//    }
//}


///==========================
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace CreateCsv
//{
//    class Program
//    {
//        static void Main()
//        {
//            // Set the path and filename variable "path", filename being MyTest.csv in this example.
//            // Change SomeGuy for your username.
//            string path = @"E:\Task2\MyTest.csv";

//            // Set the variable "delimiter" to ", ".
//            string delimiter = ", ";

//            // This text is added only once to the file.
//            if (!File.Exists(path))
//            {
//                // Create a file to write to.
//                string createText = "Column 1 Name" + delimiter + "Column 2 Name" + delimiter + "Column 3 Name" + delimiter + Environment.NewLine;
//                File.WriteAllText(path, createText);
//            }

//            // This text is always added, making the file longer over time
//            // if it is not deleted.
//            string appendText = "This is text for Column 1" + delimiter + "This is text for Column 2" + delimiter + "This is text for Column 3" + delimiter + Environment.NewLine;
//            File.AppendAllText(path, appendText);

//            // Open the file to read from.
//            string readText = File.ReadAllText(path);
//            Console.WriteLine(readText);
//        }
//    }
//}
//=============================

//using System;
//using System.IO;
//using System.Text;

//namespace CsvExample
//{

//    public class Program
//    {

//        static void Main(string[] args)
//        {
//            string strFilePath = @"E:\Task2\Data.csv";
//            string strSeperator = ",";
//            StringBuilder sbOutput = new StringBuilder();

//            int[][] inaOutput = new int[][]{
//            new int[]{1000, 2000, 3000, 4000, 5000},
//            new int[]{6000, 7000, 8000, 9000, 10000},
//            new int[]{11000, 12000, 13000, 14000, 15000}
//        };

//            int ilength = inaOutput.GetLength(0);
//            for (int i = 0; i< ilength; i++)
//            sbOutput.AppendLine(string.Join(strSeperator, inaOutput[i]));

//            // Create and write the csv file
//            File.WriteAllText(strFilePath, sbOutput.ToString());

//            // To append more lines to the csv file
//            File.AppendAllText(strFilePath, sbOutput.ToString());
//        }
//    }
//}



//{
//   




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using Microsoft.VisualBasic.FileIO;
//using System.Collections;

//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            String path = "C:\\Desktop\\";
//            String file1 = "testFile1.csv";
//            ArrayList arryList1 = new ArrayList();
//            String[] dataArray1;

//            TextFieldParser CSVFile1 = new TextFieldParser(path + file1);
//            CSVFile1.SetDelimiters(",");
//            dataArray1 = CSVFile1.ReadFields();

//            int count = 0;
//            while (!CSVFile1.EndOfData)
//            {
//                dataArray1 = CSVFile1.ReadFields();
//                Console.WriteLine(dataArray1);
//            }
//            Console.Read();
//        }
//    }
//}






//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Task
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            taskss TS = new taskss();
//            TS.newmeth();

//        }
//        class taskss
//        {
//            //public void newmeth()
//            //{
//                public class CSVTable
//            {

//                private String[][] csvTable = null;

//                public CSVTable(int columns)
//                {
//                    csvTable = new String[columns][2];
//                }

//                public String[][] getCSVTable()
//                {
//                    return this.csvTable;
//                }

//                public void setCSVTable(String[][] csvTable)
//                {
//                    this.csvTable = csvTable;
//                }
//            }



//        }
//        //}
//    }
//}
//I am simply practicing in C#. I am mostly used to Java but I have been unable to figure out how to read a .CSV file , store it and the print out it's contents into the console. This is what I have so far. What am I doing wrong?

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using Microsoft.VisualBasic.FileIO;
//using System.Collections;

//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            String path = "C:\\Desktop\\csvTestFilePractice\\";
//            String file1 = "testFile1.csv";
//            ArrayList arryList1 = new ArrayList();
//            String[] dataArray1;

//            TextFieldParser CSVFile1 = new TextFieldParser(path + file1);
//            CSVFile1.SetDelimiters(",");
//            dataArray1 = CSVFile1.ReadFields();

//            int count = 0;
//            while (!CSVFile1.EndOfData)
//            {
//                dataArray1 = CSVFile1.ReadFields();
//                Console.WriteLine(dataArray1);
//            }
//            Console.Read();
//        }
//    }
//}













//using System;
//using System.Xml.Linq;
//using System.IO;

//namespace Task
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            stringBuilder csvcontent = new stringBuilder();
//            csvcontent.AppendLine("Name,Age");
//            csvcontent.AppendLine("vishnu,31");
//            string csvpath ="E:\\Task2\\xyz.csv";
//            File.AppendAllText(csvpath, csvcontent.ToString());
//        }
//    }
//}
