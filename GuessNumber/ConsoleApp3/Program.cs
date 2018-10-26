using System;
using System.Collections.Generic;
using System.Text;


namespace GuessNumber {

	public class Program {

		// Initialize the number of attempts
		int numberOfAttempts = 5;

		public class Result {
			public int Index { get; set; }
			public bool Flag { get; set; }
		}

		static void Main() {
			Program game = new Program();
			game.Run();
		}

		void Run() {

			Console.WriteLine("\nWelcome to Random Number Guessing Game.");
			Console.WriteLine("\nGuess the 4 digit random number XXXX.");
			Console.WriteLine("\nFor each digit, the number is chosen from 1 to 5 \nNumbers can repeat.");
			Console.WriteLine(string.Format("\nYou have {0} attempts to win the game.", numberOfAttempts));

			// Call the method to Generate the Random Number
			var randomNumber = GenerateRandomNumber();
			var correctInputTillNow = new StringBuilder("xxxx");

			for (int i = 1; i <= numberOfAttempts; i++) {

				// Call the method to get the user input
				var userInput = new StringBuilder(GetUserInput(i, correctInputTillNow));

				// Get the result - Collection containing the result of all 4 digits
				int flagCount = 0;
				List<Result> result = GetResult(randomNumber, userInput, out flagCount);
				if (flagCount > 0) {
					foreach (var r in result) {
						if (r.Flag) {
							int index = r.Index;
							correctInputTillNow[index] = randomNumber[index];
						}
					}
				}
			
				// Check the flag count and display appropriate message
				if (flagCount == 4) {
					Console.WriteLine("Your Input:{0}, Random Number:{1}", userInput, randomNumber);
					Console.WriteLine("You guess is correct! Game Won..hurray...:)");
					break;
				}
				else if (i == numberOfAttempts) {
					Console.WriteLine("Sorry, You missed it! Game lost..:(");
					Console.WriteLine("Random Number is {0}", randomNumber);
				}
				else {
					// Get the place(s)/index of digits that are correct
					Console.WriteLine(string.Format("Correct input till now: {0}", correctInputTillNow));
				}
			}

			Console.ReadLine();
		}

		public List<Result> GetResult(StringBuilder randomNumber, StringBuilder userInput, out int flagCount) {

			List<Result> results = new List<Result>(4);
			flagCount = 0;
			for (int index = 0; index < randomNumber.Length; index++) {
				Result result = new Result();
				result.Index = index;
				bool flag = randomNumber[index] == userInput[index];
				if(flag) {
					flagCount++;
				}
				result.Flag = flag;
				results.Add(result);
			}

			return results;
		}

		public string GetUserInput(int attempt, StringBuilder correctInputTillNow) {
			int inputNumber;

			if (attempt == 1) {
				Console.WriteLine(string.Format("\nGuess the 4-digit number. Remaining attempts: {0}", numberOfAttempts - (attempt)));
			}
			else {
				Console.WriteLine(string.Format("\nGuess the 4-digit number. Guess x: {0}, Remaining attempts: {1}", correctInputTillNow, numberOfAttempts - (attempt)));
			}
			
			if (int.TryParse(Console.ReadLine(), out inputNumber) 
				&& inputNumber.ToString().Length == 4) {
				return inputNumber.ToString();
			} 
			else {
				Console.WriteLine("You have entered an invalid input.");
				return "0000";
			}
		}

		public StringBuilder GenerateRandomNumber() {
			Random random = new Random();
			StringBuilder number = new StringBuilder(7);
			int lenght = 4;

			for (int i = 0; i < lenght; i++) {
				number.Append(random.Next(1, 6));
			}

			return number;
		}
	}
}