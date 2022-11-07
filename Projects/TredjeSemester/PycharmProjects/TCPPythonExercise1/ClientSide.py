from socket import *
import ssl

context = ssl.SSLContext(ssl.PROTOCOL_TLSv1_2)

serverName = '127.0.0.1'
serverPort = 12000
clientSocket = socket(AF_INET, SOCK_STREAM)
secureSocket = context.wrap_socket(clientSocket)
secureSocket.connect((serverName, serverPort))
while True:
    sentence = input('Input: ')
    secureSocket.send(sentence.encode())
    modifiedSentence = secureSocket.recv(1024)
    print(modifiedSentence.decode())
    if sentence == "exit":
        secureSocket.close()
        break

