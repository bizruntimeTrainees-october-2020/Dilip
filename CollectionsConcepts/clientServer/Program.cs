using System;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;


namespace clientServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //tcplisterner :listens and accepts the incoming connections requests 
            TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);//parse used for ipaddress object
            server.Start();// starts listening for incoming requests
            Console.WriteLine("server has started on 127.0.0.1:8080  and waiting for connection", Environment.NewLine);
            TcpClient client = server.AcceptTcpClient();//waits for tcp accepts and return it as tcp object
            Console.WriteLine("client conneceted ");//connection is been established
            NetworkStream stream = client.GetStream();
            while (true)
                while (!stream.DataAvailable) ;
            Byte[] bytes = new byte [client.Available];
            stream.Read(bytes, 0, bytes.Length);




        }
    }
}
