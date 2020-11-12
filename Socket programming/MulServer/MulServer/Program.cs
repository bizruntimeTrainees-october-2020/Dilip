using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace MulServer
{
    class ServerSideProg
    {
        private static byte[] _buffer = new byte[1024]; 

        private static List<Socket> _clientSockets = new List<Socket>();
        private static Socket _serversocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public  static void Main(string[] args)
        {
            Console.Title = "Server";
            setupServer();
            Console.ReadKey();
        }
        private static void setupServer()
        {
            Console.WriteLine("setting up of server....");
            //IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            _serversocket.Bind(new IPEndPoint(IPAddress.Any, 100));//Associates a Socket with a local endpoint.
            _serversocket.Listen(1);//Places a Socket in a listening state.
            _serversocket.BeginAccept(new AsyncCallback(AcceptCallback) , null);//Begins an asynchronous operation to accept an incoming connection attempt.
        }
        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = _serversocket.EndAccept(AR);//Asynchronously accepts an incoming connection attempt
            _clientSockets.Add(socket);//added in the list
            Console.WriteLine("Client connects....");
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);//Begins to asynchronously receive data from a connected Socket.
            _serversocket.BeginAccept(new AsyncCallback(AcceptCallback), null);

        }
        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);//Ends a pending asynchronous read.
            byte[] databuf = new byte[received];
            Array.Copy(_buffer, databuf, received);

            string text = Encoding.ASCII.GetString(databuf);
            Console.WriteLine("Text Received:" + text);

            string response = string.Empty;
            if (text.ToLower() != "get time")
            {
                response = " invalid request";
            }
            else
            {
                response = DateTime.Now.ToLongTimeString();
            }



            byte[] data = Encoding.ASCII.GetBytes(response);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }
        private static void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }


        
    }
}
