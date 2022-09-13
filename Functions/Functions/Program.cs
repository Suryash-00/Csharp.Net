/*
using System;

// Call By Value
namespace Functions
{
    class Program
    {
        // User defined function  
        public void Show(int val)
        {
            val = val*val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before calling the function " + val);
            program.Show(val); // Calling Function by passing value            
            Console.WriteLine("Value after calling the function " + val);
        }
    }
}
*/
using System;
/*      // Call By Reference
namespace Functions
{
    class Program
    {
        // User defined function  
        public void Show(ref int val)
        {
            val = val*val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before calling the function " + val);
            program.Show(ref val); // Calling Function by passing reference            
            Console.WriteLine("Value after calling the function " + val);
        }
    }
}
*/
namespace Functions
//Out Parameter is useful when passing more than 1 value.
{
    class Program
    {
        // User defined function  
        public void Show(out int a, out int b) // Out parameter  
        {
            int square = 5;
            a = square;
            b = square;
            // Manipulating value  
            a = a*a;
            b = b*b;
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int val1 = 50, val2 = 100;
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before passing \n val1 = " + val1 + " \n val2 = " + val2);
            program.Show(out val1, out val2); // Passing out argument  
            Console.WriteLine("Value after passing \n val1 = " + val1 + " \n val2 = " + val2);
        }
    }
}