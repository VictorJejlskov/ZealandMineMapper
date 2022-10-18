from socket import *
import requests

server_name = '127.0.0.1'
server_port = 12000

client_socket = socket(AF_INET, SOCK_STREAM)
client_socket.connect((server_name, server_port))

file_name = "P2PReceiveTest.txt"


def receive_file():
    file = open('c:/temp/' + file_name, 'wb')
    file_data = client_socket.recv(1024)
    while (file_data):
        print("Receiving...")
        file.write(file_data)
        file_data = client_socket.recv(1024)
    file.close()
    print("Done Sending")
    client_socket.close()


receive_file()
