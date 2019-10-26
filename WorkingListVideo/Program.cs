using System;
using System.Collections.Generic;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        { /*
            Car myCar = new Car();
            myCar.VIN = "15";
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            /*
            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make , 
                myCar.Model, 
                myCar.Year,
                myCar.Color);
            */
            /*
            Car car1 = new Car();
            car1.VIN = "A16";
            car1.Make = "Honda";
            car1.Model = "Accord";
            car1.Year = 2014;
            car1.Color = "Bue";

            Car car2 = new Car();
            car2.VIN = "B17";
            car2.Make = "Lexus";
            car2.Model = "S3";
            car2.Year = 2016;
            car2.Color = "Black";
            */
            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C} is the value of your car", value);

            //Console.WriteLine("The value of my car is {0:C} ", myCar.DetermineMakretValue());
            /*
            List<Car> myList = new List<Car>();
            myList.Add(myCar);
            myList.Add(car1);
            myList.Add(car2);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

           
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(myCar.VIN, myCar);
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B17"].Make);
            */

            //string[] names = { "Bob", "Streve", "Brian", "Chuck" };

            /*
              Object initializer - No need of a constructor
            Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C13" };
            Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D14" };
            */

            //Collection initializer

            List<Car> myList = new List<Car>() {

                new Car{Make = "Oldsmobile", Model = "Cutlas Supreme" , VIN="E5"};

            new Car { Make = "Nissan", Model = "Altima", VIN = "F16" } };
        }



        Console.ReadLine();
            }
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;

            return carValue;

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMakretValue()
        {
            decimal carValue;
            if (Year > 1990)

            {
                carValue = 10000;

            }
            else
            {
                carValue = 2000;
            }
            return carValue;

        }

    }


}
