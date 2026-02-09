using System;
	Console.Write("Enter amount in USD: ");
	double usdAmount = double.Parse(Console.ReadLine());

	Console.Write("Enter exchange rate from USD to EUR: ");
	double exchangeRate = double.Parse(Console.ReadLine());

	double eurAmount = usdAmount * exchangeRate;

	Console.WriteLine("Amount in EUR: " + eurAmount);