using System;

namespace RoleplayMyRoleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            SandboxCode theCode = new SandboxCode();
            theCode.MyCode();

            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}
