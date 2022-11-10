using System.Threading.Tasks;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;


List<int> openPorts = new List<int>();

for (int i = 0; i < 65536; i++)
{
    Thread t = new Thread(() => GetOpenPort(i));
    t.Start();
}
foreach (var x in openPorts) Console.WriteLine("Port: " + x + " is open");

int GetOpenPort(int x)
{
    try
    {
        TcpClient socket = new TcpClient("127.0.0.1", x);
        openPorts.Add(x);
        Console.WriteLine(x);
        return x;
    }
    catch
    {
        return -1;
    }
}