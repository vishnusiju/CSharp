using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class SocketServer1
{

    // Incoming data from the client.  
    public static string data = null;

    public static void StartListening()
    {
         
        byte[] bytes = new Byte[1024];
         
        IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        IPAddress ipAddress = ipHostInfo.AddressList[0];
        IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);
 
        Socket listener = new Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp);

        try
        {
            listener.Bind(localEndPoint);
            listener.Listen(10);            
            while (true)
            {
                Console.WriteLine("Waiting for a connection...");                 
                Socket handler = listener.Accept();
                data = null;
                //Taking input from client                
                while (true)
                {
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }
                }
                                 
                Console.WriteLine("Text received : {0}", data);
                //giving requesting output  to client              
                byte[] msg = Encoding.ASCII.GetBytes(data);
                handler.Send(msg);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        Console.WriteLine("\nPress ENTER to continue...");
        Console.Read();

    }

    public static int Main(String[] args)
    {
        StartListening();
        return 0;
    }
}
