// Types of Inheritance
// 1. Single Inheritance
// 2. Multi-Level Inheritance
// 3. Hierarchical Inheritance
// 4. Hybrid Inheritance
// 5. Multiple Inheritance


// Single Inheritance:
// When a class is inherited from a single base class then the inheritance is called single inheritance.
// B ( derived class ) --> A ( Base Class)

// Multilevel Inheritance:
// When a derived class is created from another derived class, then such a type of inheritance is called Multilevel Inheritance.
// C  ( derived class ) --> B ( Base Class 2 ) --> A ( Base Class 1)

// Hierarchical Inheritance:
// When more than one derived class is created from a single base class then it is called Hierarchical inheritance.

// B ( Derived Class 1 ) ---
//                         |
// C ( Derived Class 2 ) -----> A ( Base Class )
//                         |
// D ( Derived Class 3 ) ---


// Multiple Inheritance:
// When a derived class is created from more than one base class then such type of inheritance is called multiple inheritances.

// C ( Derived Class ) ----------> A ( Base Class 1)
//                          |
//                          -----> B ( Base Class 2)


// Hybrid Inheritance:
// Hybrid Inheritance is the inheritance that is the combination of any Single, Hierarchical, and Multilevel inheritances.

//      -----> B -----
//      |             |
// D ----             -----> A
//      |             |
//      -----> C -----

// There are two subclasses i.e. B and C which are inheriting from class A (Hierarchical inheritance).
// Then from B and C, there is one more class that is D inherits from B and C. (Multiple inheritance).

// The above classification is based on C++.



// Types of Inheritance
// 1. Single Inheritance (Single, Multilevel & Hierarchical)
// 2. Multiple Inheritance (Multiple & Hybrid)


// Example to Understand Single Inheritance in C#:
// using System;
// namespace InheritanceDemo
// {
//     public class Program
//     {
//         static void Main()
//         {
//             // Creating object of Child class and
//             // invoke the methods of Parent and Child classes
//             Cuboid obj =  new Cuboid(2, 4, 6);
//             Console.WriteLine($"Volume is : {obj.Volume()}");
//             Console.WriteLine($"Area is : {obj.Area()}");
//             Console.WriteLine($"Perimeter is : {obj.Perimeter()}");
//         }
//     }
//     //Parent class
//     public class Rectangle
//     {
//         public int length;
//         public int breadth;
//         public int Area()
//         {
//             return length * breadth;
//         }
//         public int Perimeter()
//         {
//             return 2 * (length + breadth);
//         }
//     }
    
//     //Child Class
//     class Cuboid : Rectangle
//     {
//         public int height;
//         public Cuboid(int l, int b, int h)
//         {
//             length = l;
//             breadth = b;
//             height = h;
//         }
//         public int Volume()
//         {
//             return length * breadth * height;
//         }
//     }
// }


// Example to Understand Multiple Inheritance in C#:
// using System;
// namespace InheritanceDemo
// {
//     public class Program
//     {
//         static void Main()
//         {
//             // Creating object of Child class and
//             // invoke the methods of Parent classes and Child class
//             SmartPhone obj = new SmartPhone(); ;
//             obj.GetPhoneModel();
//             obj.GetCameraDetails();
//             obj.GetDetails();
//         }
//     }
//     //Parent Class 1
//     class Phone
//     {
//         public void GetPhoneModel()
//         {
//             Console.WriteLine("Redmi Note 5 Pro");
//         }
//     }
//     //Parent class2
//     class Camera
//     {
//         public void GetCameraDetails()
//         {
//             Console.WriteLine("24 Mega Pixel Camera");
//         }
//     }

//     //Child Class derived from more than one Parent class
//     class SmartPhone : Phone, Camera
//     {
//         public void GetDetails()
//         {
//             Console.WriteLine("Its a RedMi Smart Phone");
//         }
//     }
// }

// Note: Handling the complexity caused due to multiple inheritances is very complex. Hence it was not supported in dot net with class and it can be done with interfaces.


// Classification of Inheritance in C#
// 1. Implementation inheritance: Whenever a class is derived from another class then it is known as implementation inheritance.
// 2. Interface inheritance: Whenever a class is derived from an interface then it is known as interface inheritance.
