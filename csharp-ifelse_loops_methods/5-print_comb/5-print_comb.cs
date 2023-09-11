using System;
class Program
{
    static void Main()
    {
        for (int i = 0; i <= 99; i++)
        {
           if (i < 99){
           Console.Write($"{i:D2}, ");
			}
           else if (i == 99){
           Console.WriteLine($"{i:D2}");
          
           }
        }
    }
}
