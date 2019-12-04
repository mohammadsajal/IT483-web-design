using System;

namespace lab_03_SAJAL
	{
		class Program
		{

			public static double validate(double bal, double amount)
			{
				//deposit
				if (amount > 0)
				{
					return bal + amount;
				}

				//withdraw
				if (bal < amount)
				{
					return bal;
				}
				return bal - amount;
			}

			public static void Main(string[] args)
			{

				double curBal = 45.32;

				double amount;
				Console.Write("Please enter a amount to update account by $");
				amount = Int32.Parse(Console.ReadLine());
				Console.Write("\n");

				Console.Write("Customer\'s balance (before transaction) = $");
				Console.WriteLine(curBal + "\n");
				Console.Write("Requested update amount = $");
				Console.WriteLine(amount + "\n");

				double actAmount;
				actAmount = validate(curBal, amount);
				curBal += actAmount;

				Console.Write("Actual update amount = $");
				Console.WriteLine(actAmount + "\n");
				Console.Write("Customer\'s balance (after transaction) = $");
				Console.WriteLine(curBal + "\n");

				Console.WriteLine("\nThank you and good-bye!\n");
			}

		}
	}

