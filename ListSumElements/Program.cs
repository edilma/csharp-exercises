using System;

namespace ListSumElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myNumbers = { 8, 5, 6, 4, 6, 3, 8, 2, 4, 5 };

            Console.WriteLine("The sum of the items in the list is {0} ", ListSum( myNumbers));
            Console.ReadLine();


        }

        private static int ListSum(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + i;

            }
            return total;
            
        }


    }




}
