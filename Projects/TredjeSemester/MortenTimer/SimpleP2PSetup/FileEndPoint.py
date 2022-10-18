import threading
import requests
from socket import *
from os import listdir
from os.path import isfile, join
mypath = "c:/temp"
onlyfiles = [f for f in listdir(mypath) if isfile(join(mypath, f))]

server_port = 15000
server_socket = socket(AF_INET, SOCK_STREAM)

server_socket.bind(("", server_port))
server_socket.listen(1)


file_dictionary = {
    "Test.txt": "127.0.0.1:5000"
}
print("Server is running.")

def handle_client(handle_socket, address):
    print("Connection Established")
    file_name = handle_socket.recv(1024).decode()
    post(file_name.strip(), address[0] + ":" + str(address[1]))


def post(file_name, address):
    file_dictionary[file_name] = address
    print(file_dictionary)


while True:
    connection_socket, addr = server_socket.accept()
    threading.Thread(target=handle_client, args=(connection_socket, addr)).start()
