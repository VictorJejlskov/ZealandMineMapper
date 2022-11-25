from socket import *


serverPort = 8500
serverSocket = socket(AF_INET, SOCK_DGRAM)
serverSocket.bind(('', serverPort))
print("The server is ready to receive")


while True:
    message, adr = serverSocket.recvfrom(2048)
    print(message.decode(), adr)
