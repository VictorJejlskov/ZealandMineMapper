using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPThings.TCPClient
{
    public abstract class AbstractTCPClient
    {
        private int _port;
        private string _ip;

        public AbstractTCPClient(int port, string ip)
        {
            _port = port;
            _ip = ip;
        }

        public void Start()
        {
            Console.WriteLine("connecting");
            TcpClient client = new TcpClient();
            client.Connect(_ip, _port);
            Console.WriteLine("Client connected to: " + client);
            StreamReader reader = new StreamReader(client.GetStream());
            StreamWriter writer = new StreamWriter(client.GetStream());
            ClientDoStuff(reader, writer);
            
        }
        public abstract void ClientDoStuff(StreamReader sr, StreamWriter sw);
    }
}
