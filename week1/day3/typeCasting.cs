// What is Type Casting in C#?
// Type Casting or Type Conversion in C# is the process to change one data type value into another data type
// the process of converting the value of one data type (int, float, double, etc.) to another data type ((int, float, double, etc.)) is known as type conversion or typecasting.


// Types of Type Casting in C#
// 1. Implicit Type Casting
// 2. Explicit Type Casting

// Implicit Conversion or Implicit Type Casting / Automatic Type Conversion in C#
// The Implicit Conversion or Implicit Type Casting in C# is automatically done by the compiler and in this case, there will be no data loss.
// Here, the typecasting or type conversion is done from a smaller data type to a larger data type. This type of type conversion is safe.

// Implicit Type Casting happens when:
// 1. The two data types are compatible.
// 2. When we assign a value of a smaller data type to a bigger data type.

// Convert from data type      convert to data type
    // byte                     short, int, long, float, double
    // short                    int, long, float, double
    // int                      long, float, double
    // long                     float, double
    // float                    double

// using System;
// namespace TypeCastingDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int numInt = 1500;

//             //Get type of numInt
//             Type numIntType = numInt.GetType();

//             // Implicit Conversion
//             double numDouble = numInt;

//             //Get type of numDouble
//             Type numDoubleType = numDouble.GetType();

//             // Value Before Conversion
//             Console.WriteLine($"numInt value: {numInt}" );
//             Console.WriteLine($"numInt Type: {numIntType}");
//             Console.WriteLine($"Int Size: {sizeof(int)} Bytes");

//             // Value After Conversion
//             Console.WriteLine($"numDouble value: {numDouble}");
//             Console.WriteLine($"numDouble Type: {numDoubleType}");
//             Console.WriteLine($"double Size: {sizeof(double)} Bytes");
//         }
//     }
// }

// Explicit Conversion or Explicit Type Casting in C#
// If you want to convert the large data type to a small data type in C#, then you need to do the same explicitly using the cast operator.

//error
// using System;
// namespace TypeCastingDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double numDouble = 1.23;

//             // Explicit Type Casting
//             int numInt = numDouble;

//             // Value Before Conversion
//             Console.WriteLine("Original double Value: " + numDouble);

//             // Value After Conversion
//             Console.WriteLine("Converted int Value: " + numInt);
//             Console.ReadKey();
//         }
//     }
// }


//works (int numInt = (int)numDouble;)
// using System;
// namespace TypeCastingDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double numDouble = 1.23;

//             // Explicit Type Casting
//             int numInt = (int)numDouble;

//             // Value Before Conversion
//             Console.WriteLine("Original double Value: " + numDouble);

//             // Value After Conversion
//             Console.WriteLine("Converted int Value: " + numInt);
//         }
//     }
// }


// Conversion with Helper Methods in C#: 
// we have a string variable that holds the value 100 and we try to convert that value to an integer type. But this is not possible with the cast operator
// Because cast operator will first check the type compatibility and it found that string and int are not compatible with each other because the string is used to store textual data which contains both alphanumeric and int contains only numeric data.

//error
// using System;
// namespace TypeCastingDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str= "100";
//             int i1 = (int)str;

//             Console.ReadKey();
//         }
//     }
// }

// Convert Class Helper Methods in C#:
// ToBoolean
// ToChar
// ToByte
// ToDecimal
// ToDouble
// ToInt16
// ToInt32
// ToInt64
// ToString
// ToUInt16
// ToUInt32
// ToUInt64

// using System;
// namespace TypeCastingDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str = "100";
//             int i1 = Convert.ToInt32(str); //Converting string to Integer

//             double d = 123.45;
//             int i2 = Convert.ToInt32(d); //Converting double to Integer

//             float f = 45.678F;
//             string str2 = Convert.ToString(f); //Converting float to string

//             Console.WriteLine($"Original value str: {str} and Converted Value i1:{i1}");
//             Console.WriteLine($"Original value d: {d} and Converted Value i2:{i2}");
//             Console.WriteLine($"Original value f: {f} and Converted Value str2:{str2}");
//         }
//     }
// }


// Type Conversion using Parse() Method in C#
// using System;
// namespace TypeCastingDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str1 = "100";
//             //Converting string to int type
//             int i = int.Parse(str1);
//             Console.WriteLine($"Original String value: {str1} and Converted int value: {i}");

//             string str2 = "TRUE";
//             //Converting string to boolean type
//             bool b= bool.Parse(str2);
//             Console.WriteLine($"Original String value: {str2} and Converted bool value: {b}");
//         }
//     }
// }

//error
// using System;
// namespace TypeCastingDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str1 = "Hello";
//             //Converting string to int type
//             int i = int.Parse(str1);
//             Console.WriteLine($"Original String value: {str1} and Converted int value: {i}");
//         }
//     }
// }


// Using TryParse Method in C#:
// When we use the Parse method, if the conversion is not possible then at runtime, we will get an exception which is not a good thing

// bool IsConverted = int.TryParse(“100”, out int I1);

// using System;
// namespace TypeCastingDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str1 = "100";
//             bool IsConverted1 = int.TryParse(str1, out int I1);
//             if (IsConverted1)
//             {
//                 Console.WriteLine($"Original String value: {str1} and Converted int value: {I1}");
//             }
//             else
//             {
//                 Console.WriteLine($"Try Parse Failed to Convert {str1} to integer");
//             }

//             string str2 = "Hello";
//             bool IsConverted2 = int.TryParse(str2, out int I2);
//             if (IsConverted2)
//             {
//                 Console.WriteLine($"Original String value: {str2} and Converted int value: {I2}");
//             }
//             else
//             {
//                 Console.WriteLine($"Try Parse Failed to Convert {str2} to integer");
//             }
//         }
//     }
// }




// The Hidden Logic: Convert vs. Parse (The Null Trap)
// What happens if the string is completely empty (null) because the database is missing a value?

// int.Parse(null) -> Immediately throws an ArgumentNullException and crashes your app.

// Convert.ToInt32(null) -> Does not crash. It silently returns 0.

