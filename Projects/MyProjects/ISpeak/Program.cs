using System;

namespace ISpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            ISpeak speaker = new Dog();
            Console.WriteLine(speaker.Speak());
            speaker = new Cow();
            Console.WriteLine(speaker.Speak());
            speaker = new Philosopher();
            Console.WriteLine(speaker.Speak());

            Dog fiddo = new Dog();
            //fiddo = new Cow();
            //Fungerer ikke, fordi det er ikke en abstract class, men et interface.
            

            //Speaker.Think fungerer ikke, fordi den skal først type castes.
            Console.WriteLine(((Philosopher)speaker).Think());

        }
    }
}
