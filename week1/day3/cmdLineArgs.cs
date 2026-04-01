// we can pass parameters to the Main() method and this is possible through Command Line Arguments

// Passing Command Line Arguments in C# using Visual Studio:
using System;
namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"First Command Line Argument {args[0]}");
            Console.WriteLine($"Second Command Line Argument {args[1]}");
            Console.WriteLine($"Third Command Line Argument {args[2]}");
        }
    }
}


// Passing Command Line Arguments to Main Method using Visual Studio:
// properties>right-click on project>properties>debug>enter command line arguments