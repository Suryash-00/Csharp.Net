using System;

/*
public delegate void HelloFunction(string message);
class Program
{
    public static void Main()
    {
        HelloFunction del = new HelloFunction(Hello);
        del("Hello Delegate");
    }

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}
*/

using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        List<Employee> empList= new List<Employee>();
        empList.Add(new Employee() { ID= 101, Name= "Suri", Salary= 10000, Experience=3});
        empList.Add(new Employee() { ID = 101, Name = "Rahul", Salary = 18000, Experience = 4 });
        empList.Add(new Employee() { ID = 101, Name = "Sagar", Salary = 15000, Experience = 5 });
        empList.Add(new Employee() { ID = 101, Name = "Yash", Salary = 20000, Experience = 2 });

        isPromotable isPromo = new isPromotable(promote);

        Employee.promoteEmployee(empList, isPromo);
    }
    public static bool promote(Employee empl)
    {
        if (empl.Experience>=4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

delegate bool isPromotable(Employee emp);
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void promoteEmployee(List<Employee> employeeList, isPromotable isEligible)
    {
        foreach(Employee employee in employeeList)
        {
            if(isEligible(employee))
            {
                Console.WriteLine($"{employee.Name} promoted");
            }
        }
    }
}