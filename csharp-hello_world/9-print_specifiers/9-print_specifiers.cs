ï»¿using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLIne("Percent: " + percent.ToString("#0.##%"));
		Console.WriteLine("Currency: " + currency.ToString("C2"));	
	}
}
