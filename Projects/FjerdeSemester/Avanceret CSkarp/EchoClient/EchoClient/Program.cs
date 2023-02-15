// See https://aka.ms/new-console-template for more information
using EchoClient;

while (true)
{
    TCPClient client = new TCPClient(7001, "127.0.0.1");
    client.Start();
    Thread.Sleep(1000);
}
