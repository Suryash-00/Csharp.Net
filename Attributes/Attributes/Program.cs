using System;
/*
using System.Collections.Generic;

public class MainClass
{
    private static void Main()
    {
        Calculator.Add(10, 20);
        Calculator.Add(new List<int>(){ 10,20,30,40});
    }
}

public class Calculator
{
    [Obsolete("Use Add(List<int> Numbers)")]
    public static int Add(int FN, int SN)
    {
        Console.WriteLine(FN + SN);
        return FN + SN;
    }
    public static int Add(List<int> Numbers)
    {
        int sum = 0;
        foreach(int Number in Numbers)
        {
            sum = sum + Number;
        }
        Console.WriteLine(sum);
        return sum;
    }
}
*/

// Reflection

using System.Reflection;
namespace Reflection
{
    public class MainClass
    {
        private static void Main()
        {
            Type T = Type.GetType("Reflection.Customer");   // Reflection=Namespace, Customer=Class
                    // OR
            // Type T= typeof(Customer);
            Console.WriteLine($"Full Name = {T.FullName}");
            Console.WriteLine($"Just the Name = {T.Name}");
            Console.WriteLine($"Just the Namespace = {T.Namespace}");
            Console.WriteLine();

            Console.WriteLine("Properties in Customer");
            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine($"{property.PropertyType.Name}  {property.Name}");
            }
            Console.WriteLine();

            Console.WriteLine("Methods in Customer");
            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine($"{method.ReturnType.Name}  {method.Name}");
            }
            Console.WriteLine();

            Console.WriteLine("Constructors in Customer");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            Console.WriteLine();
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }
        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        
        public void printId()
        {
            Console.WriteLine($"ID = {this.Id}");
        }
        public void printName()
        {
            Console.WriteLine($"Name = {this.Name}");
        }
    }
}