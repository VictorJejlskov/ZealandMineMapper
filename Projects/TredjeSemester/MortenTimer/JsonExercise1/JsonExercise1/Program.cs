// See https://aka.ms/new-console-template for more information

using System.IO.Compression;
using JsonExercise1.Models;
using System.Text.Json;

Car car = new Car("Audi", "A8", "Green", 3000);
Car car1 = new Car("Hyundai", "Ionic 5", "Sort", 2500);
Car car2 = new Car("BMW", "X5", "Blå", 6400);
Console.WriteLine(car);
List<Car> carList = new List<Car>();
carList.Add(car);
carList.Add(car1);
carList.Add(car2);

string testString = JsonSerializer.Serialize(car);
Console.WriteLine(testString);

Console.WriteLine();
string listString = JsonSerializer.Serialize(carList);
Console.WriteLine(listString);

Console.WriteLine();
Car car3 = JsonSerializer.Deserialize<Car>(testString);
Console.WriteLine(car3);

Console.WriteLine();
foreach (var Obj in JsonSerializer.Deserialize<List<Car>>(listString))
{
    Console.WriteLine(Obj);
}

Employee employee1 = new Employee("Søren", 50000, 15, new List<string>() { "President", "Mechanic" });
Employee employee2 = new Employee("Heinrich", 2000, 6, new List<string>() { "Vice-President", "Mechanic" });
List<Employee> employeeList = new List<Employee>() { employee1, employee2 };

Dealership dealership = new Dealership("Bilshoppen", "Maglegårdsvej 2", carList, employeeList);
string dealershipJson = JsonSerializer.Serialize(dealership);
Console.WriteLine(dealership);
Console.WriteLine(dealershipJson);