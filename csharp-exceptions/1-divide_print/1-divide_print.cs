using System;

class Int
{
    static void Main(string[] args)
    {
        int a, b;

        a = 4;
        b = 3;
        Int.divide(a, b);
        Console.WriteLine();

        a = 9;
        b = 0;
        Int.divide(a, b);
    }
    public static void divide(int a, int b)
    {
        int result = 0;
        try
        {
            result = a/b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {result}");
        }

    }
}