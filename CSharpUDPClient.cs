using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace CSharpUDPServer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UdpClient client = new UdpClient();
            String fromServer = "Hello UDP Server\n";
            client.Send(Encoding.ASCII.GetBytes(toServer), toServer.Length, "127.0.0.1", 1234);
            client.Close();
        }
    }
}