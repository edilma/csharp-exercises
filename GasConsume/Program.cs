using System;

namespace GasConsume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven? ");
            int miles = int.Parse(Console.ReadLine());

            Console.WriteLine("How many gallon have your car used? ");
            float gallons = float.Parse(Console.ReadLine());

            float eficiency = GasConsumed( miles, gallons);

            Console.WriteLine("Your car is performing at a " + eficiency + "  miles per gallon");

        }
        private static float GasConsumed(int miles, float gallons)
        {
            float usedGas = miles / gallons;
            return usedGas;


        }
    }
}
