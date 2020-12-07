using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteServer();
        }
        public static void ExecuteServer()
        {
           // IPAddress ip =  IPAddress.Any;
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.17"), 20220);
            Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            try
            {
                server.Bind(iPEndPoint);
                server.Listen(10);
                String clientInput = null; 
                while (true)
                {
                   // Console.WriteLine("waiting for connection");
                    Socket Accept = server.Accept();
                    //take the count of input from the client into the bye array.
                    byte[] bytes = new byte[Accept.SendBufferSize];
                    //receiving the input by converting  byte array to int type.
                    int numOfBytes = Accept.Receive(bytes);
                    Console.WriteLine(numOfBytes);
                    //again converting input information to binary
                    clientInput += Encoding.ASCII.GetString(bytes, 0, numOfBytes);
                    Console.WriteLine("clientInput taken:{0}",clientInput);

                    byte[] output = Encoding.ASCII.GetBytes("this is output from Server Side");
                
                    Console.WriteLine("Server sending output is:");
                    /*foreach(byte i in output)
                    {
                        Console.WriteLine(i);
                    }*/
                    Accept.Send(output);                  
                    Accept.Shutdown(SocketShutdown.Both);
                    Accept.Close();


                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message+ "something happen");
            }

        }
    }
}
