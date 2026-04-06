// What is an Array in C#?
// The array is defined as a collection of similar data elements.
// Array is a collection of similar types of values that are stored in a contiguous memory location under a single name.

// Types of Arrays in C#:
// 1. Single dimensional array
// 2. Multi-dimensional array


// The multi-dimensional arrays are of two types:
// Jagged array: Whose rows and columns are not equal
// Rectangular array: Whose rows and columns are equal


// How to declare an Array in C#?
// General Syntax: <data type>[] VariableName = new <data type>[size of the array];
// Example: int[] A = new int[5];

// Declare and Initialize an Array in the Same Statement in C#
// int[] A = { 1, 2, 3, 4, 5 };


// How we can access the Array Elements in C#?
// The answer is by using indexes.


// What is an index of an array?
// The index of an array is basically a pointer that is used to indicate which element in the array will be used.
// eg. Console.WriteLine(A[3]); -> 4


// The Arrays in C# are reference types that are derived from the System.Array class.


// Assigning Values to Array in C#:
// int[] n = new int[3];  will allocate space for 3 integers in the heap memory but there are no values in that space
// n[0] = 2;
// n[1] = 3;
// n[2] = 4;


// How to Access Array Elements in C#?
// Suppose we have an array as follows:
// int[] n={1,2,3};

// Now, you want to print 3 and you can see the value three is present at the index position 2, so to print the value 8, you need to use the array index position to 2 as follows:
// Console.WriteLine(n[2]);


// One Dimensional Array in C# with Examples:
// Example 1: Creating and Initializing an Array at the Same Statement
// using System;
// namespace ArayDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating and Initializing an Array
//             //Here, the size will be decided based on the number of elements
//             //In this case size will be 3
//             int[] Numbers = { 10, 20, 30 };

//             //Accessing the Array Elements separately
//             Console.WriteLine("Accessing the Array Elements separately");
//             Console.WriteLine($"Numbers[0] = {Numbers[0]}");
//             Console.WriteLine($"Numbers[1] = {Numbers[1]}");
//             Console.WriteLine($"Numbers[2] = {Numbers[2]}");

//             //Accessing the Array Elements using for Loop
//             Console.WriteLine("\nAccessing the Array Elements using For Loop");
//             for (int i = 0; i <= Numbers.Length - 1; i++)
//             {
//                 Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
//             }

//             //Accessing the Array Elements using foreach Loop
//             Console.WriteLine("\nAccessing the Array Elements using ForEach Loop");
//             foreach (int Number in Numbers)
//             {
//                 Console.WriteLine($"{Number}");
//             }
//         }
//     }
// }


// Example 2: Creating and Initializing an Array Separately
// using System;
// namespace ArayDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating an Integer Array with size 3
//             int[] Numbers = new int[3];

//             //Accessing the Array Elements Before Initialization
//             Console.WriteLine("Accessing the Array Elements Before Initialization");
//             for (int i = 0; i <= Numbers.Length - 1; i++)
//             {
//                 Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
//             }

//             //Initializing the Array Elements using the Index Position
//             Numbers[0] = 10;
//             Numbers[1] = 20;
//             Numbers[2] = 30;

//             //Accessing the Array Elements After Initialization
//             Console.WriteLine("\nAccessing the Array Elements After Initialization");
//             for (int i = 0; i <= Numbers.Length - 1; i++)
//             {
//                 Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
//             }
//         }
//     }
// }


// Example 3: Dynamically Initializing an Array in C#
// using System;
// namespace ArayDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating an array with size 3
//             int[] integerArray = new int[3];

//             //Accessing array values using loop
//             //Here it will display the default values
//             //as we are not assigning any values
//             for (int i = 0; i < integerArray.Length; i++)
//             {
//                Console.Write(integerArray[i] + " ");
//             }

//             Console.WriteLine();
//             int a = 0;

//             //Here we are assigning values to array using for loop
//             for (int i = 0; i < integerArray.Length; i++)
//             {
//                 a += 10;
//                 integerArray[i] = a;
//             }

//             //accessing array values using foreach loop
//             foreach (int i in integerArray)
//             {
//                 Console.Write(i + " ");
//             }
//         }
//     }
// }



// What is the difference between for loop and for each loop in C# to access array values?
// In the case of for loop in C#, the loop variable refers to the index of an array whereas, in the case of a for-each loop, the loop variable refers to the values of the array.
// Irrespective of the values stored in the array, the loop variable must be of type int in case of for loop. The reason for this is, here the loop variable is referring to the index position of the array. Coming to the for-each loop, the data type of the loop variable must be the same as the type of the values stored in the array.


// using System;
// namespace ArayDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating an array with size 3
//             string[] Countries = {"India", "USA", "UK" };

//             //Accessing array values using for loop
//             //Here, the loop variable is of integer type
//             for (int i = 0; i < Countries.Length; i++)
//             {
//                Console.Write(Countries[i] + " ");
//             }
//             Console.WriteLine();

//             //accessing array values using foreach loop
//             //Here, the loop variable is of type string
//             foreach (string country in Countries)
//             {
//                 Console.Write(country + " ");
//             }
//         }
//     }
// }


// What happens when you are trying to access an element whose index is out of bounds?
// If you are trying to access an array whether for setting the value or getting the value, if that index is out of the bounds of an array, then it will throw an exception.


// Array Class in C#:
// The Array class in C# is a predefined class that is defined inside the System namespaces.
// This class is working as the base class for all the Arrays in C#.
// The Array class provides a set of members (methods and properties) to work with the arrays such as creating, manipulating, searching, reversing, and sorting the elements of an array, etc. 

// Array is a part of the System namespace. But still, we considered it as a collection because it Implement the IList interface.

// The Array class provides the following methods and properties:
// 1. Sort(<array>): Sorting the array elements
// 2. Reverse (<array>): Reversing the array elements
// 3. Copy (src, dest, n): Copying some of the elements or all elements from the old array to the new array
// 4. GetLength(int): A 32-bit integer that represents the number of elements in the specified dimension.
// 5. Length: It Returns the total number of elements in all the dimensions of the Array; zero if there are no elements in the array. 


// Example to Understand Array Class Methods and Properties in C#
// using System;
// namespace ArayDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating and Initializing an Array of Integers
//             //Size of the Array is 10
//             int[] Numbers = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };

//             //Printing the Array Elements using a for Loop
//             Console.WriteLine("Original Array Elements :");
//             for (int i = 0; i < Numbers.Length; i++)
//             {
//                 Console.Write(Numbers[i] + " ");
//             }
//             Console.WriteLine();

//             //Sorting the Array Elements by using the Sort method of Array Class
//             Array.Sort(Numbers);
//             //Printing the Array Elements After Sorting using a foreach loop
//             Console.WriteLine("\nArray Elements After Sorting :");
//             foreach (int i in Numbers)
//             {
//                 Console.Write(i + " ");
//             }
//             Console.WriteLine();

//             //Reversing the array elements by using the Reverse method of Array Class
//             Array.Reverse(Numbers);
//             //Printing the Array Elements in Reverse Order
//             Console.WriteLine("\nArray Elements in the Reverse Order :");
//             foreach (int i in Numbers)
//             {
//                 Console.Write(i + " ");
//             }
//             Console.WriteLine();

//             //Creating a New Array
//             int[] NewNumbers = new int[10];
//             //Copying Some of the Elements from Old array to new array
//             //We declare the array with size 10 and we copy only 5 elements. 
//             //So the rest 5 elements will take the default value. In this array, it will take 0
//             Array.Copy(Numbers, NewNumbers, 5);

//             //Printing the Array Elements using for Each Loop
//             Console.WriteLine("\nNew Array Elements :");
//             foreach (int i in NewNumbers)
//             {
//                 Console.Write(i + " ");
//             }

//             Console.WriteLine();
//             Console.WriteLine($"\nNew Array Length using Length Property :{NewNumbers.Length}");
//             Console.WriteLine($"New Array Length using GetLength Method :{NewNumbers.GetLength(0)}");
//         }
//     }
// }


// Understanding the Implicitly Typed Arrays in C#:
// When we declare an array by using the var keyword then such types of arrays are called implicitly typed arrays in C#.
// Example: var arr = new[] {10, 20, 30 , 40, 50};


// using System;
// namespace ArayDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var Numbers = new[] { 10, 20, 30, 40, 50};
//             for (int i = 0; i < Numbers.Length; i++)
//             {
//                 Console.Write(Numbers[i] + " ");
//             }
//         }
//     }
// }


// Advantages of using an Array in C#:
// 1. It is used to store similar types of multiple data items using a single name.
// 2. We can use arrays to implement other data structures such as linked lists, trees, graphs, stacks, queues, etc.
// 3. The two-dimensional arrays in C# are used to represent matrices.
// 4. The Arrays in C# are strongly typed. That means they are used to store similar types of multiple data items using a single name.


// Disadvantages of using Arrays in C#:
// 1. The array size is fixed
// 2. As the array size is fixed, if we allocate more memory than the requirement then the extra memory will be wasted.
// 3. We can never insert an element into the middle of an array.