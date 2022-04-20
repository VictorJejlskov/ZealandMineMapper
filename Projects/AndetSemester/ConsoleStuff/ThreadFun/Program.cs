using System;
using System.Threading;

namespace ThreadFun
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread threadSkeet = new Thread(() => Print("Skeet", 5));
            threadSkeet.Name = "Skeet";
            threadSkeet.Priority = ThreadPriority.Lowest;
            threadSkeet.Start();

            Thread threadDab = new Thread(() => Print("Dab", 5));
            threadDab.Name = "Dab";
            threadDab.Priority = ThreadPriority.Highest;
            threadDab.Start();

            Thread threadYeet = new Thread(() => Print("Yeet", 5));
            threadYeet.Name = "Yeet";
            threadYeet.Priority = ThreadPriority.Lowest;
            threadYeet.Start();

            Thread threadMuwhaha = new Thread(() => Print("Muwhaha", 5));
            threadMuwhaha.Name = "Muwhaha";
            threadMuwhaha.Priority = ThreadPriority.Highest;
            threadMuwhaha.Start();

            threadSkeet.Join();
            threadDab.Join();
            threadYeet.Join();
            threadMuwhaha.Join();


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }
        public static void Print(string message, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i + " - " + message + " - " + Thread.CurrentThread.Name);
                Thread.Sleep(200);
            }
            
        }
    }
}
