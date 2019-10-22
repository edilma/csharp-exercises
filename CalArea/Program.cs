using System;

namespace CalArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Calculate Area Program");
            Console.WriteLine("What is the length of the rectangle? ");
            int side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the wide of the rectangle? ");
            int side2 = int.Parse(Console.ReadLine());

            int area = calculateArea(side1, side2);

            Console.WriteLine("The area of your rectangle is " + area);


        }
        private static int calculateArea(int lenght, int wide)
        {
            int area = lenght * wide;
            return area;

        }
    }


}
