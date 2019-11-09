using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Course
    {
        public int CourseID { get; private set; }
        public string CourseName { get; private set; }
        public int ClassSize
        {
            get {
                return Roster.Count;

            }
        }
        public int CourseCredits { get; private set; }
        
        public List<Student>  Roster = new List<Student>();
       

        public Course (int courseID, string courseName, int courseCredits)
        {
            CourseID = courseID;
            CourseName = courseName;
           
            CourseCredits = courseCredits;
            
           
        }

        public List<Student> getRoster()
        {
            return Roster;

        }
        public string getStudentNames()
        {
            string studentNames = "";
            foreach (var student in Roster)
            {
                studentNames = studentNames + "\t"+
                student.Name;
            }
            return studentNames;
        }


    }
}
