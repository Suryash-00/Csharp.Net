using System.Collections.Generic;

namespace Admission_Form.Models
{
    public static class Student_Repository
    {
        private static List<Students> allStudents = new List<Students>();
        public static IEnumerable<Students> AllStudents
        { 
            get { return allStudents; } 
        }
        public static void Create(Students students)
        {
            allStudents.Add(students);
        }
    }
}