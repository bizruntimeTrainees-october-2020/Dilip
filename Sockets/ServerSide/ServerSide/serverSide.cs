using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class ServerSide
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is SERVER");
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080); //contains host and local port info which helps in forming a connection point
            listenerSocket.Bind(iPEnd);//associate socket with local end point 
            listenerSocket.Listen(0); // how many clients are there  and places socket in listening state
            Socket clientSocket = listenerSocket.Accept(); // retrieve a connect request and convert that into a request.
            byte[] Buffer = new byte[clientSocket.SendBufferSize]; //allocates bytes for data 
            int readByte;
            do
            {
                readByte = clientSocket.Receive(Buffer); // recevies bytes from client
                byte[] rData = new byte[readByte]; //length of bytes sent by client
                Array.Copy(Buffer, rData, readByte); // adds source and destination array to copy data 
                Console.WriteLine("WE GOT: " + System.Text.Encoding.UTF8.GetString(rData)); // Decodes a range of bytes from a byte array into a string.
            } while (readByte > 0);


            Console.WriteLine("Client Disconnected");
            Console.ReadKey();
        }
    }
}



