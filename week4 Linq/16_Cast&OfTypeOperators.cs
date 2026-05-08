// Continue of part 15

// Cast operator
// It attempts to convert all of the items within an existing collection to another type and return them in a new collection.
// if an item fails conversion an exception will be thrown. This method uses deferred execution.


// ArrayList list = new ArrayList();
// list.Add(1);
// list.Add(2);
// list.Add(3);

// The following item causes an exception list.Add("ABC");

// IEnumerable<int> result = list.Cast<int>();

// foreach (int i in result)
// {
//     Console.WriteLine(i);
// }



// OfType
// This will return only elements of the specified type.
// The other type elements are simply ignored and excluded from the result set.

// ArrayList list = new ArrayList();
// list.Add(1);
// list.Add(2);
// list.Add(3);
// list.Add("4");
// list.Add("ABC");

// IEnumerable<int> result = list.OfType<int>();

// foreach (int i in result)
// {
//     Console.WriteLine(i);
// }



// using System.Collections;

// namespace Demo
// {
//     class Program
//     {
//         public static void Main()
//         {
            // Cast
            // ArrayList list = new ArrayList();
            // list.Add(1);
            // list.Add(2);
            // list.Add(3);

            // IEnumerable<int> result = list.Cast<int>();

            // foreach (int i in result)
            // {
            //     Console.WriteLine(i);
            // }

            // OfType
            // ArrayList list = new ArrayList();
            // list.Add(1);
            // list.Add(2);
            // list.Add(3);
            // list.Add("4");
            // list.Add("ABC");

            // IEnumerable<int> result = list.OfType<int>();

            // foreach (int i in result)
            // {
            //     Console.WriteLine(i);
            // }
//         }
//     }
// }



// difference b/w both
// OfType operator returns only the elements of the specified type and the rest of the items in the collection will be ignored and excluded from the result.
// Cast operator will try to cast all the elements in the collection into the specified type. If some of the items fail conversion, InvalidCastException will be thrown.

// When to use cast over OfType & vice versa?
// we generally use cast when the following 2 conditions are met
// 1. we want to cast all the items in the collection &
// 2. we know for sure the collection contains only elements of the specified type

// If we want to filter the elements and return only the ones of the specified type, then we would OfType.