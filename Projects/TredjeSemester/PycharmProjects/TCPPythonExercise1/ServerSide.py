import threading
from socket import *
serverPort = 12000
serverSocket = socket(AF_INET, SOCK_STREAM)

serverSocket.bind(('', serverPort))
serverSocket.listen(1)

print("Server is hella ready")

def handle_client(socket, address):
    while True:
        sentence = socket.recv(1024).decode()
        print(sentence)
        if " " in sentence:
            command, words = sentence.split(" ")
        else:
            command = "NothingFound"

        if command.lower() == "exit":
            socket.send("Lukker forbindelsen :)".encode())
            break
        elif sentence.lower().strip() == "exit":
            socket.send("Lukker forbindelsen :)".encode())
            break
        elif command.lower() == "rvrs":
            socket.send(words[::-1].encode())

        elif command.lower() == "lwr":
            socket.send(words.lower().encode())

        elif command.lower() == "ppr":
            socket.send(words.upper().encode())

        elif command.lower() == "dd":
            return_sentence = "Jeg er en glad lille cowboy, og du skrev: " + words
            socket.send(return_sentence.encode())
        else:
            socket.send("Available commands are: 'exit', 'rvrs', 'lwr', 'ppr' and 'dd'".encode())
    socket.close()

while True:
    connection_socket, addr = serverSocket.accept()
    threading.Thread(target=handle_client, args=(connection_socket, addr)).start()
