using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ClientSocketApp
{
    class ClientSocket
    {
        public void ClientSock()
        {
        connection:
            try
            {
                TcpClient client = new TcpClient();
                client.Connect("106.51.126.111:", 1302);
                string messageToSend = "My name is Neon";
                int byteCount = Encoding.ASCII.GetByteCount(messageToSend + 1);
                byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                NetworkStream stream = client.GetStream();
                stream.Write(sendData, 0, sendData.Length);
                Console.WriteLine("sending data to server...");

                StreamReader sr = new StreamReader(stream);
                string response = sr.ReadLine();
                Console.WriteLine(response);

                stream.Close();
                client.Close();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("failed to connect..." +e);
                goto connection;
            }
        }
    }
}
