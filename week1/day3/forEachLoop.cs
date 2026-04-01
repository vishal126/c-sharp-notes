// foreach loop because it strictly requires a collection (like an Array or a List) to work.

// The Basic Syntax
// The foreach loop is designed to do exactly one thing: Read every item in a collection, from the first to the last, one by one.

// List<string> techStack = new List<string> { "React", "C#", ".NET Core" };

// // "For every string (which we will call 'tech') inside the 'techStack' list..."
// foreach (string tech in techStack)
// {
//     Console.WriteLine($"I am learning {tech}");
// }


// The {IEnumerator} State Machine
// A foreach loop doesn't actually use an index. When you compile your code, the C# compiler secretly rewrites your foreach loop into a while loop that uses a hidden object called an Enumerator (specifically, IEnumerator).

// // THIS IS WHAT HAPPENS IN THE BACKGROUND:
// var enumerator = techStack.GetEnumerator(); // Grabs the conveyor belt

// while (enumerator.MoveNext()) // Moves the belt forward one tick. Returns false if it's empty.
// {
//     string tech = enumerator.Current; // Grabs the item currently sitting in front of you
//     Console.WriteLine($"I am learning {tech}");
// }


// The "Read-Only" Traps
// Because foreach uses this one-way conveyor belt instead of direct memory indexing, it enforces two massive safety rules that trip up developers

// A. You cannot reassign the iteration variable.
// Once the foreach loop hands you an item, you are only allowed to read it. You cannot overwrite it.
// int[] numbers = { 10, 20, 30 };

// foreach (int num in numbers)
// {
//     num = num + 5; // FATAL COMPILER ERROR! 'num' is a read-only variable.
// }

// B. You cannot change the size of the collection.
// if you try to .Add() or .Remove() an item from the list while the foreach loop is running, the hidden IEnumerator conveyor belt will instantly panic and throw an InvalidOperationException to prevent memory corruption.