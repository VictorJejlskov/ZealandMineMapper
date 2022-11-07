import threading
from socket import *
import ssl

certificatesDirectory = 'C:/certificates/'
privateKeyPath = certificatesDirectory + 'key.pem'
certificatePath = certificatesDirectory + 'certificate.pem'
privateKeyPassword = 'ndu45wbu'
context = ssl.SSLContext(ssl.PROTOCOL_TLS_SERVER)
context.load_cert_chain(certfile=certificatePath, keyfile=privateKeyPath, password=privateKeyPassword)


serverPort = 12000
serverSocket = socket(AF_INET, SOCK_STREAM)
secureSocket = context.wrap_socket(serverSocket, server_side=True)

secureSocket.bind(('', serverPort))
secureSocket.listen(1)

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
    connection_socket, addr = secureSocket.accept()
    threading.Thread(target=handle_client, args=(connection_socket, addr)).start()

