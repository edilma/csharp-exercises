using System;
using System.Collections.Generic;
using System.Text;

namespace School
{

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

        public Student()
        {
            this.Name = Name;
            this.StudentId = StudentId;
            this.NumberOfCredits = NumberOfCredits;
            this.Gpa = Gpa;

        }


    }
}
