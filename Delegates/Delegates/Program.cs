using System;

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