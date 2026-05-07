// what is it?
// It enable us to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.

// Extension methods are a special kind of static method, but they are called as if they were instance methods on the extended type.

// for client code written in c# and visual basic, there is no apparent difference between calling an extension method and then methods are actually defined in a type.


// LINQ standard query operators (select, where etc) are implemented in Enumerable class as extension methods on the  IEnumerable<T> interface.

// query:
// List<int> Numbers = new List<int> {1,2,3,4,5,6,7,8,9,19};
// IEnumerable<int> EvenNumbers = Numbers.Where(n=>n%2 == 0);

// In spite of Where() method not belonging to List<T> class, we are still able to use it as though it belong to List<T> class.
// This is possible because Where() method is implemented as extension method in IEnumerable<T> interface and List<T> implements IEnumerable<T> interface.


// eg
// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Demo
{
    class Program
    {
        string strName = "pragim";
        // string result = strName.ChangeFirstLetterCase();
        // we are unable to use the above method it gives compile time error
        
        // to enable the function to work we need to use one of the following way:
        // add this method to the string class which is not possible as string class belongs to dotnet framework.
        // or
        // create a base class and define the method there then make string class inherit from it.
        // or
        // create a wrapper or helper class (works)  (see string helper class below)
    }
}


// StringHelper.cs
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

// namespace Demo
// {
//     public class StringHelper
//     {
//         public static string ChangeFirstLetterCase(string inputString)
//         {
//             if(inputString.Length > 0)
//             {
//                 char[] charArray = inputString.ToCharArray();
//                 charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
//                 return new string(charArray);
//             }

//             return inputString;
//         }
//     }
// }

// if we call the method now using: string result = strName.ChangeFirstLetterCase();
// we are still unable to use the above function as this method does not belongs to the string class.

// to use this function call using: string result = StringHelper.ChangeFirstLetterCase(strName);

// but to achieve call from the string variable it self we need to do few changes in StringHelper class.
// make the StringHelperClass static
// the type that we want to use should be the first parameter & preceed it with this keyword.

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

// namespace Demo
// {
//     public static class StringHelper
//     {
//         public static string ChangeFirstLetterCase(this string inputString)
//         {
//             if(inputString.Length > 0)
//             {
//                 char[] charArray = inputString.ToCharArray();
//                 charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
//                 return new string(charArray);
//             }

//             return inputString;
//         }
//     }
// }


// now we are able to use the above method as : string result = strName.ChangeFirstLetterCase();
// for above code behind the scenes it will get convert to: string result = StringHelper.ChangeFirstLetterCase(strName); --> (wrapper class syntax)


// so all the extension method available in System.Linq namespace we are able to use them using wrapper class syntax.

// eg
// List<int> Numbers = new List<int> {1,2,3,4};
// IEnumerable<int> Even = Numbers.Where(n=>n%2 == 0); 
// foreach(int evenNo in Even)
// {
//      Console.WriteLine(evenNo);
// }

// calling above method using wrapper syntax
// IEnumerable<int> Even = Enumerable.Where(Numbers, n=>n%2 == 0); 