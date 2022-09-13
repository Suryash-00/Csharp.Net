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