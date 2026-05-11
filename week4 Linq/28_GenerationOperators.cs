// Generation operators
// Range Repeat Empty

// Range operator genereates a sequence of intergers within a specified range.
// This method has 2 integer parameters. The start param specifies the integer to start with and the count parameter specifies the number of sequential intergers to generate.

// var evenNumbers = Enumerable
//                     .Range(1, 10)
//                     .Where(x => x % 2 == 0);

// foreach (int i in evenNumbers)
// {
//     Console.WriteLine(i);
// }


// Repeat operator is used to generate a sequence that contains one repeated value

// for eg. the following code returns a string sequence that conatins 5 "Hello" string objects in it

// var result = Enumerable.Repeat("Hello", 5);

// foreach(var v in result)
// {
//     Console.WriteLine(v);
// }

// Empty operator returns an empty sequence of the specified type.

// ex.
// Enumerable.Empty<int>()  Returns an empty IEnumerable<int>
// Enumerable.Empty<string>() Returns an empty IEnumerable<string>



namespace Demo
{
    class Program
    {
        public static void Main()
        {
            IEnumerable<int> evenNumbers = Enumerable
                    .Range(1, 10)
                    .Where(x => x % 2 == 0);

            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            var result = Enumerable.Repeat("Hello", 5);

            foreach(var v in result)
            {
                Console.WriteLine(v);
            }

            Enumerable.Empty<int>();
            Enumerable.Empty<string>();
        }
    }
}