using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Type conversion is converting one type of data to another type. It is also known as Type Casting.
In C#, type casting has two forms

	Implicit type conversion − These conversions are performed by C# in a type-safe manner. 
		For example, are conversions from smaller to larger integral types and conversions from derived classes to
		base classes.

	Explicit type conversion − These conversions are done explicitly by users using the pre-defined functions. 
		Explicit conversions require a cast operator.
*/

//The following example shows an explicit type conversion

/*
//commented to test next part
namespace TypeConversionApplication {
	class ExplicitConversion {
		static void Main(string[] args) {
			double d = 5673.74;
			int i;

			// cast double to int.
			i = (int)d;
			Console.WriteLine(i);
			Console.ReadKey();
		}
	}
}
*/

//The following example converts various value types to string type

namespace TypeConversionApplication {
	class StringConversion {
		static void Main(string[] args) {
			int i = 75;
			float f = 53.005f;
			double d = 2345.7652;
			bool b = true;

			Console.WriteLine(i.ToString());
			Console.WriteLine(f.ToString());
			Console.WriteLine(d.ToString());
			Console.WriteLine(b.ToString());
			Console.ReadKey();
		}
	}
}