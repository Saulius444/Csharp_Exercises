using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeApplication {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Size of int: {0}", sizeof(int));
			Console.ReadLine();
		}
	}
}

/*
Data Types:

  Value Type - int, char, float...
	Value type variables can be assigned a value directly.
	The value types directly contain data. When you declare an int type, the system allocates memory to store the value.

  Reference Type - object, dynamic, string.
	The reference types do not contain the actual data stored in a variable, but they contain a reference to the variables.
	Using multiple variables, the reference types can refer to a memory location. If the data in the memory location is changed by one of the variables, 
	the other variable automatically reflects this change in value.

		Object type can be assigned values of any other types, value types, reference types, predefined or user-defined types. However, before assigning values, it needs type conversion.
		When a value type is converted to object type, it is called boxing,
		when an object type is converted to a value type, it is called unboxing.

			object obj;
			obj = 100; // this is boxing

		Dynamic Type - can store any type of value. Dynamic types are similar to object types except that type checking for the dynamic type variables takes place at run time.
		Syntax for declaring a dynamic type is − dynamic <variable_name> = value;

			dynamic d = 20;

		String Type - allows you to assign any string values to a variable. It is derived from object type. The value for a string type can be assigned using string literals in two forms: quoted and @quoted.
		The user-defined reference types are: class, interface, or delegate.

			quoted
			String str = "Tutorials Point";
			@quoted
			@"Tutorials Point";

  Pointer Type
	Pointer type variables store the memory address of another type.
	Syntax for declaring a pointer type is − type* identifier;

		char* cptr;
		int* iptr;
*/
