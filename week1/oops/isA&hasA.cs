// IsA and HasA Relationship in C#
// the concepts of “IsA” and “HasA” relationships are fundamental to understanding inheritance and composition, respectively.


// IsA Relationship (Inheritance):
// The IsA relationship is achieved through inheritance. It represents a hierarchical relationship between a base class (parent) and derived classes (children).

// Characteristics:
// Inheritance: The derived class inherits properties and methods from the base class.
// Polymorphism: The derived class can override or extend the functionalities of the base class.
// Substitutability: Objects of the derived class can be treated as base class objects.


// HasA Relationship (Composition):
// The HasA relationship is used to denote usage or composition. It indicates that an object of one class “contains” or “is composed of” objects from another class.
// This relationship is less tightly coupled than inheritance.

// Characteristics:
// Composition: A class contains or is composed of objects from another class.
// Independence: The contained object (e.g., Engine) can exist independently of the container (e.g., Car).
// Encapsulation: The internal workings of the contained object are usually hidden from the outside class.
// Flexibility and Reusability: Objects can be easily replaced or changed, providing more flexibility in code design.


// IsA and HasA Relationship in C# with Examples:
// class Rectangle{
//           Some Data Members
//           Some Member Functions
// }

// class Cuboid : Rectangle{
//           Some Data Members
//           Some Member Functions
// }

// class Table{
//        Rectangle top;
//        int legs;
// }

// This is the Table class, which is not inherited from any class. This class has two data members. One of the data members is of class Rectangle, and the other is of integer type variable, i.e., top and legs.

// The class Cuboid is inherited from the Rectangle class. So, can we say that a Cuboid IS A Rectangle? Yes. So, the relationship between the Rectangle and Cuboid classes is the IS-A relationship.
// Table class has a top variable that is of the Rectangular type. That means the Table class has an object of the Rectangle class. So, can we say that the Table class HAS A Rectangle? Yes, the Table class Has a Rectangle. So, the relationship between the Table and the Rectangle class is the Has A relationship.



// Example to Understand IS-A Relationship in C#
// using System;
// namespace IsAHasADemo
// {
//     public class Program
//     {
//         static void Main()
//         {
//             Cuboid cuboid = new Cuboid(3, 5, 7);
//             Console.WriteLine($"Volume is : {cuboid.Volume()}");
//             Console.WriteLine($"Area is : {cuboid.Area()}");
//             Console.WriteLine($"Perimeter is : {cuboid.Perimeter()}");
//         }
//     }
//     class Rectangle
//     {
//         //Data Members
//         public int Length;
//         public int Breadth;

//         //Member Functions
//         public int Area()
//         {
//             return Length * Breadth;
//         }
//         public int Perimeter()
//         {
//             return 2 * (Length + Breadth);
//         }
//     }

//     //Establishing Parent-Child Relationship
//     //IS-A Relationship i.e. Cuboid IS-A Rectangle
//     class Cuboid : Rectangle
//     {
//         public int Height;
//         public Cuboid(int l, int b, int h)
//         {
//             Length = l;
//             Breadth = b;
//             Height = h;
//         }
//         public int Volume()
//         {
//             return Length * Breadth * Height;
//         }
//     }
// }


// Example to Understand HAS-A Relationship in C#
// using System;
// namespace IsAHasADemo
// {
//     public class Program
//     {
//         static void Main()
//         {
//             Address address = new Address("B1-3029", "BBSR", "Odisha");
//             Employee employee = new Employee(1001, "Ramesh", address);
//             employee.Display();
//         }
//     }
//     class Address
//     {
//         public string AddressLine, City, State;
//         public Address(string addressLine, string city, string state)
//         {
//             AddressLine = addressLine;
//             City = city;
//             State = state;
//         }
//     }
//     class Employee
//     {
//         //Using Address in Employee class
//         //Establishing Has-A relationship i.e. Employee HAS-A Address   
//         public Address address; 
//         public int Id;
//         public string Name;
//         public Employee(int id, string name, Address adrs)
//         {
//             Id = id;
//             Name = name;
//             address = adrs;
//         }
//         public void Display()
//         {
//             Console.WriteLine($"Employee Id: {Id}");
//             Console.WriteLine($"Employee Name: {Name}");
//             Console.WriteLine($"AddressLine: {address.AddressLine}");
//             Console.WriteLine($"City: {address.City}");
//             Console.WriteLine($"State: {address.State}");
//         }
//     }
// }