from socket import *
import requests
import ssl


certificatesDirectory = 'C:/certificates/'
privateKeyPath = certificatesDirectory + 'key.pem'
certificatePath = certificatesDirectory + 'certificate.pem'
privateKeyPassword = "ndu45wbu"
context = ssl.SSLContext(ssl.PROTOCOL_TLS_SERVER)
context.load_cert_chain(certfile=certificatePath, keyfile=privateKeyPath, password=privateKeyPassword)


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
    secureSocket = context.wrap_socket(serverSocket, server_side=True)
    message, clientAddress = secureSocket.recvfrom(2048)
    print(message)
    post_speed_record(message.decode())
