using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MultiThreadedSocketClient
{
    class Program
    {
        static void Main(string[] args)
        {        
            SocketClient();
        }
        public static void SocketClient()
        {
            /* IPHostEntry iphost = Dns.GetHostEntry(Dns.GetHostName());
             IPAddress ip = iphost.AddressList[0];*/
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint iep = new IPEndPoint(ipAddress, 11000);
            Socket clientSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(iep);
            while(true)
            {
                Console.WriteLine("Client is connected");
                Console.WriteLine("enter the input:");
                String clientInput = Console.ReadLine();
               // Console.WriteLine("Sending input from client to server");
              /*  byte[] inputBytes = Encoding.ASCII.GetBytes(clientInput);
                int size = inputBytes.Length;*/
                clientSocket.Send(Encoding.ASCII.GetBytes(clientInput), 0, clientInput.Length, SocketFlags.None);

                Console.WriteLine("Output from server");
                byte[] output = new byte[1024];
                int sizeOfOutput = clientSocket.Receive(output);
                String serveroutput = Encoding.ASCII.GetString(output,0,sizeOfOutput);
                Console.WriteLine(serveroutput);
               
            }
        }
    }
}
