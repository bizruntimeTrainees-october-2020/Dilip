using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerSide//trotocol type UDP
{
    class Serversideconsole
    {
        static void Main(string[] args)
        {
            Console.Write("Server waits for connection");
            UdpClient client1 = new UdpClient(8080);
            IPEndPoint remoteip = new IPEndPoint(IPAddress.Any, 8080);
            byte[] recievedByte = client1.Receive(ref remoteip);

            if (recievedByte != null)
            {
                string message = Encoding.ASCII.GetString(recievedByte);
                Console.WriteLine("recieved message " +message);
            }
            else
            {
                Console.WriteLine("empty message recieved");
            }
            Console.ReadLine();

        }
    }
}
