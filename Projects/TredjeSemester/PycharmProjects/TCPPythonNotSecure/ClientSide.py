from socket import *

serverName = '127.0.0.1'
serverPort = 12020
clientSocket = socket(AF_INET, SOCK_STREAM)
clientSocket.connect((serverName, serverPort))
while True:
    sentence = input('Input: ')
    clientSocket.send(sentence.encode())
    modifiedSentence = clientSocket.recv(1024)
    print(modifiedSentence.decode())
    if sentence == "exit":
        clientSocket.close()
        break

