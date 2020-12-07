using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MultiThreadedSocketServer
{
    class SocketServer
    {
        static void Main(string[] args)
        {
            server();           
        }
        static void server()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint iep = new IPEndPoint(ipAddress, 11000);
            Socket server = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(iep);
            server.Listen(500);
            Console.WriteLine("Server stareted listening clients requests");
            Socket ClientSocket = default(Socket);
            //int count = 0;
            
            while(true)
            {
               // count++;
                ClientSocket = server.Accept();
               // Console.WriteLine(count+"clients connected");
                Thread userThread = new Thread(new ThreadStart(() => User(ClientSocket)));
                userThread.Start();
            }
        }
        public static void User(Socket Client)
        {
            while (true)
            {
                byte[] bytes = new byte[2048];
                int size = Client.Receive(bytes);
                Client.Send(bytes, 0, size, SocketFlags.None);
            }
        }
    }
}
