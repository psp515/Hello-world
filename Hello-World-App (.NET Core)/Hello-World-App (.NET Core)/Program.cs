using System;
namespace Hello_World_App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("You are Welcome!");
            Console.WriteLine();
            WriteHello();
            Console.WriteLine("Hello World x 5?");
            WriteHello_n(5);
        }

        private static void WriteHello() => Console.WriteLine("Hello World!");
        private static void WriteHello_n(int n) 
        { 
            for (int i=0;i<n ;i++ )
                Console.WriteLine("{0}. Hello World!",n);
        }
    }
}
