// See https://aka.ms/new-console-template for more information
bool active = true;

while (active)
{
    Console.Clear();

    Console.WriteLine("1. Add (+)");
    Console.WriteLine("2. Subtract (-)");
    Console.WriteLine("3. Multiply (*)");
    Console.WriteLine("4. Divide (/)");
    Console.WriteLine("0. Exit");


    int input = Convert.ToInt32(Console.ReadLine());
    if (input == 0) active = false;
    double firstNumber;
    double secondNumber;
    double result;

    switch (input)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("First number to add:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(firstNumber);
            Console.WriteLine("Second number to add:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(secondNumber);

            result = Calculator.Calculator.Add(firstNumber, secondNumber);
            Console.WriteLine(result);
            Console.WriteLine("Press anything for menu");
            Console.ReadKey();
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("Number to subtract from:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(firstNumber);
            Console.WriteLine("Second number to subtract:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            result = Calculator.Calculator.Subtract(firstNumber, secondNumber);
            Console.WriteLine(result);
            Console.WriteLine("Press anything for menu");

            Console.ReadKey();

            break;

        case 3:
            Console.Clear();
            Console.WriteLine("First number to multiply:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second number to multiply:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            result = Calculator.Calculator.Multiply(firstNumber, secondNumber);
            Console.WriteLine(result);
            Console.WriteLine("Press anything for menu");

            Console.ReadKey();
            break;

        case 4:
            Console.Clear();
            Console.WriteLine("Number to divide from:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second number to divide:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            if (firstNumber == 0 || secondNumber == 0)
            {
                Console.WriteLine("Try again boy");
                Console.ReadKey();
                break;
            }
            result = Calculator.Calculator.Divide(firstNumber, secondNumber);

            Console.WriteLine(result);
            Console.WriteLine("Press anything for menu");
            Console.ReadKey();
            break;

        default:
            input = 0;
            break;
    }
}

Console.Clear();
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("                                          Thank you for using eCalc2000 v. 1.0");
Console.ReadKey();


