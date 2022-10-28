using System;

namespace Enums_Tutorial
{
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;

            /*
            Console.WriteLine(Days.Monday);

            Days myDay = (Days)1;

            int value= (int)Days.Friday;

            Console.WriteLine(value);
            Console.WriteLine(myDay);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            */

            /*
            Console.WriteLine("Enter your name");
            string name= Console.ReadLine();

            Console.WriteLine("Enter your day of birth");
            int value= int.Parse(Console.ReadLine());

            Days myDay = (Days)value;

            Console.WriteLine($"My name is {name} and my day of birth is {myDay}");
            */

            string[] members= (string[])Enum.GetNames(typeof(Days));

            foreach (string member in members)
            {
                Console.WriteLine(member);
            }
            
            int[] values = (int[])Enum.GetValues(typeof(Days));

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}