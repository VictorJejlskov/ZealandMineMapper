from socket import *

serverName = '10.200.130.71'
serverPort = 12000
clientSocket = socket(AF_INET, SOCK_STREAM)
clientSocket.connect((serverName,serverPort))
while True:
    sentence = input('Input: ')
    clientSocket.send(sentence.encode())
    modifiedSentence = clientSocket.recv(1024)
    print(modifiedSentence.decode())
    if sentence == "exit":
        clientSocket.close()
        break