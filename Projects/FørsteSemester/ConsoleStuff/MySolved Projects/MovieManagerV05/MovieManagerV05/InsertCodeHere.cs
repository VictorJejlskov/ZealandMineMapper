using System;

namespace MovieManagerV05
{
    public class InsertCodeHere
    {
        string movieTitle;
        int movieLength;
        string movieMainActor;
        bool isAdultMovie;

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

            Console.WriteLine("Is the movie an adult-only movie? Y/N");
            string userInput = Convert.ToString(Console.ReadLine());
            if (userInput == "Y" || userInput == "y")
            {
                isAdultMovie = true;
            }
            else if (userInput == "N" || userInput == "n")
            {
                isAdultMovie = false;
            }
            else
            {
                Console.WriteLine("You ignored my instructions");
            }

            PrintMovie(movieTitle, movieLength, movieMainActor, isAdultMovie);
            // The LAST line of code should be ABOVE this line
        }
        public void PrintMovie(string printTitle, int printLength, string printMainActor, bool printAdultMovie)
        {
            Console.WriteLine("The name of the movie is: " + printTitle);
            Console.WriteLine("And it runs for: " + printLength + " minutes");
            Console.WriteLine("The main actor/actress of the movie is: " + printMainActor);
            if (printAdultMovie)
            {
                Console.WriteLine("Your movie is an adult-rated movie");
            }
            else
            {
                Console.WriteLine("Your movie is NOT an adult-rated movie");
            }
            
        }
    }
}