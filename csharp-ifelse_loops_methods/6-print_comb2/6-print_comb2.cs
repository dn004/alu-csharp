using System;
class Program
{
    static void Main()
    {
        int count = 0;
        for (int i = 0; i <= 8; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                Console.Write($"{i}{j}");
                if (count < 44)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write("\n");
                }
                count++;
            }
        }
    }
}
