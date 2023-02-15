using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TCPThings.TCPServer;

namespace EchoServer
{
    public class TCPServer : AbstractTCPServer
    {
        public TCPServer(int port, string name) : base(port, name)
        {
        }

        public override void TcpServerWork(StreamReader sr, StreamWriter sw)
        {
            sw.AutoFlush = true;
            Console.WriteLine("Handling one client");
            
            string? s = sr.ReadLine();
            sw.WriteLine(s.ToUpper());
        }
    }
}
