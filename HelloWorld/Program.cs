using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, What is your name? ");
            string name = Console.ReadLine();
            Greeting( name);




        }
        private static void Greeting(string name) 
        {
            Console.WriteLine("Hello " + name);

        }
    }
}
