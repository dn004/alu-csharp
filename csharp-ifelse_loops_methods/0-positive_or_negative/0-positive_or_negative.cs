using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
	if (number > 0){
	Console.WriteLine($"{number}is positive");
    }
	else if (number < 0){
        Console.WriteLine($"{number}is negative");
    }
<<<<<<< HEAD
	else{
        Console.WriteLine("is zero");
=======
	else if (number == 0){
        Console.WriteLine($"{number}is zero");
>>>>>>> 21b3698b401c938f003a2bbaca033d68d985180c
    }
}
}
