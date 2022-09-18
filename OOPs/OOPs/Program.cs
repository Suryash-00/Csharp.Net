/*
using System;
public class Employee
{
    public int id;
    public String name;
    public float salary;
    public void insert(int i, String n, float s)
    {
        id = i;
        name = n;
        salary = s;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();
        e1.insert(101, "Suryash", 890000f);
        e2.insert(102, "Nikhilesh", 490000f);
        e1.display();
        e2.display();

    }
}
*/
/*
using System;

namespace CsharpDestructor
{

    class Person
    {

        public Person()
        {
            Console.WriteLine("Constructor called.");
        }

        // destructor
        ~Person()
        {
            Console.WriteLine("Destructor called.");
        }

        public static void Main(string[] args)
        {

            //creates object of Person
            Person p1 = new Person();
        }
    }
}
*/

/*
        // this keyword
using System;
public class Employee
{
    public int id;
    public String name;
    public float salary;
    public Employee(int id, String name, float salary)
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Employee e1 = new Employee(101, "Sonoo", 890000f);
        Employee e2 = new Employee(102, "Mahesh", 490000f);
        e1.display();
        e2.display();

    }
}
*/
        //static constructor
using System;
/*
public class Account
{
    public int id;
    public String name;
    public static float rateOfInterest;
    public Account(int id, String name)
    {
        this.id = id;
        this.name = name;
    }
    static Account()
    {
        rateOfInterest = 9.5f;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + rateOfInterest);
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Account a1 = new Account(101, "Sonoo");
        Account a2 = new Account(102, "Mahesh");
        a1.display();
        a2.display();

    }
}
*/
//Ineritance
/*
class Vehicle
{
    public string brand = "Ford";

    public void honk()
    {
        Console.WriteLine("pee pee");
    }
}
class Car:Vehicle
{
    public string modelName = "Mustang";
}
class Program
{
    static void Main(string[] args)
    {
        Car myCar= new Car();
        myCar.honk();
        Console.WriteLine($"{myCar.brand} {myCar.modelName}");
    }
}
*/
//Polymorphism
/*
class Animal  // Base class (parent) 
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object
        Animal myDog = new Dog();  // Create a Dog object

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }
}
*/

/*
        //Abstraction
// Abstract class
abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig(); // Create a Pig object
        myPig.animalSound();  // Call the abstract method
        myPig.sleep();  // Call the regular method
    }
}
*/

        //Polymorphism 2

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";
    
    public virtual void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}
public class PartTimeEmployee: Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName} - Part Time Employee");
    }
}
public class FullTimeEmployee: Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName} - Full Time Employee");
    }
}
public class TemporaryEmployee: Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName} - Temporary Employee");
    }
}

public class Program
{
    public static void Main()
    {
        Employee[] employees = new Employee[4];
        employees[0]= new Employee();
        employees[1]= new PartTimeEmployee();
        employees[2]= new FullTimeEmployee();
        employees[3]= new TemporaryEmployee();

        foreach (Employee e in employees)
        {
            e.PrintFullName();
        }
    }
}