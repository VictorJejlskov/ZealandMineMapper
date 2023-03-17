// See https://aka.ms/new-console-template for more information
using MyJsonLib;
using Newtonsoft.Json;
using ReflectionLib;
using System.Text;

Console.WriteLine("Hello, World!");
Clerk c1 = new Clerk("Martin", 1993, new List<string>() { "People skills", "Anger Management", "Dog Walker", "Masturbation"});
Clerk c2 = new Clerk("Frederik", 1998, new List<string>() { "Memes", "Shittalking", "Toxicity"});
Clerk c3 = new Clerk("Mads", 2004, new List<string>() { "KLIKKITYCLACK "});

Manager m1 = new Manager("Victor", 1997, new List<Person> { c1, c2, c3 });

//TryReflection(m1);

void TryReflection(Object obj)
{

    Type t = obj.GetType();
    //Name
    var name = t.Name;
    Console.WriteLine(" === NAME ===");
    Console.WriteLine("Name: " + name);
    //Type
    Console.WriteLine(" === TYPES ===");
    Console.WriteLine("Is Abstract: " + t.IsAbstract);
    Console.WriteLine("Is Class: " + t.IsClass);
    Console.WriteLine("Is Interface: " + t.IsInterface);
    Console.WriteLine("Base Type: " + t.BaseType);

    //Properties
    Console.WriteLine(" === PROPS ===");
    foreach (var prop in t.GetProperties())
    {
        Console.WriteLine(prop);
    }


    //Methods
    Console.WriteLine(" === METHODS ===");
    foreach (var method in t.GetMethods())
    {
        Console.WriteLine(method);
    }

    while(t.BaseType !is Object)
    {
        Console.WriteLine();
        Console.WriteLine();

        t = t.BaseType;
        var name1 = t.Name;
        Console.WriteLine(" === NAME ===");
        Console.WriteLine("Name: " + name1);
        //Type
        Console.WriteLine(" === TYPES ===");
        Console.WriteLine("Is Abstract: " + t.IsAbstract);
        Console.WriteLine("Is Class: " + t.IsClass);
        Console.WriteLine("Is Interface: " + t.IsInterface);
        Console.WriteLine("Base Type: " + t.BaseType);

        //Properties
        Console.WriteLine(" === PROPS ===");
        foreach (var prop in t.GetProperties())
        {
            Console.WriteLine(prop);
        }


        //Methods
        Console.WriteLine(" === METHODS ===");
        foreach (var method in t.GetMethods())
        {
            Console.WriteLine(method);
        }

    }
    
}

//string output = JsonConvert.SerializeObject(c1);
//Console.WriteLine(output);

//string output1 = JsonConvert.SerializeObject(m1);
//Console.WriteLine(output1);

var result = MyJsonConverter.Serialize(c1);
Console.WriteLine(result);