using System;

namespace calculator
{
	
	class Calculator
	{
		
		
		static int Addition(int opta, int optb)
		{
			return opta + optb;
		}
		static int Subtraction(int opta, int optb)
		{
			return opta - optb;
		}
		
		static int Multiplication(int opta,int optb)
		{
			return opta * optb;
		}
		static int Division(int opta, int optb)
		{
			return opta / optb;
		}
		//Making calculator functions to add/sub/mult/div two numbers given by the user and print the results
		//bonus for making the result inclue remainder for division
		//need to debug input errors for inputing non integers
		//change wording
		//implement a loop that keeps taking input and maintains current answer. uses answer for oncoming operations
		//need a clear input to clear answer
		//need an exit
		//use read line to take input instead of command line (string.split hint hint)
		//looking for c# cast integer to decimal 
		static void Main(string[] args)
		{
			int inp1 = int.Parse(args[0]);
			int inp2 = int.Parse(args[2]);
			int answer = 0;
			//this is a test
			int[] toys = new int[5];
			toys[0] = 4;
			toys[1] = 2;
			toys[2] = 5;
			toys[3] = 6;
			toys[4] = 8;
			
			/*Addition("What is the first number number you would like to add?");
			Subtraction("What is the number you want to subtract from?");
			Multiplication("What is the first number to want to multiply.");
			Division("What is the number you want to divide?")
			Console.ReadKey();*/
			
			//Console.WriteLine(args.Length);
			for (int i = 0; i < args.Length; i++)
			{
				Console.WriteLine(args[i]);

			}
			
			switch (args[1])
			{
				case "x": 
					answer = Multiplication(inp1, inp2);
					break;
				case "+":
					answer = Addition(inp1, inp2);
					break;
				case "-":
					answer = Subtraction(inp1, inp2);
					break;
				case: "/";
					answer = Division (inp1, inp2);
					break;
				default:
					Console.WriteLine(string.Format("We don't know what operation {0} is.", args[1]));
					return;
			}
			Console.WriteLine(answer);
		}
	}
	
}