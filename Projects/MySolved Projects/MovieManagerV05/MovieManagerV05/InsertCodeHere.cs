using System;

namespace MovieManagerV05
{
    public class InsertCodeHere
    {
        string movieTitle;
        int movieLength;
        string movieMainActor;

        public void MyCode()
        {
            Console.Clear();
            // The FIRST line of code should be BELOW this line

            Console.WriteLine("Please write the name of the movie!");
            movieTitle = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("How long does the movie run for, in minutes?");
            movieLength = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Who's the main actor/actress?");
            movieMainActor = Console.ReadLine();
            Console.Clear();

            PrintMovie();
            // The LAST line of code should be ABOVE this line
        }
        public void PrintMovie()
        {
            Console.WriteLine("The name of the movie is: " + movieTitle);
            Console.WriteLine("And it runs for: " + movieLength + " minutes");
            Console.WriteLine("The main actor/actress of the movie is: " + movieMainActor);
        }
    }
}