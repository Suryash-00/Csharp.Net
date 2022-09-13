/*
using System;
public class ArrayExample
{
    static void printMin(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        Console.WriteLine("Minimum element is: " + min);
    }
    public static void Main(string[] args)
    {
        int[] arr1 = { 25, 10, 20, 15, 40, 50 };
        int[] arr2 = { 12, 23, 44, 11, 54 };

        printMin(arr1);//passing array to function  
        printMin(arr2);
    }
}
*/
/*
using System;  
public class MultiArrayExample
{
    public static void Main(string[] args)
    {
        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//declaration and initialization  

        //traversal  
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();//new line at each row  
        }
    }
}
*/
/*
using System;

namespace CSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an array  
            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            // Creating an empty array  
            int[] arr2 = new int[6];

            // Displaying length of array  
            Console.WriteLine("length of first array: " + arr.Length);
            // Sorting array  
            Array.Sort(arr);
            Console.Write("First array elements: ");
            // Displaying sorted array  
            PrintArray(arr);
            
            // Finding index of an array element  
            Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr, 25));

            // Coping first array to empty array  
            Array.Copy(arr, arr2, arr.Length);
            Console.Write("Second array elements: ");

            // Displaying second array  
            PrintArray(arr2);
            Array.Reverse(arr);
            Console.Write("\nFirst Array elements in reverse order: ");
            PrintArray(arr);
        }
        // User defined method for iterating array elements  
        static void PrintArray(int[] arr)
        {
            foreach (Object elem in arr)
            {
                Console.Write(elem + " ");
            }
        }
    }
}
*/