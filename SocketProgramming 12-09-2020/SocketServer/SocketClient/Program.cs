using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteClient();
        }
        public static void ExecuteClient()
        {
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           // IPAddress ip = IPAddress.Any;
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.17"), 20220);
            try
            {
                client.Connect(iPEndPoint);
                //After connection is established.Giving requesting Input to server
                Console.WriteLine("Enter the requesting Input:");
                String inputText = Console.ReadLine();

                byte[] input = Encoding.ASCII.GetBytes(inputText);
                int bytesSent = client.Send(input);
                //code to be implement to take byte[] array size by means of server response output..4
                Console.WriteLine("ready to receiving");

                byte[] output = new byte[1024];

                int numOfBytes = client.Receive(output);
                Console.WriteLine("received");
                string ServerOutput = Encoding.ASCII.GetString(output, 0, numOfBytes);
                Console.WriteLine("server response is after client giving input:{0}", ServerOutput);
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }
    }
}
