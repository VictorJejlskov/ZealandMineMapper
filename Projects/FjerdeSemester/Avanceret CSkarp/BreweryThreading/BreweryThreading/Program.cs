// See https://aka.ms/new-console-template for more information
using BreweryThreading;

Console.WriteLine("Hello, World!");
BoundedBuffer<Bottle> buffer = new BoundedBuffer<Bottle>(100);

int runtime = 10000;
var task1 = Task.Run(() => {
    for(int i = 0;i < runtime; i++)
    {
        Random rng = new Random();
        buffer.Insert(new Bottle());
        Console.WriteLine("Queue: " + buffer.CountCurrent);
        Thread.Sleep(rng.Next(20));
    }
});

var task2 = Task.Run(() => {
    for (int i = 0; i < runtime; i++)
    {
        Random rng = new Random();
        
        Console.WriteLine(buffer.Remove());
        Thread.Sleep(rng.Next(200));
    }
});


Task.WaitAll(task1, task2);