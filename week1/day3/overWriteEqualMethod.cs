// What is Equals Method in C#?
// The Equals is a virtual method defined in the Object class and this method is available to all the .NET Types as Object is the superclass of all .NET Types.

// As Equals is a virtual method, we can also override this method under our classes. The following is the signature of this method.
// public virtual bool Equals(object obj): This method is used to determine whether the specified object is equal to the current object. Here, the parameter obj specifies the object to compare with the current object. It returns true if the specified object is equal to the current object; otherwise, false.


// Difference Between the “==” Operator and the Equals() Method in C#:
// using System;
// namespace UnderstandingEqualsMethod
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             int Number1 = 10;
//             int Number2 = 10;
//             Console.WriteLine($"Number1 == Number2: {Number1 == Number2}");
//             Console.WriteLine($"Number1.Equals(Number2): {Number1.Equals(Number2)}");
//         }
//     }
// }


// Equals method and == Operator with Enum Type in C#:
// using System;
// namespace UnderstandingEqualsMethod
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             Direction direction1 = Direction.East;
//             Direction direction2 = Direction.East;
//             Console.WriteLine(direction1 == direction2);
//             Console.WriteLine(direction1.Equals(direction2));
//         }
//     }
//     public enum Direction
//     {
//         East = 1,
//         West = 2,
//         North = 3,
//         South = 4
//     }
// }

// Equals method and == Operator with Reference Type in C#:
// If the type is a reference type, then by default both the == operator and Equals method check for reference equality whereas we can change this default behavior of the Equals() method by overriding it to check for value equality.

// The most important point that you need to keep in mind is reference variables are different from objects. Reference variables are created on the stack memory and they point to the actual objects which are stored in the heap memory.
// using System;
// namespace UnderstandingEqualsMethod
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             Customer C1 = new Customer();
//             C1.FirstName = "Pranaya";
//             C1.LastName = "Rout";

//             Customer C2 = C1;

//             Console.WriteLine($"C1 == C2: {C1 == C2}");
//             Console.WriteLine($"C1.Equals(C2): {C1.Equals(C2)}");
//         }
//     }
//     public class Customer
//     {
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//     }
// }


// In the following example, the == operator returns False. This makes sense because C1 and C2 are referring to different objects.
// However, the Equals() method also returns false, in spite of the values across C1 and C2 being the same and this is because by default Equals method checks the reference equality.
// using System;
// namespace UnderstandingEqualsMethod
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             Customer C1 = new Customer();
//             C1.FirstName = "Pranaya";
//             C1.LastName = "Rout";

//             Customer C2 = new Customer();
//             C2.FirstName = "Pranaya";
//             C2.LastName = "Rout";

//             Console.WriteLine($"C1 == C2: {C1 == C2}");
//             Console.WriteLine($"C1.Equals(C2): {C1.Equals(C2)}");
//         }
//     }
//     public class Customer
//     {
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//     }
// }


// Now, if you want the Equals method to check the values stored inside the object instead of the reference address, then we need to override the Equals method inside the Customer class and if the value is equal then we need to return TRUE.

// Overriding the Equals Method of the Object Class in C#:
// using System;
// namespace UnderstandingEqualsMethod
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             Customer C1 = new Customer();
//             C1.FirstName = "Pranaya";
//             C1.LastName = "Rout";

//             Customer C2 = new Customer();
//             C2.FirstName = "Pranaya";
//             C2.LastName = "Rout";

//             Console.WriteLine($"C1 == C2: {C1 == C2}");
//             Console.WriteLine($"C1.Equals(C2): {C1.Equals(C2)}");
//         }
//     }
//     public class Customer
//     {
//         public string FirstName { get; set; }
//         public string LastName { get; set; }

//         public override bool Equals(object obj)
//         {
//             // If the passed object is null, return False
//             if (obj == null)
//             {
//                 return false;
//             }
//             // If the passed object is not Customer Type, return False
//             if (!(obj is Customer))
//             {
//                 return false;
//             }
//             return (this.FirstName == ((Customer)obj).FirstName)
//                 && (this.LastName == ((Customer)obj).LastName);
//         }
//     }
// }

// The GetHashCode() Requirement
// If you override Equals(), you must override GetHashCode(). Why?
// In C#, there are highly optimized data structures like Dictionary<TKey, TValue> and HashSet<T>. To find objects instantly, they don't use .Equals() right away (which is slow).
// They use a mathematical integer signature called a Hash Code (which is blazing fast).
// The Rule: If two objects are considered "Equal" (because they have the same data), they must generate the exact same Hash Code. If you override .Equals() without updating GetHashCode(), Dictionaries will completely break and lose your data in memory.