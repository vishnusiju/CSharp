using System;


using System.IO;
using System.Text;

namespace Fileio
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo CurrDir = new DirectoryInfo(".");
            DirectoryInfo newDir = new DirectoryInfo(@"C:\Users\VISHNU SIJU\file io");
            Console.WriteLine("fullname: " +newDir.FullName);
            Console.WriteLine("name: " +newDir.Name);
            Console.WriteLine("parent: " +newDir.Parent);
            Console.WriteLine("attributes:" +newDir.Attributes);
            Console.WriteLine("creationtime:" +newDir.CreationTime);



            Console.WriteLine("================================");
            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\VISHNU SIJU\file io");

            string[] customers =
            {
                "vishnu siju",
                "sarath e",
                "vishnu s",
                "abin raj"

            };
            string textFilePath = @"C:\Users\VISHNU SIJU\file io\textfile.txt";
            File.WriteAllLines(textFilePath, customers);

            foreach (string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"customers : {cust}");
            }

            //It will check 
            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\VISHNU SIJU\file io");
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Matches : {0}", txtFiles.Length);
            foreach(FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }


            Console.WriteLine("=============================");
            string textFilePath2 = @"C:\Users\VISHNU SIJU\file io\textfile1.txt";
            FileStream fs = File.Open(textFilePath2, FileMode.Create);

            string randstring = "This is the random string";
            byte[] rsByteArray = Encoding.Default.GetBytes(randstring);
            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position = 0;
            byte[] fileByteArray = new byte[rsByteArray.Length];
            for(int i=0; i< rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            fs.Close();


            string textFilePath3 = @"C:\Users\VISHNU SIJU\file io\textfile3.txt";
            StreamWriter sw = File.CreateText(textFilePath3);
            sw.Write("This is random");
            sw.WriteLine("sentence");
            sw.WriteLine("this is another sentence");
            sw.Close();

            StreamReader sr = File.OpenText(textFilePath3);
            Console.WriteLine("peek : {0}",
                                Convert.ToChar(sr.Peek()));
            Console.WriteLine("1st string: {0}", sr.ReadLine());

            Console.WriteLine("Everything: {0}", sr.ReadToEnd());
            sr.Close();


            Console.WriteLine("=======================");
            string textFilePath4 = @"C:\Users\VISHNU SIJU\file io\textfile3.txt";

            FileInfo datFile = new FileInfo(textFilePath4);
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            string randtaxt = "Random text";
            int myage = 23;
            double height = 6.25;

            bw.Write(randtaxt);
            bw.Write(myage);
            bw.Write(height);
            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadBoolean());
            br.Close();
            Console.ReadKey();



        }
    }
}
//OUTPOT:-
//fullname: C: \Users\VISHNU SIJU\file io
//name: file io
//parent: C: \Users\VISHNU SIJU
//attributes:Directory
//creationtime:11 / 17 / 2020 9:39:32 AM
//================================
//customers : vishnu siju
//customers : sarath e
//customers : vishnu s
//customers : abin raj
//Matches : 3
//textfile.txt
//43
//textfile1.txt
//25
//textfile3.txt
//50
//=============================
//This is the random string
//peek : T
//1st string: This is randomsentence
//Everything: this is another sentence

//=======================
//Random text
//23
//6.25
//True











//ReadToEnd():-
//The ReadToEnd() method reads all characters from the current position to the end of 
//the stream. It returns the rest of the stream as a string, from the current 
//position to the end; if the current position is at the end of the stream, 
//it returns an empty string.

//Dispose:-
//Dispose method is used to clean the unmanaged resources.

//Flush():-
// Clears buffers for this stream and causes any buffered data to be written to the file.
//Flush(Boolean) Clears buffers for this stream and causes any buffered data to be 
//written to the file, and also clears all intermediate file buffers.

//DirectoryInfo,File,Encoding,StreamReader,StreamWriter,FileInfo,BinaryWriter,BinaryReader
//ReadString(),ReadInt32(),ReadDouble(),ReadBoolean(),OpenRead(),OpenWrite(),ReadToEnd(),
    //ReadLine(),Peek(),GetString(),ReadByte(),WriteAllLines(),ReadAllLines(),GetFiles(),Close().