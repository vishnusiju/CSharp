﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace AsynchronousSocketServer
{
    public class SoketServer
    {
        public const int BufferSize = 1024; 
        public byte[] buffer = new byte[BufferSize];       
        public StringBuilder sb = new StringBuilder();      
        public Socket workSocket = null;
    }
    public class AsynchronousSocketListener
    {
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        public static void Main(String[] args)
        {
            StartListening();            
        }       
        public static void StartListening()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint EndPoint = new IPEndPoint(ipAddress, 5555);  
            Socket listener = new Socket(ipAddress.AddressFamily,SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listener.Bind(EndPoint);
                listener.Listen(100);

                while (true)
                {  
                    allDone.Reset();
                    Console.WriteLine("Waiting for a connection...");
                    listener.BeginAccept(new AsyncCallback(AcceptCallback),listener);                   
                    allDone.WaitOne();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nPress ENTER to continue...");            
        }
        public static void AcceptCallback(IAsyncResult ar)
        {  
            allDone.Set();
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);
            SoketServer state = new SoketServer();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, SoketServer.BufferSize, 0,
                new AsyncCallback(ReceiveCallback), state);
        }
        public static void ReceiveCallback(IAsyncResult ar)
        {
            String content = String.Empty;
            SoketServer state = (SoketServer)ar.AsyncState;
            Socket handler = state.workSocket;           
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {                
                state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {                    
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",content.Length, content);                 
                    Send(handler, content);
                }
                else
                {                      
                    handler.BeginReceive(state.buffer, 0, SoketServer.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }
        private static void Send(Socket handler, String data)
        {           
           byte[] byteData = Encoding.ASCII.GetBytes(data);
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {                   
                Socket handler = (Socket)ar.AsyncState;                                
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }       
    }
}