using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Course LC101 = new Course(101, "Python", 3);

            Student myStudent = new Student();
            myStudent.Name = "Edilma Riano";
            myStudent.StudentId = 882339;
            myStudent.NumberOfCredits = 10;
            myStudent.Gpa = 0;

            LC101.Roster.Add(myStudent);
            LC101.Roster.Add(myStudent);
            LC101.Roster.Add(myStudent);
            LC101.Roster.Add(myStudent);


            Console.WriteLine("{0} {1} {2} {3}", myStudent.Name, myStudent.StudentId, myStudent.NumberOfCredits, myStudent.Gpa);

            Console.WriteLine( LC101.getStudentNames());

            Console.ReadLine();

           

        }
    }
    
        
    /*
  public class Student
    {

        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }
     
        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;

        }
        public Student(string name, int studentId)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }
        

    }
    
    */

    public class Classes
    {

    }
}
