// In order to implement the user interface in console applications, Microsoft provided us with a class called Console.
// The Console class is available in the System namespace.

// The Console class represents the standard input, output, and error streams for console applications and
// this class cannot be inherited because it is a static class

/*
Properties of console class:
1. Title: It gets or sets the title to display in the console title bar. (maximum length: 24500)
2. BackgroundColor: It gets or sets the background color of the console. (default is black)
3. ForegroundColor: It gets or sets the foreground color of the console. (default is gray)
4. CursorSize: It gets or sets the height of the cursor within a character cell. (The property value ranges from 1 to 100)
*/

/*
Methods of Console Class:
1. Clear(): it is used to clear the screen.
2. Beep(): This method plays the sound of a beep through the console speaker.
3. ResetColor(): This method is used to set the foreground and background console colors to their defaults.
4. Write(“string”): This method is used to write the specified string value to the standard output stream.
5. WriteLine(“string”): This method is used to write the specified string value, followed by the current line terminator, to the standard output stream.
6. Write(variable): This method is used to write the value of the given variable to the standard output stream.
7. WriteLine(variable): This method is used to write the value of the given variable to the standard output stream along with moving the cursor to the next line after printing the value of the variable.
8. Read(): This method read a single character from the keyboard and returns its ASCII value. The Datatype should be int as it returns the ASCII value.
9. ReadLine(): This method reads a string value from the keyboard and returns the entered value only. As it returns the entered string value so the DataType is going to be a string.
10. ReadKey():  This method reads a single character from the keyboard and returns that character information like what key has been entered, and what its corresponding ASCII value is. The Datatype should be ConsoleKeyInfo which contains the entered key information.
*/

using System;
namespace consoleClass
{
    class consoleClass
    {
        static void Main(string[] args)
        {
            // Example to show the use of the Write and WriteLine method in C#:

            //We can access WriteLine and Write method using class name
            //as these methods are static
            //WriteLine Method Print the value and move the cursor to the next line
            Console.WriteLine("Hello");
            //Write Method Print the value and stay in the same line
            Console.Write("HI ");
            //Write Method Print the value and stay in the same line
            Console.Write("Bye ");
            //WriteLine Method Print the value and move the cursor to the next line
            Console.WriteLine("Welcome");
            //Write Method Print the value and stay in the same line
            Console.Write("C#.NET ");

            // Example to show how to print the value of a variable in C#.
            string name = "Pranaya";
            Console.WriteLine(name);
            Console.WriteLine("Hello " + name);
            Console.Write($"Hello {name}");
            Console.Write("\n\n");
            // Reading Value from the user in C#:
            // Giving one message to the user to enter his name
            Console.WriteLine("Enter Your Name: ");
            //ReadLine method reads a string value from the keyboard 
            string nameRead = Console.ReadLine();
            //Printing the entered string in the console
            Console.WriteLine($"Hello {nameRead}");
            Console.WriteLine("\n");

            // How do you Read Integer Numbers in C# from the keyword?
            Console.WriteLine("Enter two Numbers:");
            //Converting string to Integer
            int Number1 = Convert.ToInt32(Console.ReadLine());
            //Converting string to Integer
            int Number2 = Convert.ToInt32(Console.ReadLine());
            int Result = Number1 + Number2;
            Console.WriteLine($"The Sum is: {Result}");
            Console.WriteLine($"The Sum is: {Number1 + Number2}");
            Console.WriteLine("\n");

            // Example to Understand ReadKey and Read method in C#:
            Console.WriteLine("Enter a Key: ");
            int var1 = Console.Read();
            Console.Read();
            Console.ReadLine(); // clear leftover input
            Console.WriteLine($"ASCII Value of the Entered Key is: {var1}");
            Console.WriteLine("Enter Another Key: ");
            ConsoleKeyInfo var2 = Console.ReadKey();
            Console.WriteLine($"\nEntered Key: {var2.Key} KeyChar:{var2.KeyChar} ASCII:{(int)var2.KeyChar}");
            Console.WriteLine("\n");


            // Example to understand Console Class Properties
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Understanding Console Class";
            Console.WriteLine("BackgroundColor: Blue");
            Console.WriteLine("ForegroundColor: White");
            Console.WriteLine("Title: Understanding Console Class");
            //It will make Beep Sound
            Console.Beep();

            Console.ReadLine();


            Console.ResetColor();


            // Complex Example to Understand Console Class:
            Console.WriteLine("Enter Employee Details");
            
            Console.Write("Enter Employee ID: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            string employeeName = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            int employeeSalary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Address: ");
            string employeeAddress = Console.ReadLine();
            Console.Write("Enter Employee Department:");
            string employeeDepartment = Console.ReadLine();

            Console.WriteLine("\nEntered Employee Details are as Follows:");
            Console.WriteLine($"Employee ID Is: {employeeId}");
            Console.WriteLine($"Employee Name Is: {employeeName}");
            Console.WriteLine($"Employee Salary Is: {employeeSalary}");
            Console.WriteLine($"Employee Address Is: {employeeAddress}");
            Console.WriteLine($"Employee Department Is: {employeeDepartment}");
        }
    }
}