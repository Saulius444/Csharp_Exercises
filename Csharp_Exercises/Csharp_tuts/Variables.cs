using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Defining variables:
<data_type> <variable_list>;
*/

//int i, j, k;
//char c, ch;
//float f, salary;
//double d;

/*
You can initialize a variable at the time of definition:
int i = 100;
 */

/*
Initializing (assigning a value to) Variables:
variable_name = value;

Variables can be initialized in their declaration.
<data_type> <variable_name> = value;
*/

/*
int d = 3, f = 5;    // initializing d and f. 
byte z = 22;         // initializes z. 
double pi = 3.14159; // declares an approximation of pi. 
char x = 'x';        // the variable x has the value 'x'. 
*/

//The following example uses various types of variables

namespace VariableDefinition {
	class Program {
		static void Main(string[] args) {
			short a;
			int b;
			double c;

			//actual initialization
			a = 10;
			b = 20;
			c = a + b;
			Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
			Console.ReadLine();
		}
	}
}

//Accepting Values from user
int num;
num = Convert.ToInt32(Console.ReadLine());

//integer literals

212         /* Legal */
215u        /* Legal */
0xFeeL      /* Legal */

//Following are other examples of various types of Integer literals

85         /* decimal */
0x4b       /* hexadecimal */
30         /* int */
30u        /* unsigned int */
30l        /* long */
30ul       /* unsigned long */

// Floating-point Literals

3.14159       /* Legal */
314159E-5F    /* Legal */
510E          /* Illegal: incomplete exponent */
210f          /* Illegal: no decimal or exponent */
.e55          /* Illegal: missing integer or fraction */