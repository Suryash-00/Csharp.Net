using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

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
        List<Student> students = new List<Student>();

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
            List<int> numbers = new List<int>() { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            var nums = from i in numbers where i > 44 select i;

            foreach(var i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}