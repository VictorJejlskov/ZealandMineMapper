using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TCPThings.TCPServer
{
    /// <summary>
    /// Abstract TCP server, needing a port and name as parameters,
    /// and an override of TcpServerWork, to determine what the server does.
    /// </summary>
    public abstract class AbstractTCPServer
    {
        private int _port;
        private string _name;
        /// <summary>
        /// The server needs a port, which to listen on, and a name. 
        /// The port ABOVE the one used, should also be free, eg. 7001 and 7002,
        /// used for the close-server
        /// </summary>
        /// <param name="port">The value of the port to listen on (keep port+1 free too)</param>
        /// <param name="name">The value of the name, for the server</param>
        public AbstractTCPServer(int port, string name)
        {
            _port = port;
            _name = name;
        }
        private bool _running = true;
        /// <summary>
        /// Method to start the TCP server, preparing it for incoming clients.
        /// Also starts the stop-server, on the port above the used port
        /// </summary>
        public void Start()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, _port);
            listener.Start();
            Console.WriteLine(_name + " server started at port: " + _port);

            Task.Run(() =>
            {
                Stop();
            });
            List<Task> tasks = new List<Task>();
            while (_running)
            {
                if (listener.Pending())
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("New client incoming");
                    Console.WriteLine($"remote (ip,port) = ({client.Client.RemoteEndPoint})");

                    tasks.Add(Task.Run(() =>
                    {
                        TcpClient tmpClient = client;
                        StreamReader reader = new StreamReader(tmpClient.GetStream());
                        StreamWriter writer = new StreamWriter(tmpClient.GetStream());
                        TcpServerWork(reader, writer);
                    }));
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
            Task.WaitAll(tasks.ToArray());

        }
        /// <summary>
        /// Method to start the stop-server, using the port above the earlier selected port
        /// </summary>
        private void Stop()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, ++_port);
            listener.Start();
            Console.WriteLine("stop-server started at port: " + _port);
            TcpClient client = listener.AcceptTcpClient();
            _running = false; 
        }
        /// <summary>
        /// Abstract method, that is executed whenever a new client connects.
        /// </summary>
        /// <param name="sr">The value of the StreamReader</param>
        /// <param name="sw">The value of the StreamWriter</param>
        public abstract void TcpServerWork(StreamReader sr, StreamWriter sw);

    }
}
