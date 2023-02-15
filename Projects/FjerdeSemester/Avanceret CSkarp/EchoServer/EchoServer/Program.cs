// See https://aka.ms/new-console-template for more information

using EchoServer;

TCPServer server = new TCPServer(7001, "TestServeren");
server.Start();
