using System;

namespace AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle ");
            string s = Console.ReadLine();
            double result;


            if (Double.TryParse(s, out result))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            double radius = Double.Parse(Console.ReadLine());
            double area = AreaCircle(radius);
            Console.WriteLine($"The area of your circle is {area}");
            Console.ReadLine();

        }

        private static bool TryParse(string s, out double result)
        {
            throw new NotImplementedException();
        }

        private static double AreaCircle(double radius)
        {
            double area = 3.141516 * radius * radius;
            return area;

        }

        
    }
}
