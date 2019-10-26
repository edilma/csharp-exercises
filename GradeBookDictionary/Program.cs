using System;
using System.Collections.Generic;

namespace GradeBookDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentId;
            string studentName;

            Console.WriteLine("To enter a new student information press enter or choose x to exit");


            Dictionary<int, string> studentRoast = new Dictionary<int, string>();

            
            Console.WriteLine("What is your student number");

            studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your name?" );

            studentName = Console.ReadLine();

            studentRoast.Add(studentId, studentName);
            

            Console.WriteLine("YOur name is {0}, welcome " ,studentRoast[studentId]);
            Console.ReadLine();

    
            
        }
        /*
         private static Dictionary<int, string> ReadStudents(Dictionary<int, string> studentRoast)
        {
            Console.WriteLine("What is your student number");
            studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your name?" );
            studentName = Console.ReadLine();
            studentRoast.Add(studentId, studentName);
        }
        */
    }
}
