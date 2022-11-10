from socket import *
import threading

server_name = "127.0.0.1"

def send_request(thisNumber):
    client_socket = socket(AF_INET, SOCK_STREAM)
    try:
        client_socket.connect((server_name, thisNumber))
        print("Port: " + thisNumber.__str__() + " was open")
        client_socket.close()
    except:
        test = "test"


for x in range(65536):
    threading.Thread(target=send_request, args=(x,)).start()
