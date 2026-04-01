// Why do we need Data Types in C#?
// The Datatypes in C# are basically used to store the data temporarily in the computer through a program.

// What is a Data Type in C#?
/*
The Datatypes are something that gives information about

Size of the memory location.
The Range of data that can be stored inside that memory location
Possible Legal Operations that can be performed on that memory location.
What Types of Results come out from an expression when these types are used inside that expression?
The keyword which gives all the above information is called the data type in C#.
*/

// What are the Different Types of Data types Available in C#?
// 1. value data types
    // a. pre defined data types
        // integer, boolean, float, char
    // b. user defined data types
        // enumeration, structure
// 2. pointer data types
// 3. reference data types
    // a. predefined data types
        // objects, strings
    // b. user defined data types
        // class, interface

// valued data types:
    // The data type which stores the value directly in the memory is called the Value Data Type in C#.

// What is Byte Data Type in C#?
// It is a .NET Data Type that is used to represent an 8-Bit unsigned integer.
// Range: 
    // unsigned = 0 to 255
    // signed = -128 to  127

// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             byte b1 = 66;
//             //You cannot store negative number using byte data type.
//             //The following statement will give compile time error
//             //byte b2 = -100;

//             //The following Statement will give compile time error
//             //The maximum value you can store in a byte variable is 255
//             //byte b3 = 256;

//             Console.WriteLine($"Decimal: {b1}");
//             Console.WriteLine($"ASCII Equivalent Character of {b1} is {(char)b1}");
//             Console.WriteLine($"Byte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");
//             Console.WriteLine($"Byte Size:{sizeof(sbyte)} Byte");
            
//             sbyte sb1 = 66;
//             //You can store negative number using sbyte data type.
//             //The following statement will not give compile time error
//             sbyte sb2 = -100;

//             //The following Statement will give compile time error
//             //The maximum value you can store in a sbyte variable is 128
//             //sbyte sb3 = 128;

//             //The following Statement will give compile time error
//             //The minimum value you can store in a sbyte variable is -128
//             //sbyte sb4 = -129;

//             Console.WriteLine($"\nDecimal: {sb1}");
//             Console.WriteLine($"ASCII Equivalent Character of {sb1} is {(char)sb1}");
//             Console.WriteLine($"ASCII Equivalent Character of {sb2} is {(char)sb2}");
//             Console.WriteLine($"SByte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");
//             Console.WriteLine($"SByte Size:{sizeof(sbyte)} Byte");
//         }
//     }
// }


// What is a char data type in C#?
// Char is a 2-Byte length data type that can contain Unicode data.
// (What is Unicode? Unicode is a standard for character encoding and decoding for computers. We can use various Unicode encodings formats such as UTF-8(8-bit), UTF-16(16-bit), and so on.)

// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             char ch = 'B';
//             Console.WriteLine($"Char: {ch}");
//             Console.WriteLine($"Equivalent Number: {(byte)ch}");
//             Console.WriteLine($"Char Minimum: {(int)char.MinValue} and Maximum: {(int)char.MaxValue}");
//             Console.WriteLine($"Char Size: {sizeof(char)} Byte");
//         }
//     }
// }

// We can also represent this letter B using byte data type which is taking 1 Byte. Now, if byte and char are doing the same thing, then why do we need char data type which is taking some extra 1 Byte of memory?
// Why Char Data Type in C#?
// using byte data type we can only represent a maximum of 256 characters or you can say ASCII values. Byte will hold a maximum of 256 symbols/character, after 256 symbols/character, if we want to store some extra symbols like the Hindi alphabet, Chinese alphabet, or some special symbols which are not part of ASCII Characters, then it is not possible with the byte data type, because we already store the maximum symbols or characters. So, char is a Unicode character representation, it is having 2 Byte length and hence we can store the regional symbols, extra symbols, and special characters using the char data type in C#.



// String Data type
// If you want to store multiple characters, then you need to use the string data type in C#.

// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str = "ABC";
//         }
//     }
// }


// get bytes of string data type

// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str = "ABC";
//             var howManyBytes = str.Length * sizeof(Char);

//             Console.WriteLine($"str Value: {str}");
//             Console.WriteLine($"str Size: {howManyBytes}");
//         }
//     }
// }

// In C#, the string is a reference type data type. Now, if you go to the definition of string data type,
// then you will see that the type is going to be a class as shown in the below image and the class is nothing but a reference type in C#.



// Numeric Data Types in C#:
// they can store numeric and non-numeric data
// we have two types of numeric data. One with the number with a decimal point and another with a number without the decimal point.

// Numbers without Decimal
// In this category, .NET Framework provided three kinds of data types. They are as follows:

// 16-Bit Signed Numeric: Example: Int16 (short)
// 32-Bit Signed Numeric: Example: Int32 (int)
// 64-Bit Signed Numeric: Example: Int64 (long)

// 16-Bit Signed Numeric (Int16)
// store 2^16 numbers i.e. 65536 (default: signed store both +ve & -ve values)

// 32-Bit Signed Numeric (Int32)
// store 2^32 numbers i.e. 4,294,967,296 (default: signed)

// 64-Bit Signed Numeric (Int64)
// store 2^64 numbers (default: signed)

// Example to Understand the Numeric Data Types without Decimal:
// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Int16 num1 = 123;
//             Int32 num2 = 456;
//             Int64 num3 = 789;

//             Console.WriteLine($"Int16 Min Value:{Int16.MinValue} and Max Value:{Int16.MaxValue}");
//             Console.WriteLine($"Int16 Size:{sizeof(Int16)} Byte");

//             Console.WriteLine($"Int32 Min Value:{Int32.MinValue} and Max Value:{Int32.MaxValue}");
//             Console.WriteLine($"Int32 Size:{sizeof(Int32)} Byte");

//             Console.WriteLine($"Int64 Min Value:{Int64.MinValue} and Max Value:{Int64.MaxValue}");
//             Console.WriteLine($"Int64 Size:{sizeof(Int64)} Byte");
//         }
//     }
// }

// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Int16 num1 = 123;
//             short num1 = 123;
//             //Int32 num2 = 456;
//             int num2 = 456;
//             // Int64 num3 = 789;
//             long num3 = 789;

//             Console.WriteLine($"short Min Value:{short.MinValue} and Max Value:{short.MaxValue}");
//             Console.WriteLine($"short Size:{sizeof(short)} Byte");

//             Console.WriteLine($"int Min Value:{int.MinValue} and Max Value:{int.MaxValue}");
//             Console.WriteLine($"int Size:{sizeof(int)} Byte");

//             Console.WriteLine($"long Min Value:{long.MinValue} and Max Value:{long.MaxValue}");
//             Console.WriteLine($"long Size:{sizeof(long)} Byte");
//         }
//     }
// }


// unsigned
// if you want to store only positive numbers, the .NET Framework also provided the unsigned versions of each of these data types.
// for Int16 there is UInt16
// for Int32 there is UInt32
// for Int64, there is UInt64

// for short
// ushort, for int
// uint, for int
// ulong, for long

// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //UInt16 num1 = 123;
//             ushort num1 = 123;
            
//             //UInt32 num2 = 456;
//             uint num2 = 456;

//             // UInt64 num3 = 789;
//             ulong num3 = 789;

//             Console.WriteLine($"ushort Min Value:{ushort.MinValue} and Max Value:{ushort.MaxValue}");
//             Console.WriteLine($"short Size:{sizeof(ushort)} Byte");

//             Console.WriteLine($"uint Min Value:{uint.MinValue} and Max Value:{uint.MaxValue}");
//             Console.WriteLine($"uint Size:{sizeof(uint)} Byte");

//             Console.WriteLine($"ulong Min Value:{ulong.MinValue} and Max Value:{ulong.MaxValue}");
//             Console.WriteLine($"ulong Size:{sizeof(ulong)} Byte");
//         }
//     }
// }

// Numeric Numbers with Decimal in C#:
// in Numbers with Decimal, we are provided with three types. They are as follows:
// Single (single-precision floating-point number) (4 bytes)
// Double (double-precision floating-point number) (8 bytes)
// Decimal (Represents a decimal floating-point number) (16 bytes)

// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Single a = 1.123f;
//             Double b = 1.456;
//             Decimal c = 1.789M;
            
//             Console.WriteLine($"Single Size:{sizeof(Single)} Byte");
//             Console.WriteLine($"Single Min Value:{Single.MinValue} and Max Value:{Single.MaxValue}");

//             Console.WriteLine($"Double Size:{sizeof(Double)} Byte");
//             Console.WriteLine($"Double Min Value:{Double.MinValue} and Max Value:{Double.MaxValue}");

//             Console.WriteLine($"Decimal Size:{sizeof(Decimal)} Byte");
//             Console.WriteLine($"Decimal Min Value:{Decimal.MinValue} and Max Value:{Decimal.MaxValue}");
//         }
//     }
// }


// Instead of Single, Double, and Decimal we can also use float, double, decimal.
// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             float a = 1.123f;
//             double b = 1.456;
//             decimal c = 1.789m;
            
//             Console.WriteLine($"float Size:{sizeof(float)} Byte");
//             Console.WriteLine($"float Min Value:{float.MinValue} and Max Value:{float.MaxValue}");

//             Console.WriteLine($"double Size:{sizeof(double)} Byte");
//             Console.WriteLine($"double Min Value:{double.MinValue} and Max Value:{double.MaxValue}");

//             Console.WriteLine($"decimal Size:{sizeof(decimal)} Byte");
//             Console.WriteLine($"decimal Min Value:{decimal.MinValue} and Max Value:{decimal.MaxValue}");
//         }
//     }
// }


// Comparison between Float, Double, and Decimal:
// size, range, precision, accuracy

// Example to Understand Accuracy:
// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             float a = 1.78986380830029492956829698978655434342477f; //7 digits Maximum
//             double b = 1.78986380830029492956829698978655434342477; //15 digits Maximum
//             decimal c = 1.78986380830029492956829698978655434342477m; //29 digits Maximum

//             Console.WriteLine(a);
//             Console.WriteLine(b);
//             Console.WriteLine(c);
//         }
//     }
// }

// Is it matter to choose the data type?
// using System;
// using System.Diagnostics;

// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Stopwatch stopwatch1 = new Stopwatch();
//             stopwatch1.Start();
//             for(int i = 0; i <= 10000000; i++)
//             {
//                 short s1 = 100;
//                 short s2 = 100;
//                 short s3 = 100;
//             }
//             stopwatch1.Stop();
//             Console.WriteLine($"short took : {stopwatch1.ElapsedMilliseconds} MS");

//             Stopwatch stopwatch2 = new Stopwatch();
//             stopwatch2.Start();
//             for (int i = 0; i <= 10000000; i++)
//             {
//                 decimal s1 = 100;
//                 decimal s2 = 100;
//                 decimal s3 = 100;
//             }
//             stopwatch2.Stop();
//             Console.WriteLine($"decimal took : {stopwatch2.ElapsedMilliseconds} MS");
//         }
//     }
// }


// How to Get the Size of PreDefined Data Types in C#?
// use of sizeof method

// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine($"Size of Byte: {sizeof(byte)}");
//             Console.WriteLine($"Size of Integer: {sizeof(int)}");
//             Console.WriteLine($"Size of Character: {sizeof(char)}");
//             Console.WriteLine($"Size of Float: {sizeof(float)}");
//             Console.WriteLine($"Size of Long: {sizeof(long)}");
//             Console.WriteLine($"Size of Double: {sizeof(double)}");
//             Console.WriteLine($"Size of Bool: {sizeof(bool)}");
//         }
//     }
// }


// How to Get the Minimum and Maximum Range of Values of Built-in Data Types in C#?
// make use of the MinValue and MaxValue constants
// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine($"Byte => Minimum Range:{byte.MinValue} and Maximum Range:{byte.MaxValue}");
//             Console.WriteLine($"Integer => Minimum Range:{int.MinValue} and Maximum Range:{int.MaxValue}");
//             Console.WriteLine($"Float => Minimum Range:{float.MinValue} and Maximum Range:{float.MaxValue}");
//             Console.WriteLine($"Long => Minimum Range:{long.MinValue} and Maximum Range:{long.MaxValue}");
//             Console.WriteLine($"Double => Minimum Range:{double.MinValue} and Maximum Range:{double.MaxValue}");
//         }
//     }
// }


// How to Get the Default Values of built-in Data Types in C#?
// Every built-in data type has a default value. All the numeric type has 0 as the default value, boolean has false, and char has ‘\0’ as the default value
// You can use the default(typename) to know the default value of a data type in C#

// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine($"Default Value of Byte: {default(byte)} ");
//             Console.WriteLine($"Default Value of Integer: {default(int)}");
//             Console.WriteLine($"Default Value of Float: {default(float)}");
//             Console.WriteLine($"Default Value of Long: {default(long)}");
//             Console.WriteLine($"Default Value of Double: {default(double)}");
//             Console.WriteLine($"Default Value of Character: {default(char)}");
//             Console.WriteLine($"Default Value of Boolean: {default(bool)}");
//         }
//     }
// }


// What is the Reference Data Type in C#?
// he data type which is used to store the reference of a variable is called Reference Data Type.
// 2 types
// Predefined Types – Examples include Objects, Strings, and dynamics.
// User-defined Types – Examples include Classes and Interfaces.


// What is Pointer Type in C#?
// The pointer in C# language is a variable, it is also known as a locator or indicator that points to an address of the value which means pointer-type variables stores the memory address of another type.

// To get the pointer details we have two symbols ampersand (&) and asterisk (*).

// ampersand (&): It is known as Address Operator. It is used to determine the address of a variable.
// asterisk (*): It is also known as Indirection Operator. It is used to access the value of an address.

// the below code will not work here, go to UnsafeDemo folder.
// using System;
// namespace DataTypesDemo
// {
//     class Program
//     {
//         static unsafe void Main(string[] args)
//         {
//                 // declare a variable
//                 int number = 10;

//                 // store variable number address location in pointer variable ptr
//                 int* ptr = &number;
//                 Console.WriteLine($"Value :{number}");
//                 Console.WriteLine($"Address :{(long)ptr}");
//         }
//     }
// }




// important
// The Hidden C# Quirks: Floating Point Disasters
// The Hidden Trap: Base-2 vs Base-10
// Try this experiment in your head: What is 0.1 + 0.2? The answer is 0.3.
// If you write this in C# using double:
// double result = 0.1 + 0.2;
// Console.WriteLine(result == 0.3); // This prints FALSE!
// Why? float and double use Base-2 (Binary) math to approximate decimals. The computer literally cannot represent 0.1 perfectly in binary (just like humans can't write 1/3 perfectly in decimals; we just write 0.33333...). Because of this tiny rounding error, result actually equals 0.30000000000000004.

// Fix: decimal for Money
// decimal safeResult = 0.1m + 0.2m;
// Console.WriteLine(safeResult == 0.3m); // This prints TRUE!

