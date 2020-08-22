using System;

namespace calculator
{
	
	class Calculator
	{
		static string Addition(string output)
		{
			Console.WriteLine(output);
			Console.WriteLine("Please Type a number");
			int input_one = int.Parse(Console.ReadLine());
			Console.WriteLine("+");
			int input_two = int.Parse(Console.ReadLine());
			int sum = input_one + input_two;
			Console.WriteLine(string.Format("The sum of the two numbers is {0}...", sum)); 
			Console.ReadKey();
			return output;
		}
		static string Subtraction(string output)
		{
			Console.WriteLine(output);
			Console.WriteLine("Please Type a number");
			int input_one = int.Parse(Console.ReadLine());
			Console.WriteLine("-");
			int input_two = int.Parse(Console.ReadLine());
			int diff = input_one - input_two;
			Console.WriteLine(string.Format("The difference of the two numbers is {0}...", diff)); 
			return output;
		}
		
		static string Multiplication(string output)
		{
			Console.WriteLine(output);
			Console.WriteLine("Please Type a number");
			int input_one = int.Parse(Console.ReadLine());
			Console.WriteLine("*");
			int input_two = int.Parse(Console.ReadLine());
			int product = input_one * input_two;
			Console.WriteLine(string.Format("The product of the two numbers is {0}...", product)); 
			return output;
		}
		static string Division(string output)
		{
			Console.WriteLine(output);
			Console.WriteLine("Please Type a number");
			decimal input_one = int.Parse(Console.ReadLine());
			Console.WriteLine("/");
			decimal input_two = int.Parse(Console.ReadLine());
			decimal quotient = input_one / input_two;
			Console.WriteLine(string.Format("The qoutient of the two numbers is {0}...", quotient)); 
			return output;
		}
		//Making calculator functions to add/sub/mult/div two numbers given by the user and print the results
		//bonus for making the result inclue remainder for division
		//need to debug input errors for inputing non integers
		//change wording
		static void Main(string[] args)
		{
			
			Addition("What is the first number number you would like to add?");
			Subtraction("What is the number you want to subtract from?");
			Multiplication("What is the first number to want to multiply.");
			Division("What is the number you want to divide?")
			Console.ReadKey();
		}
	}
	
}