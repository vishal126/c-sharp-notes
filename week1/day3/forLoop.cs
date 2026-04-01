// For Loop in C#:
// If we know the number of times, we want to execute some set of statements or instructions, then we should use for loop.

// Syntax to use For Loop in C# Language:
// 1. Loop initialization
// 2. Condition evaluation
// 3. Execution of instruction
// 4. Increment/Decrement

// Points to Remember while working with for loop in C#:
// When we are working with for loop always execution process will start from the initialization block. After the initialization block, the control will pass to the condition block. If the condition is evaluated as true then control will pass to the statement block.
// After execution of the statement block, the control will pass to the increment/decrement statement, from the increment/decrement statement, it will pass back to the condition statement. Always repetition will happen beginning condition, statement block, and increment/decrement statement The initialization block will be executed only once when we are entering the loop for the first time.
// When we are working with for loop everything is optional but mandatory to place 2 semicolons (;;).
// While we are working with for loop if the condition part is not given then it will repeat infinite times because the condition part will replace it as non-zero. So it is always true as like for(; 1; )
// In for loop also the pre-checking process will occur i.e. before the execution of the statement block (body of the for loop), the condition part will be executed.


// Example to Print Numbers From 1 to n Using For Loop in C#:
using System;
namespace ControlFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter one Integer Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int counter = 1; counter <= number; counter++)
            {
                Console.WriteLine(counter);
            }
        }
    }
}