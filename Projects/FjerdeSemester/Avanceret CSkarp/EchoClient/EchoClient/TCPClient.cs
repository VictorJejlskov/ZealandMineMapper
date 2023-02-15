using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPThings.TCPClient;

namespace EchoClient
{
    public class TCPClient : AbstractTCPClient
    {
        public TCPClient(int port, string ip) : base(port, ip)
        {
        }

        public override void ClientDoStuff(StreamReader sr, StreamWriter sw)
        {
            string message = Console.ReadLine();
            sw.AutoFlush = true;
            Console.WriteLine("Sending message");
            if (message != null)
            {
                sw.WriteLine(message);
            }
            else sw.WriteLine("No msg :)))))");
            string? result = sr.ReadLine();
            Console.WriteLine(result);
        }
    }
}
