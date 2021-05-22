using System;
namespace Hello_World_App
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteHello();
            Console.ReadLine();
        }

        private static void WriteHello() => Console.WriteLine("Hello World!");
    }
}
