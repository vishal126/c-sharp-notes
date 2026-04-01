// The Literals in C# are the fixed values (or hard-coded values) given to your variable and these values cannot be modified during the execution of the program.
// or
// it is a fixed value assigned to a variable.

// For example, int x = 100; Here x is a variable, and 100 is literal.

// Type:
// 1. Numeric literal
    // a. integar literal
    // b. floating-point literal
// 2. Boolean literal
// 3. Character literal
    // a. character literal
    // b. string literal


// Integer Literals in C#:
// The Integer literals in C# are used to write values of types int, uint, long, ulong, etc.
// We can represent the Integer Literals in the form of Decimal, Binary, or Hexadecimal.

// we need to use a prefix to specify whether the Integer Literal is Binary (prefixed with 0b), or Hexadecimal (0X) type. No prefix is required for the Decimal numbers.

// For Integral data types (byte, short, int, long), we can specify literals or fixed values in the following 3 ways:
// 1. Decimal (Base - 10) -> Digits from 0-9 are allowed in this form.
    // Example: int x=101;

// 2. Hexa-Decimal (Base-16) -> Digits 0-9 are allowed and also characters from a-f are allowed in this form.
    // Furthermore, both uppercase and lowercase characters can be used. C# provides an exception here i.e. as we know that C# is a case-sensitive programming language but here C# is not case-sensitive.
    // the hexadecimal number should be prefixed with 0X or 0x. and suffix with Face. Example: int x = 0X123F;

// 3. Binary (0 and 1): In this form, the allowed digits are only 1’s and 0’s. The binary number should be prefixed with 0b. Example: int x = 0b1111;

// using System;
// namespace LiteralsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Decimal literal
//             //Allowed Digits: 0 to 9
//             int a = 101; //No suffix is required

//             // Hexa-Decimal Literal
//             //Allowed Digits: 0 to 9 and Character a to f
//             int c = 0x123f; //Prefix with 0x, and suffix with f

//             //Binary literal
//             //Allowed Digits: 0 to 1
//             int d = 0b1111; // //Prefix with 0b

//             Console.WriteLine($"Decimal Literal: {a}");
//             Console.WriteLine($"Hexa-Decimal Literal: {c}");
//             Console.WriteLine($"Binary Literal: {d}");
//         }
//     }
// }


// A suffix can also be used with the integer literals like U or u are used for unsigned numbers while l or L are used for long numbers.
// using System;
// namespace LiteralsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 1000; //Integer
//             uint b = 1000U; //Unsigned Integer
//             long c = 1000L; //Long
//             ulong d = 1000UL; //Unsigned Long
            
//             Console.WriteLine($"Integer Literal: {a}");
//             Console.WriteLine($"Unsigned Integer Literal: {b}");
//             Console.WriteLine($"Long Literal: {c}");
//             Console.WriteLine($"Unsigned Long Literal: {d}");
//         }
//     }
// }



// Floating-Point Literals in C#:
// The Literals in C# which have an integer part and a decimal point are known as Floating-Point literals 
// Floating-Point Literals are used to write values of types float, double, and decimal.
// By default, every floating-point literal is of double type and hence we can’t assign values directly to float and decimal variables. If you want to assign values to a float variable, then you need to add the suffix f at the end of the floating-point literal. Similarly, if you want to assign values to a decimal variable, then you need to add the suffix m or M at the end of the floating-point literal. If you are not suffixing the floating-point literal with anything, then the floating-point literal is going to be double by default. Even, if you want, then you can also specify explicitly floating-point literal as the double type by suffixed with d or D, of course, this convention is not required.

// using System;
// namespace LiteralsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Double Literal
//             double a = 10.15; //By Default Floating Point Literal is double

//             //Float Literal
//             float b = 100.72F; //Suffix with F

//             //Double Literal
//             double c = 1.45D; //Suffix with D

//             //Decimal Literal
//             decimal d = 1.44M; //Suffix with M
            
//             Console.WriteLine($"Double Literal: {a}");
//             Console.WriteLine($"Float Literal: {b}");
//             Console.WriteLine($"Double Literal: {c}");
//             Console.WriteLine($"Decimal Literal: {d}");
//         }
//     }
// }


// Character Literals in C#:
// The Character Literals in C# are enclosed in single quotes.
// A character literal can be a plain character for example, ‘a’, an escape sequence for example, ‘\t’, or a universal character for example, ‘\u02B0’.

// for character data types we can specify character literals in 3 ways. They are as follows:

// 1. Character Literals using Single Quote:
// We can specify Character literals to a char data type as a single character using a single quote.
// Example: char ch = ‘A’;

// 2. Character Literals using Unicode Representation:
// We can specify Character literals using Unicode representation ‘\uXXXX’ where XXXX is the 4 hexadecimal numbers.
// Example: char ch = ‘\u0041’;  Here /u0041 represent A.

// 3. Character Literals using Escape Sequence:
// Every escape character in C# can be specified as a character literal.
// Example: char ch = ‘\n’;

// escape   -   sequence Meaning
// \\       -   \ character
// \''      -   ' character
// \""      -   " character
// \??      -   ? character
// \a       -   Alert or bell
// \b       -   Backspace
// \f       -   form feed
// \n       -   newline
// \r       -   Carriage  return
// \t       -   Horizontal tab
// \v       -   Vertical tab
// \ooo     -   octal number of one to three digits
// \xhhh..  -   hexadecimal number  of one or more digits

// using System;
// namespace LiteralsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Character literal using single quote
//             char ch1 = 'A';
//             Console.WriteLine("Single Quote: " + ch1);

//             //Character literal using Unicode representation
//             char ch2 = '\u0041';
//             Console.WriteLine("Unicode: " + ch2);

//             //Character literal using Escape character
//             Console.WriteLine("Escape: Hello\nDotNet\tTutorials");
//         }
//     }
// } 


// String Literals in C#:
// The Literals in C# which are enclosed with double quotes (” “) or start with @” “ are known as the String literals.
// 2 ways:
// 1. Regular String Literals: A regular string literal in C# consists of zero or more characters enclosed in double quotes, for example, “Dot Net Tutorials”
// and may include both simple escape sequences for example, “Dot\nNet\tTutorials” and Unicode escape sequences.

// 2. Verbatim String Literals: A verbatim string literal starts with an @ character followed by a double-quote which may contain zero or more characters, and ends with a double-quote character.
// They can store characters or escape sequences, for example, @”Dot\nNet\tTutorials”. In this case, the escape sequences or characters will be printed as it is in the output.

// using System;
// namespace LiteralsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str1 = "Dot Net Tutorials";
//             string str2 = @"Dot Net Tutorials";

//             string str3 = "Dot\nNet\tTutorials";
//             string str4 = @"Dot\nNet\tTutorials";

//             Console.WriteLine($"str1: {str1}");
//             Console.WriteLine($"str2: {str2}");
//             Console.WriteLine($"str3: {str3}");
//             Console.WriteLine($"str4: {str4}");
//         }
//     }
// }


// Boolean Literals in C#:
// Only two values are allowed for Boolean literals i.e. true and false
// The values of true and false do not convert into any numerical representation. The true literal in C# does not equal 1, nor does the false literal equal 0.

// Example:
// bool b1 = true;
// bool b2 = false;
// bool b3 = 0; //Error
// bool b4 = 1; //Error

// Note: The assigned true and false values should be the lower case only otherwise you will get compile time error. The following is not allowed.
// bool b1 = True; //Error
// bool b2 = False; //Error
// bool b1 = TRUE; //Error
// bool b2 = FALSE; //Error

// using System;
// namespace LiteralsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             bool b1 = true;
//             bool b2 = false;
//             // bool b3 = 0; //Error
//             // bool b4 = 1; //Error 

//             Console.WriteLine(b1);
//             Console.WriteLine(b2);
//         }
//     }
// }



// Binary Literals in C#:
// The binary literal is used to store the binary value in a variable
// And if you want to create a binary literal, then the literal value should be prefixed with 0b. And here, you can use only 0 and 1.

// int num1 = 0b10001; //Allowed
// int num2 = 0b1000145; //Error

// using System;
// namespace LiteralsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating binary literals by prefixing with 0b
//             int Num1 = 0b100111101;
//             int Num2 = 0b01000011;
//             //int num3 = 0b100134; //Error

//             Console.WriteLine($"Value of Num1 is: {Num1}");
//             Console.WriteLine($"Value of Num2 is: {Num2}");
//             Console.WriteLine($"Char value of Num1 is: {Convert.ToChar(Num1)}");
//             Console.WriteLine($"Char value of Num2 is: {Convert.ToChar(Num2)}");
//         }
//     }
// }



// 1. The Modern C# Quirks: Digit Separators and Raw Strings
// A. The Digit Separator (_)
// Imagine you are hard-coding a massive number or a complex binary literal.
// int budget = 1000000000;

// int budget = 1_000_000_000; // Much easier to read!
// int myBinary = 0b1010_1011_1100;

// B. The "Raw String Literal" (C# 11+)
// The article mentions Verbatim strings (@"") to ignore escape characters, which is great for file paths (@"C:\Users\vishal"). But what if you need to hard-code a JSON payload or an HTML block that is full of double quotes? Verbatim strings still struggle with that.
// Modern C# introduced Raw String Literals using three quotes ("""). You can paste anything inside them without breaking your code:

// string jsonPayload = """
// {
//     "firstName": "Vishal",
//     "role": "React Developer",
//     "status": "Learning C#"
// }
// """;

// C. The var and double Trap
// The article mentions that floating-point numbers are double by default. This creates a massive hidden trap when developers use the var keyword (which tells C# to guess the data type based on the literal).
// var price = 19.99; // C# sees the literal and creates a DOUBLE

// If you pass price into a financial method that expects a decimal, the application will fail to compile. You must use the literal suffix to force the compiler's hand:
// var price = 19.99m; // Now C# knows this is a strict DECIMAL

