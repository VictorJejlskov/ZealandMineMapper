using System;

namespace WeatherStationV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Barometer myBarometer = new Barometer();
            myBarometer.Pressure = 959;
            Console.WriteLine($"Pressure is: {myBarometer.Pressure} : {myBarometer.WeatherDescription}\n");
            myBarometer.Pressure = 979;
            Console.WriteLine($"Pressure is: {myBarometer.Pressure} : {myBarometer.WeatherDescription}\n");
            myBarometer.Pressure = 999;
            Console.WriteLine($"Pressure is: {myBarometer.Pressure} : {myBarometer.WeatherDescription}\n");
            myBarometer.Pressure = 1000;
            Console.WriteLine($"Pressure is: {myBarometer.Pressure} : {myBarometer.WeatherDescription}\n");
            myBarometer.Pressure = 1019;
            Console.WriteLine($"Pressure is: {myBarometer.Pressure} : {myBarometer.WeatherDescription}\n");
            myBarometer.Pressure = 1039;
            Console.WriteLine($"Pressure is: {myBarometer.Pressure} : {myBarometer.WeatherDescription}\n");
            myBarometer.Pressure = 1059;
            Console.WriteLine($"Pressure is: {myBarometer.Pressure} : {myBarometer.WeatherDescription}\n");
            myBarometer.Pressure = 1079;
            Console.WriteLine($"Pressure is: {myBarometer.Pressure} : {myBarometer.WeatherDescription}\n");
            // The LAST line of code should be ABOVE this line
        }
    }
}