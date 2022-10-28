using System;
using System.Collections.Generic;
using System.Collections;

namespace IEnumerable_Part1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Standard { get; set; }
    }

    class School
    {
        List<Student> students= new List<Student>();

        public void Add(Student s)
        {
            students.Add(s);
        }
        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std1= new Student();
            std1.Id = 1;
            std1.Name = "Suri";
            std1.Standard = 12;

            Student std2 = new Student();
            std2.Id = 2;
            std2.Name = "Yash";
            std2.Standard = 11;

            Student std3 = new Student();
            std3.Id = 3;
            std3.Name = "Daksh";
            std3.Standard = 10;

            School students= new School();
            students.Add(std1);
            students.Add(std2);
            students.Add(std3);

            foreach(Student s in students)
            {
                Console.WriteLine($"{s.Id}, {s.Name}, {s.Standard}");
            }
        }
    }
}