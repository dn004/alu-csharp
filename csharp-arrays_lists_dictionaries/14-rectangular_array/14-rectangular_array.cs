using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] myArray = new int[5, 5];

        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                myArray[row, col] = 0;
            }
        }

        myArray[2, 2] = 1;

        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                Console.Write(myArray[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
