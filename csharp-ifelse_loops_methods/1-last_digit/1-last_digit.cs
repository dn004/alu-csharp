using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastnumber = number % 10;
	if(lastnumber > 5){
	Console.WriteLine($"The last digit of {number} is {lastnumber} and is greater than 5");
    }
	else if(lastnumber == 0){
        Console.WriteLine($"The last digit of {number} is {lastnumber} and is 0");
    }
	else if(lastnumber < 6){
        Console.WriteLine($"The last digit of {number} is {lastnumber} and is less than 6 and not 0");
    }
}
}