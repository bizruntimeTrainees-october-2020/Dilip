using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Time_Client
{
    class Client
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            Console.Title = "Client";
            LoopConnect();
            Console.ReadLine();
            SendLoop();
        }

        private static void SendLoop()
        {
           while(true)
            {
                Console.Write("enter a request");
                 string req = Console.ReadLine();
                byte[] buffer = Encoding.ASCII.GetBytes(req);
                _clientSocket.Send(buffer);
                byte[] receivedBuf = new byte[1024];
                int rece = _clientSocket.Receive(receivedBuf);
                byte[] data = new byte[rece];
                Array.Copy(receivedBuf, data, rece);
                Console.WriteLine("received" + Encoding.ASCII.GetString(data));
            }
        }

        private static void LoopConnect()
        {
            int attempts = 0; 
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException)
                {
                    Console.Clear();
                    Console.WriteLine("Connection attempts :" + attempts.ToString());
                }

            }
            Console.Clear();
            Console.WriteLine("Connected");
        }
    }
}
