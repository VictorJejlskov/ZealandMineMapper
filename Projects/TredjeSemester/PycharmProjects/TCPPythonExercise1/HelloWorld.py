from socket import *
serverPort = 12000
serverSocket = socket(AF_INET, SOCK_STREAM)

serverSocket.bind(('', serverPort))
serverSocket.listen(1)

print("Server is hella ready")
while True:
    connectSocket, addr = serverSocket.accept()
    while True:
        sentence = connectSocket.recv(1024).decode()
        print(sentence, addr)
        capitalizedsentence = sentence.upper()
        connectSocket.send(capitalizedsentence.encode())
        if sentence.strip() == "exit":
            print("connection closed")
            connectSocket.close()
            break
        if sentence.strip() == "":
            print("connection closed")
            connectSocket.close()
            break
