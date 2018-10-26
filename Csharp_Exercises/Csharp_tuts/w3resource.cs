using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharp_tuts {
	public class Exercises {
		public static void Main() {
			//Exercise 62 (continuation @ bottom)
			Console.WriteLine(reverse_remove_parentheses("p(rq)st"));
			Console.WriteLine(reverse_remove_parentheses("(p(rq)st)"));
			Console.WriteLine(reverse_remove_parentheses("ab(cd(ef)gh)ij"));

			//Exercise 61 (continuation @ bottom)
			int[] x61 = sort_numbers61(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 });
			foreach (var item61 in x61) {
				Console.WriteLine(item61.ToString());
			}
			Console.WriteLine();

			//Exercise 60 (Duplicate)
			/***********************/

			//Exercise 59 (continuation @ bottom)
			Console.WriteLine(test_Increasing_Sequence(new int[] { 1, 3, 5, 6, 9 }));
			Console.WriteLine(test_Increasing_Sequence(new int[] { 0, 10 }));
			Console.WriteLine(test_Increasing_Sequence(new int[] { 1, 3, 1, 3 }));
			Console.WriteLine();
			Console.ReadKey();

			//Exercise 58 (continuation @ bottom)
			Console.WriteLine(consecutive_array(new int[] { 1, 3, 5, 6, 9 }));
			Console.WriteLine(consecutive_array(new int[] { 0, 10 }));
			Console.WriteLine();

			//Exercise 57 (continuation @ bottom)
			Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, 4, 5, 2 }));
			Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, -4, 5, 2 }));
			Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 0, -4, 0, 2 }));
			Console.WriteLine();

			//Exercise 56 (continuation @ bottom)
			Console.WriteLine(sum_matrix_elements(
				new int[][] {
					new int[]{0, 2, 3, 2},
					new int[]{0, 6, 0, 1},
					new int[]{4, 0, 3, 0}
				}));
			Console.WriteLine(sum_matrix_elements(
				new int[][] {
					new int[]{1, 2, 1, 0 },
					new int[]{0, 5, 0, 0},
					new int[]{1, 1, 3, 10 }
				}));
			Console.WriteLine(sum_matrix_elements(
				new int[][] {
					new int[]{1, 1},
					new int[]{2, 2},
					new int[]{3, 3},
					new int[]{4, 4}
				}));
			Console.WriteLine();

			//Exercise 55 (continuation @ bottom)
			Console.WriteLine(array_adjacent_elements_product(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
			Console.WriteLine(array_adjacent_elements_product(new int[] { 0, -1, -1, -2 }) == 2);
			Console.WriteLine(array_adjacent_elements_product(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
			Console.WriteLine(array_adjacent_elements_product(new int[] { 1, 4, 3, 0 }) == 16);
			Console.WriteLine();

			//Exercise 54 (continuation @ bottom)
			Console.WriteLine(centuryFromYear(1799) == 18);
			Console.WriteLine(centuryFromYear(1900) == 19);
			Console.WriteLine(centuryFromYear(1901) == 19);
			Console.WriteLine(centuryFromYear(1901) == 20);
			Console.WriteLine(centuryFromYear(1806) == 19);
			Console.WriteLine(centuryFromYear(1568) == 20);
			Console.WriteLine(centuryFromYear(2010) == 21);

			//Exercise 53 (continuation @ bottom)
			int[] nums53 = { 2, 4, 7, 8, 6 };
			Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums53));
			Console.WriteLine("Check if an array contains an odd number? " + even_odd53(nums53));

			//Exercise 52
			int[] array152 = { 1, 2, 5 };
			Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array152));
			int[] array252 = { 0, 3, 8 };
			Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array252));
			int[] array352 = { -1, 0, 2 };
			Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array352));
			int[] new_array52 = { array152[1], array252[1], array352[1] };
			Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array52));

			//Exercise 51
			int[] nums51 = { 9, 2, 5, 7, 8 };
			Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums51));
			var h_val51 = nums51[0];
			for (var i = 0; i < nums51.Length; i++) {
				if (nums51[i] > nums51[0])
					h_val51 = nums51[i];
			}
			Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_val51);

			//Exercise 50
			int[] nums50 = { 1, 2, 8 };
			Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums50));
			var temp50 = nums50[0];
			for (var i = 0; i < nums50.Length - 1; i++) {
				nums50[i] = nums50[i + 1];
			}
			nums50[nums50.Length - 1] = temp50;
			Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums50));

			//Exercise 49
			int[] nums149 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
			Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums149));
			int[] nums249 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
			Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums249));

			Console.WriteLine("\nCheck if the first element or the last element of the two arrays ( length 1 or more) are equal.");
			Console.WriteLine((nums149[0].Equals(nums249[0])) || (nums149[nums149.Length - 1].Equals(nums249[nums249.Length - 1])));

			//Exercise 48
			int[] nums48 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
			Console.WriteLine((nums48.Length >= 1) && (nums48[0].Equals(nums48[nums48.Length - 1])));

			//Exercise 47
			int[] nums47 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
			Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums47));
			var sum47 = 0;
			for (var i = 0; i < nums47.Length; i++) {
				sum47 += nums47[i];
			}
			Console.WriteLine("Sum: " + sum47);

			//Exercise 46
			Console.WriteLine("\nInput an integer:");
			int x46 = Convert.ToInt32(Console.ReadLine());
			int[] nums46 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
			Console.WriteLine((nums46[0] == x46) || (nums46[nums46.Length - 1] == x46));

			//Exercise 45
			Console.WriteLine("\nInput an integer:");
			int x45 = Convert.ToInt32(Console.ReadLine());
			int[] nums45 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
			Console.WriteLine("Number of " + x45 + " present in the said array:");
			Console.WriteLine(nums45.Count(n45 => n45 == x45));

			//Exercise 44
			Console.Write("Input a string : ");
			string str44 = Console.ReadLine();
			var result44 = string.Empty;
			for (var i = 0; i < str44.Length; i++) {
				if (i % 2 == 0) result44 += str44[i];
			}
			Console.WriteLine(result44);

			//Exercise 43 (continuation @ bottom)
			Console.Write("Input a string : ");
			string str43 = Console.ReadLine();
			Console.WriteLine(test43(str43));

			//Exercise 42
			Console.Write("Input a string:");
			string str42 = Console.ReadLine();
			if (str42.Length < 4)
				Console.WriteLine(str42.ToUpper());
			else
				Console.WriteLine(str42.Substring(0, 4).ToLower() + str42.Substring(4, str42.Length - 4));

			//Exercise 41
			Console.Write("Input a string (conatins at least one 'w' char) : ");
			string str41 = Console.ReadLine();
			var count41 = str41.Count(s41 => s41 == 'w');
			Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
			Console.WriteLine(count41 >= 1 && count41 <= 3);

			//Exercise 40
			Console.WriteLine("\nInput first integer:");
			int x40 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input second integer:");
			int y40 = Convert.ToInt32(Console.ReadLine());
			int n40 = 20;
			var val140 = Math.Abs(x40 - n40);
			var val240 = Math.Abs(y40 - n40);
			Console.WriteLine(val140 == val240 ? 0 : (val140 < val240 ? x40 : y40));

			//Exercise 39
			Console.WriteLine("\nInput first integer:");
			int x39 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input second integer:");
			int y39 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input third integer:");
			int z39 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Largest of three: " + Math.Max(x39, Math.Max(y39, z39)));
			Console.WriteLine("Lowest of three: " + Math.Min(x39, Math.Min(y39, z39)));

			//Exercise 38
			string str38 = "PHP Tutorial";
			var result38 = "";
			if (str38.Length >= 1 && str38[0] == 'P') result38 += str38[0];
			if (str38.Length >= 2 && str38[1] == 'H') result38 += str38[1];
			Console.WriteLine(result38);

			//Exercise 37
			string str37 = "PHP Tutorial";
			Console.WriteLine((str37.Substring(1, 2).Equals("HP") ? str37.Remove(1, 2) : str37));

			//Exercise 36
			Console.Write("Input a first number: ");
			int m36 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Input a second number: ");
			int n36 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(((m36 >= -10 && m36 <= 10)) || ((n36 >= -10 && n36 <= 10)));

			//Exercise 35
			Console.Write("Input a first number(<100): ");
			int m35 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Input a second number(>200): ");
			int n35 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine((m35 < 100 && n35 > 200));

			//Exercise 34
			string str34;
			Console.Write("Input a string : ");
			str34 = Console.ReadLine();
			Console.WriteLine((str34.Length < 6 && str34.Equals("Hello")) ||
				(str34.StartsWith("Hello") && str34[5] == ' '));

			//Exercise 33
			Console.WriteLine("\nInput integer:");
			int x33 = Convert.ToInt32(Console.ReadLine());
			if (x33 > 0) {
				Console.WriteLine(x33 % 3 == 0 || x33 % 7 == 0);
			}

			//Exercise 32
			string str32;
			Console.Write("Input a string : ");
			str32 = Console.ReadLine();
			if (str32.Length > 4) {
				Console.WriteLine(str32.Length < 4 ? str32 + str32 + str32 : str32.Substring(str32.Length - 4) +
					str32.Substring(str32.Length - 4) + str32.Substring(str32.Length - 4) +
					str32.Substring(str32.Length - 4));
			}

			//Exercise 31
			int[] first_array31 = { 1, 3, -5, 4 };
			int[] second_array31 = { 1, 4, -5, -2 };
			Console.WriteLine("\nArray1: [{0}]", string.Join(",", first_array31));
			Console.WriteLine("Array2: [{0}]", string.Join(",", second_array31));
			Console.WriteLine("\nMultiply corresponding elements of two arrays: ");
			for (int i = 0; i < first_array31.Length; i++) {
				Console.Write(first_array31[i] * second_array31[i] + " ");
			}
			Console.WriteLine("\n");

			//Exercise 30
			string hexval30 = "4B0";
			Console.WriteLine("Hexadecimal number: " + hexval30);
			int decValue30 = int.Parse(hexval30, System.Globalization.NumberStyles.HexNumber);
			Console.WriteLine("Convert to-");
			Console.WriteLine("Decimal number: " + decValue30);

			//Exercise 29
			FileInfo f29 = new FileInfo("C:/Users/Saulius/source/repos/Csharp_tuts/Csharp_tuts/abc.txt");
			Console.WriteLine("\nSize of a file: " + f29.Length.ToString());

			//Exercise 28
			string line28 = "Display the pattern like pyramid using the alphabet.";
			Console.WriteLine("\nOriginal String: " + line28);
			string result28 = "";
			List<string> wordsList28 = new List<string>();
			string[] words28 = line28.Split(new[] { " " }, StringSplitOptions.None);
			for (int i = words28.Length - 1; i >= 0; i--) {
				result28 += words28[i] + " ";
			}
			wordsList28.Add(result28);
			foreach (String s28 in wordsList28) {
				Console.WriteLine("\nReverse String: " + s28);
			}

			//Exercise 27
			Console.Write("Input a number (integer): ");
			int n27 = Convert.ToInt32(Console.ReadLine());
			int sum27 = 0;
			while (n27 != 0) {
				sum27 += n27 % 10;
				n27 /= 10;
			}
			Console.WriteLine("Sum of the digits of the said integer: " + sum27);

			//Exercise 26 (continuation @ bottom)
			Console.WriteLine("\nSum of the first 500 prime numbers: ");
			long sum26 = 0;
			int ctr26 = 0;
			int n26 = 2;
			while (ctr26 < 500) {
				if (isPrime26(n26)) {
					sum26 += n26;
					ctr26++;
				}
				n26++;
			}
			Console.WriteLine(sum26.ToString());

			//Exercise 25
			Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
			for (int n = 1; n < (99 + 1); n++) {
				if (n % 2 != 0) {
					Console.WriteLine(n.ToString());
				}
			}

			//Exercise 24
			string line24 = "Write a C# Sharp Program to display the following pattern using the alphabet.";
			string[] words24 = line24.Split(new[] { " " }, StringSplitOptions.None);
			string word24 = "";
			int ctr = 0;
			foreach (String s in words24) {
				if (s.Length > ctr) {
					word24 = s;
					ctr = s.Length;
				}
			}
			Console.WriteLine(word24);

			//Exercise 23
			string line23 = "Write a C# Sharp Program to display the following pattern using the alphabet.";
			Console.WriteLine(line23.ToLower());

			//Exercise 22 (continuation @ bottom)
			Console.WriteLine("\nInput an integer:");
			int x22 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(result22(x22));

			//Exercise 21
			int x21, y21;

			Console.WriteLine("\nInput an integer:");
			x21 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input another integer:");
			y21 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(x21 == 20 || y21 == 20 || (x21 + y21 == 20));

			//Exercise 20 (continuation @ bottom)
			Console.WriteLine(result20(13, 40));
			Console.WriteLine(result20(50, 21));
			Console.WriteLine(result20(0, 23));

			//Exercise 19
			Console.WriteLine(SumTriple(2, 2));
			Console.WriteLine(SumTriple(12, 10));
			Console.WriteLine(SumTriple(-5, 2));

			//Exercise 18
			Console.WriteLine("\nInput first integer:");
			int x18 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nInput second integer:");
			int y18 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Check if one is negative and one is positive:");
			Console.WriteLine((x18 < 0 && y18 > 0) || (x18 > 0 && y18 < 0));

			//Exercise 17
			string str17;
			Console.Write("Input a string : ");
			str17 = Console.ReadLine();
			if (str17.Length >= 1) {
				var s17 = str17.Substring(0, 1);
				Console.WriteLine(s17 + str17 + s17);
			}

			//Exercise 16 (continuation @ bottom)
			Console.WriteLine(first_last("w3resource"));
			Console.WriteLine(first_last("Python"));
			Console.WriteLine(first_last("x"));

			//Exercise 15 (continuation @ bottom)
			Console.WriteLine(remove_char("w3resource", 1));
			Console.WriteLine(remove_char("w3resource", 9));
			Console.WriteLine(remove_char("w3resource", 0));

			//Exercise 14
			Console.Write("Enter the amount of celsius: ");
			int celsius = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Kelvin = {0}", celsius + 273);
			Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);

			//Exercise 13
			int x13;
			Console.Write("Enter a number: ");
			x13 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("{0}{0}{0}", x13);
			Console.WriteLine("{0} {0}", x13);
			Console.WriteLine("{0} {0}", x13);
			Console.WriteLine("{0} {0}", x13);
			Console.WriteLine("{0}{0}{0}", x13);

			//Exercise 12
			int num12;

			Console.WriteLine("Enter a digit ");
			num12 = Convert.ToInt32(Console.ReadLine());

			// Part A: "num num num num" using Write
			Console.Write(num12);
			Console.Write(" ");
			Console.Write(num12);
			Console.Write(" ");
			Console.Write(num12);
			Console.Write(" ");
			Console.Write(num12);
			Console.WriteLine();

			// Part B: "numnumnumnum" using Write
			Console.Write(num12);
			Console.Write(num12);
			Console.Write(num12);
			Console.WriteLine(num12);

			// Part C: "num num num num" using {0}
			Console.WriteLine("{0} {0} {0} {0}", num12);

			// Part D: "numnumnumnum" using {0}
			Console.WriteLine("{0}{0}{0}{0}", num12);

			//Exercise 11
			int age;
			Console.Write("Enter your age ");
			age = Convert.ToInt32(Console.ReadLine());
			Console.Write("Well fuck you then, you {0} year old fart", age);
			Console.ReadKey();

			//Exercise 10
			int number101, number102, number103;

			Console.Write("\nEnter first number - ");
			number101 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number - ");
			number102 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter third number - ");
			number103 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
				number101, number102, number103, ((number101 + number102) * number103), (number101 * number102 + number102 * number103));

			//Exercise 9
			int number91, number92, number93, number94;

			Console.Write("Enter the First number: ");
			number91 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the Second number: ");
			number92 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the Third number: ");
			number93 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the Fourth number: ");
			number94 = Convert.ToInt32(Console.ReadLine());

			int result9 = (number91 + number92 + number93 + number94) / 4;
			Console.WriteLine("The average of {0} , {1} , {2} , {3} is: {4} ",
			number91, number92, number93, number94, result9);

			//Exercise 8
			int x8;
			int result8;

			Console.WriteLine("Enter as number: ");
			x8 = Convert.ToInt32(Console.ReadLine());

			result8 = x8 * 1;
			Console.WriteLine("The table is : {0} x {1} = {2}", x8, 1, result8);
			result8 = x8 * 2;
			Console.WriteLine("             : {0} x {1} = {2}", x8, 2, result8);
			result8 = x8 * 3;
			Console.WriteLine("             : {0} x {1} = {2}", x8, 3, result8);
			result8 = x8 * 4;
			Console.WriteLine("             : {0} x {1} = {2}", x8, 4, result8);
			result8 = x8 * 5;
			Console.WriteLine("             : {0} x {1} = {2}", x8, 5, result8);
			result8 = x8 * 6;
			Console.WriteLine("             : {0} x {1} = {2}", x8, 6, result8);
			result8 = x8 * 7;
			Console.WriteLine("             : {0} x {1} = {2}", x8, 7, result8);
			result8 = x8 * 8;
			Console.WriteLine("             : {0} x {1} = {2}", x8, 8, result8);
			result8 = x8 * 9;
			Console.WriteLine("             : {0} x {1} = {2}", x8, 9, result8);
			result8 = x8 * 10;
			Console.WriteLine("             : {0} x {1} = {2}", x8, 10, result8);

			//Exercise 7
			Console.Write("Enter a number: ");
			int num71 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter another number: ");
			int num72 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("{0} + {1} + {2}", num71, num72, num71 + num72);
			Console.WriteLine("{0} - {1} = {2}", num71, num72, num71 - num72);
			Console.WriteLine("{0} x {1} = {2}", num71, num72, num71 * num72);
			Console.WriteLine("{0} / {1} = {2}", num71, num72, num71 / num72);
			Console.WriteLine("{0} mod {1} = {2}", num71, num72, num71 % num72);

			//Exercise 6
			int num1, num2, num3;
			Console.Write("\n");
			Console.Write("Input the first number to multiply: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Input the second number to multiply: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Input the third number to multiply: ");
			num3 = Convert.ToInt32(Console.ReadLine());

			int result = num1 * num2 * num3;
			Console.WriteLine("Output: {0} x {1} x {2} x {3}",
							  num1, num2, num3, result);

			//Exercise 5
			int number1, number2, temp;
			Console.Write("\nInput the First Number :");
			number1 = int.Parse(Console.ReadLine());
			Console.Write("\nInput the Second Number :");
			number2 = int.Parse(Console.ReadLine());
			temp = number1;
			number1 = number2;
			number2 = temp;
			Console.Write("\nAfter Swapping :");
			Console.Write("\nFirst Number :" + number1);
			Console.Write("\nSecond Number :" + number2);
			Console.Write("\n");

			//Exercise 4
			Console.WriteLine("\nBasic tasks");
			Console.WriteLine(-1 + 4 * 6);
			Console.WriteLine((35 + 5) % 7);
			Console.WriteLine(14 + -4 * 6 / 11);
			Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

			//Exercise 3
			Console.WriteLine(36 / 6);

			//Exercise 2
			Console.WriteLine(15 + 17);

			//Exercise 1
			Console.WriteLine("Hello");
			Console.WriteLine("Alexandra Abramov!");

			//ReadKey
			Console.ReadKey();
		}
		//Exercise 15 continuation
		public static string remove_char(string str, int n) {
			return str.Remove(n, 1);
		}
		//Exercise 16 continuation
		public static string first_last(string ustr) {
			return ustr.Length > 1
				? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
		}
		//Exercise 19 continuation
		public static int SumTriple(int a, int b) {
			return a == b ? (a + b) * 3 : a + b;
		}
		//Exercise 20 continuation
		public static int result20(int a20, int b20) {
			if (a20 > b20) {
				return (a20 - b20) * 2;
			}
			return b20 - a20;
		}
		//Exercise 22 continuation
		public static bool result22(int n22) {
			if (Math.Abs(n22 - 100) <= 10 || Math.Abs(n22 - 200) <= 10)
				return true;
			return false;
		}
		//Exercise 26 continuation
		public static bool isPrime26(int n26) {
			int x26 = (int)Math.Floor(Math.Sqrt(n26));
			if (n26 == 1) return false;
			if (n26 == 2) return true;
			for (int i = 2; i <= x26; ++i) {
				if (n26 % i == 0) return false;
			}
			return true;
		}
		//Exercise 43 continuation
		public static bool test43(string str43) {
			var ctr43 = 0;
			for (var i = 0; i < str43.Length - 1; i++) {
				if (str43[i].Equals('w')) ctr43++;
				if (str43.Substring(i, 2).Equals("ww") && ctr43 > 2)
					return true;
			}
			return false;
		}
		//Exercise 53 continuation
		public static bool even_odd53(int[] nums53) {
			foreach (var n53 in nums53) {
				if (n53 % 2 != 0)
					return true;
			}
			return false;
		}
		//Exercise 54 continuation
		public static int centuryFromYear(int year) {
			return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
		}
		//Exercise 55 continuation
		public static int array_adjacent_elements_product(int[] input_array) {
			int array_index = 0;
			int product = input_array[array_index] * input_array[array_index + 1];

			array_index++;
			while (array_index + 1 < input_array.Length) {
				product = ((input_array[array_index] * input_array[array_index + 1]) > product) ?
						   (input_array[array_index] * input_array[array_index + 1]) :
							product;
				array_index++;
			}
			return product;
		}
		//Exercise 56 continuation
		public static int sum_matrix_elements(int[][] my_matrix) {
			int x56 = 0;
			for (int i = 0; i < my_matrix[0].Length; i++)
				for (int j56 = 0; j56 < my_matrix.Length && my_matrix[j56][i] > 0; j56++)
					x56 += my_matrix[j56][i];

			return x56;
		}
		//Exercise 57 continuation
		public static int adjacent_Elements_Product(int[] input_Array) {
			int max = 0;
			for (int i = 1; i < input_Array.Length;) {
				max = Math.Max(max, input_Array[i - 1] * input_Array[i++]);
			}
			return max;
		}
		//Exercise 58 continuation
		public static int consecutive_array(int[] input_array) {
			Array.Sort(input_array);
			int ctr58 = 0;
			for (int i = 0; i < input_array.Length - 1; i++) {
				ctr58 += input_array[i + 1] - input_array[i] - 1;
			}
			return ctr58;
		}
		//Exercise 59 continuation
		public static bool test_Increasing_Sequence(int[] int_seq) {
			int x59 = 0;
			for (int i = 0; i < int_seq.Length - 1; i++) {
				if (int_seq[i] >= int_seq[i + 1])
					x59++;
				if (i + 2 < int_seq.Length && int_seq[i] >= int_seq[i + 2])
					x59++;
			}
			return x59 <= 2;
		}
		//Exercise 61 continuation
		public static int[] sort_numbers61(int[] arra) {
			int[] num61 = arra.Where(x61 => x61 != -5).OrderBy(x61 => x61).ToArray();
			int ctr61 = 0;
			return arra.Select(x61 => x61 >= 0 ? num61[ctr61++] : -5).ToArray();
		}
		//Exercise 62 continuation
		public static string reverse_remove_parentheses(string str) {
			int lid = str.LastIndexOf('(');
			if (lid == -1) {
				return str;
			}
			else {
				int rid = str.IndexOf(')', lid);

				return reverse_remove_parentheses(
					  str.Substring(0, lid)
					+ new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray())
					+ str.Substring(rid + 1)
				);
			}
		}
	}
}