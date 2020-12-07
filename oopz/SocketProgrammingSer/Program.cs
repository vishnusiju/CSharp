using ServerSocketApp;
using System;
using System.Net.Sockets;

//  This is the server side code.
namespace ServerSocketApp
{
    class SimpleSocketProgram
    {
        static void Main(string[] args)
        {
            ServerSocket SS = new ServerSocket();
            SS.ServerSock();
        }
    }
}
