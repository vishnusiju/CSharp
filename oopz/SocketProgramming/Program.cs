using System;
using System.Net.Sockets;
using System.IO;
using ClientSocketApp;

//   This is the client side code.
namespace ClientSocketApp
{
    class SimpleSocketProgram
    {
        static void Main(string[] args)
        {
            ClientSocket CS = new ClientSocket();
            CS.ClientSock();

        }
       
    }
    
    




    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    TcpListener server = new TcpListener(8888);
    //    server.Start();
    //    Console.WriteLine("Server Started and waiting for clients.");
    //    Socket socketForClients = server.AcceptSocket();


    //        if (socketForClients.Connected)
    //        {
    //            NetworkStream ns = new NetworkStream(socketForClients);
    //            StreamWriter sw = new StreamWriter(ns);
    //            Console.WriteLine(" Server>> Welcome Client.");
    //            sw.WriteLine("Welcome Client");
    //            sw.Flush();
    //            sw.Close();
    //            ns.Close();
    //        }
    //        socketForClients.Close();
    //    }
    //}
}








