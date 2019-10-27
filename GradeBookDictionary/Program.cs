using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBookDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */
            Dictionary<int, string> studentRoast = new Dictionary<int, string>();

            //Console.WriteLine("To enter a new student name or press enter to exit");
            //string wantToContinue = Console.ReadLine();
            string wantToContinue;

            do
            {
                askForStudents(studentRoast);
                Console.WriteLine("Do you have more students?  Y/N");
                wantToContinue = Console.ReadLine();

            } while (wantToContinue !="N" );

            printStudentRoast(studentRoast);


        }
        
         private static void askForStudents(Dictionary<int, string> studentRoast)
        {
            //int studentId;
            //string studentName;
            Console.WriteLine("What is your student number");
            int studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your name?" );
            string studentName = Console.ReadLine();
            studentRoast.Add(studentId, studentName);
            //return studentRoast;
        }

        private static void printStudentRoast(Dictionary<int, string> studentRoaster)
        {
            //int studentId;
            //string studentName;
            StringBuilder myRoster = new StringBuilder();
            /*
            foreach (KeyValuePair<int, string> student in studentRoaster)
            {
                
                Console.WriteLine(student.Key + "\t"
                    + student.Value);
            }
            */
            foreach (KeyValuePair<int, string> student in studentRoaster)
            {
                myRoster.Append(student.Key);
                myRoster.Append("\t");
                myRoster.Append(student.Value);
                myRoster.Append("\n");
            }
            Console.WriteLine(myRoster);
        }
    }
}
