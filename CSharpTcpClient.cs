
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace CSharpTcpClient
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TcpClient client  = new TcpClient("127.0.0.1", 4321);
            StreamWriter sw = new StreamWriter(client.GetStream());

            sw.WriteLine("Hello C# TCP Server");
            sw.AutoFlush = true;

            client.Close ();    
        }
    }
}

using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TcpClientExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TcpClient client  = new TcpClient("127.0.0.1", 1234);
            StreamWriter sw = new StreamWriter(client.GetStream());

            sw.WriteLine("Hello C# TCP Server");
            sw.AutoFlush = true;

            client.Close ();    
        }
    }
}