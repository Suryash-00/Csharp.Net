using System;

public class Class1
{
    public static void Even(int i)
    {
        for (int item = 0; item <= i; item++)
        {
            if (item % 2 == 0)
            {
                Console.WriteLine($"{item} is an even number");
            }
            else
            {
                Console.WriteLine($"{item} is not an even number");
            }
        }
    }
    public static void Main()
    {
        Class1.Even(15);
    }
}