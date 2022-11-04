from socket import *
serverName = '255.255.255.255'
serverPort = 12000
clientSocket = socket(AF_INET, SOCK_DGRAM)
clientSocket.setsockopt(SOL_SOCKET, SO_BROADCAST, 1)


def get_number():
    choice = "wrong"
    while not choice.isdigit():
        choice = input("Input the speed, numbers only: ")

        if not choice.isdigit():
            print("Incorrect, numbers only.")
        elif int(choice) >= 500:
            print("Number has to be between 0 and 500")
            choice = "wrong"
        else:
            return choice


sensor_name = input("Input the name of the sensor: ")

speed = get_number()

message = sensor_name + " |-| " + speed
clientSocket.sendto(message.encode(), (serverName, serverPort))
modifiedMessage, serverAddress = clientSocket.recvfrom(2048)
print(modifiedMessage.decode())
clientSocket.close()