import threading
import requests
from socket import *

server_port = 12000
server_socket = socket(AF_INET, SOCK_STREAM)

server_socket.bind(("", server_port))
server_socket.listen(1)

file_name = "P2PTransferTest.txt"

print("Server is listening")

def handle_client(connection_socket, address):
    print("Connection Established")

    file = open('C:/temp/' + file_name, 'rb')
    file_data = file.read(1024)
    while (file_data):
        print('Sending...')
        connection_socket.send(file_data)
        file_data = file.read(1024)
    file.close()
    print("Done Sending")
    #connection_socket.shutdown(socket.SHUT_WR)
    connection_socket.close()


while True:
    connection_socket, addr = server_socket.accept()
    threading.Thread(target=handle_client, args=(connection_socket, addr)).start()