using System;
using System.Net;
using System.Net.Sockets;
namespace Client
{
    class ClientSide
    {
       public static void Main(string[] args)
        { 
            Console.WriteLine("This is Client");
            Socket master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //Establishing Connection
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080); // spcifies a port to initialize
            master.Connect(iPEnd); //accpets  new connections

            string sendData ="";
            do
            {
                Console.Write("Data to send :");
                sendData = Console.ReadLine();
                master.Send(System.Text.Encoding.UTF8.GetBytes(sendData)); //conversion takes place

            } while (sendData.Length > 0);
            master.Close();
        }
    }
}




