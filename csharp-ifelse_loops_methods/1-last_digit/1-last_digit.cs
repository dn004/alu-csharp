using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
	if(number > 5){
	Console.WriteLine($"The last digit of {number} and is greater than 5");
    }
	else if(number == 0){
        Console.WriteLine($"The last digit of {number} and is 0");
    }
	else if(number < 6){
        Console.WriteLine($"The last digit of {number} and is less than 6 and not 0");
    }
}
}