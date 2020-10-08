using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace client
{
    class ClientSid//protocoltype UDP
    {
        public static void Main(string[] args)
        {
            UdpClient client = new UdpClient();
            client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080));
            Console.WriteLine(">");
            string inputs = Console.ReadLine();
            if(inputs!=null)
            {
                byte[] bytesent = Encoding.ASCII.GetBytes(inputs);
                client.Send(bytesent, bytesent.Length);
                Console.WriteLine("> successfull message sent");
                client.Close();
                Console.ReadLine();

            }
        }
    }
}
