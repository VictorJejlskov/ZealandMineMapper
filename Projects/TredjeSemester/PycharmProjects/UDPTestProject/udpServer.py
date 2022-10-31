from socket import *
import requests

serverPort = 12000
serverSocket = socket(AF_INET, SOCK_DGRAM)
serverSocket.bind(('', serverPort))
print("The server is ready to receive")


def post_speed_record():
    url = "indsætURLHER"
    data = {"SensorName": "VictorsSpeedTrap", "Speed": 80}
    response = requests.post(url, json=data)
    print(response)


while True:
    message, clientAddress = serverSocket.recvfrom(2048)
    post_speed_record()