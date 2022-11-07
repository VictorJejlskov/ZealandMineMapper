import threading
from socket import *


serverPort = 12020
serverSocket = socket(AF_INET, SOCK_STREAM)

serverSocket.bind(('', serverPort))
serverSocket.listen(1)

print("Server is hella ready")


def handle_client(this_socket, address):
    while True:
        sentence = this_socket.recv(1024).decode()
        print(sentence)
        if " " in sentence:
            command, words = sentence.split(" ", 1)
        else:
            command = "NothingFound"

        if command.lower() == "exit":
            this_socket.send("Lukker forbindelsen :)".encode())
            break
        elif sentence.lower().strip() == "exit":
            this_socket.send("Lukker forbindelsen :)".encode())
            break
        elif command.lower() == "rvrs":
            this_socket.send(words[::-1].encode())

        elif command.lower() == "lwr":
            this_socket.send(words.lower().encode())

        elif command.lower() == "ppr":
            this_socket.send(words.upper().encode())

        elif command.lower() == "dd":
            return_sentence = "Jeg er en glad lille cowboy, og du skrev: " + words
            this_socket.send(return_sentence.encode())
        else:
            this_socket.send("Available commands are: 'exit', 'rvrs', 'lwr', 'ppr' and 'dd'".encode())
    this_socket.close()


while True:
    connection_socket, addr = serverSocket.accept()
    threading.Thread(target=handle_client, args=(connection_socket, addr)).start()

