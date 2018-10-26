using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy1_4 {
	class Program {
		static void Main(string[] args) {
			

			// Exercise 6
			Console.WriteLine("Exercise6 multi_d_arrays");
			int[][] jagged = new int[][] {
				new int[] { 1, 2, 3, 4 },
				new int[] { 5, 6, 7, 8 }
			};
			int[,] multidimensional = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

			for (int i = 0; i < jagged.Length; i++)
				for (int j = 0; j < jagged[i].Length; j++)
					Console.WriteLine(jagged[i][j]);

			for (int i = 0; i < multidimensional.GetLength(0); i++)
				for (int j = 0; j < multidimensional.GetLength(1); j++)
					Console.WriteLine(multidimensional[i, j]);

			// Exercise 5
			Console.WriteLine("Exercise5 1d_arrays");
			int[] myArray = new int[2];
			myArray[0] = 5;
			myArray[1] = 10;

			int[] myCoolArray = { 15, 20 };

			for (int i = 0; i < myArray.Length; i++) {
				Console.WriteLine(myArray[i]);
			}

			Console.WriteLine();

			for (int i = 0; i < myCoolArray.Length; i++) {
				Console.WriteLine(myCoolArray[i]);
			}

			// Exercise 4
			Console.WriteLine("Exercise4 loops");
			int sumos = 0;
			int n = 5;
			for (int i = 0; i <= n; i++) {
				sumos += i;
			}
			Console.WriteLine(sumos);

			// Exercise 3
			Console.WriteLine("Exercise3 chatbot");
			string manoStr = Console.ReadLine();
			switch(manoStr) {
				case "Hello":
					Console.WriteLine("Hello.");
					break;
				case "Im learning C#":
					Console.WriteLine("Good for you.");
					break;
				default:
					Console.WriteLine("Sorry, cant understand that.");
					break;
			}

			// Exercise 2
			Console.WriteLine("Exercise2  positive negative number");
			int skaicius = int.Parse(Console.ReadLine());
			if (skaicius > 0)
				Console.WriteLine("+");
			else if (skaicius < 0)
				Console.WriteLine("-");
			else
				Console.WriteLine("zero");

			// Exercise 1
			Console.WriteLine("Exercise1 sum");
			double skaicius1 = double.Parse(Console.ReadLine());
			double skaicius2 = double.Parse(Console.ReadLine());

			double rezultatas = skaicius1 + skaicius2;

			Console.WriteLine(rezultatas);

			Console.ReadLine();
		}

		// Exercise 7 methods
		static int Add(int a, int b) {
			return a + b;
		}

		static int AddOrSubstract(int a, int b, bool isAddition) {
			if (isAddition)
				return a + b;
			return a - b;
		}
	}
}
