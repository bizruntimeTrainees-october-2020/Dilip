using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketClient
{
    class SocketprogClient
    {
         public static void Main(string[] args)
         {
            StartClient();
         }
        public static void StartClient()
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPHostEntry host = Dns.GetHostEntry("localhost");//container class for storing  address info DNS=helper class
                IPAddress ipAddress = host.AddressList[0];//address list is propertiy whch sets or get address
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                Socket sender = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

                    int bytesSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Echoed test = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.Message);
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.Message);
                }
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
