from socket import *
import requests


from urllib3.exceptions import InsecureRequestWarning
from urllib3 import disable_warnings

disable_warnings(InsecureRequestWarning)


serverPort = 12000
serverSocket = socket(AF_INET, SOCK_DGRAM)
serverSocket.bind(('', serverPort))
print("The server is ready to receive")


def post_speed_record(client_message):
    url = "https://localhost:7271/SpeedTraps"

    sensor_name, speed = client_message.split(" |-| ")
    data = {"SensorName": sensor_name, "Speed": speed}
    response = requests.post(url, json=data, verify=False)
    print(response)
    print(response.json())


while True:
    message, clientAddress = serverSocket.recvfrom(2048)
    print(message)
    post_speed_record(message.decode())