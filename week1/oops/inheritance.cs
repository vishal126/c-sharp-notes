// What is Inheritance in C#?
// Inheritance in C# is a mechanism of consuming the members that are defined in one class from another class.
// The members defined in one class can be consumed by another class by establishing a parent/child relationship between the classes.


// How to Implement Inheritance in C#?
// we need to establish a Parent/Child relationship between classes.

// class A
// {
//     // members
// }

// class B: A
// {
//     // consuming the members of A
// }


// syntax: [<modifiers>] class <child class> : <parent class>

// the terminology Parent Class and Child Class can also be called Base Class (Superclass) and Derived Class (Subclass).


// the child class will consume all the members of the Parent class except the private members.

// class A
// {
//     public void Method1()
//     {
//         Console.WriteLine("Method 1");
//     }
//     public void Method2()
//     {
//         Console.WriteLine("Method 2");
//     }
// }


// class B : A
// {
//     static void Main()
//     {
//         B obj = new B();
//         obj.Method1();
//         obj.Method2();
//     }
// }


// we can create the child class own methods as well.
// using System;
// namespace InheritanceDemo
// {
//     class A
//     {
//         public void Method1()
//         {
//             Console.WriteLine("Method 1");
//         }
//         public void Method2()
//         {
//             Console.WriteLine("Method 2");
//         }
//     }
//     class B : A
//     {
//         public void Method3()
//         {
//             Console.WriteLine("Method 3");
//         }
//         static void Main()
//         {
//             B obj = new B();
//             obj.Method1();
//             obj.Method2();
//             obj.Method3();
//         }
//     }
// }



// 6 important Rules:
// 1. In C#, the parent classes constructor must be accessible to the child class; otherwise, the inheritance would not be possible
// because when we create the child class object, first it goes and calls the parent class constructor so that the parent class variable will be initialized and we can consume them under the child class.
// Why is Parent Class Constructor Accessible to Child Class?
// when the Parent class constructor is called, only the parent class members will be initialized.
// 2. In inheritance, the child class can access the parent class members, but the parent classes can never access any members that are purely defined in the child class.
// using System;
// namespace InheritanceDemo
// {
//     class A
//     {
//         public A()
//         {
//             Console.WriteLine("Class A Constructor is Called");
//         }
//         public void Method1()
//         {
//             Console.WriteLine("Method 1");
//         }
//         public void Method2()
//         {
//             Console.WriteLine("Method 2");
//         }
//     }
//     class B : A
//     {
//         public B()
//         {
//             Console.WriteLine("Class B Constructor is Called");
//         }
//         public void Method3()
//         {
//             Console.WriteLine("Method 3");
//         }
//         static void Main()
//         {
//             A obj = new A();
//             obj.Method1();
//             obj.Method2();
//             //The following line of code gives you compile time error
//             obj.Method3();
//         }
//     }
// }

// 3. We can Initialize a Parent class variable by using the child class instance to make it a reference variable so that the reference will be consuming the memory of the child class instance.
// we cannot call any pure child class members using the reference.
// what is a reference? The answer is a Reference is a pointer to an instance that does not have any memory allocation.
// using System;
// namespace InheritanceDemo
// {
//     class A
//     {
//         public A()
//         {
//             Console.WriteLine("Class A Constructor is Called");
//         }
//         public void Method1()
//         {
//             Console.WriteLine("Method 1");
//         }
//         public void Method2()
//         {
//             Console.WriteLine("Method 2");
//         }
//     }
//     class B : A
//     {
//         public B()
//         {
//             Console.WriteLine("Class B Constructor is Called");
//         }
//         public void Method3()
//         {
//             Console.WriteLine("Method 3");
//         }
//         static void Main()
//         {
//             A p; //p is a variable of class A
//             B q = new B(); //q is an instance of Class B 

//             //We can initialize a Parent class variable using child class instance as follows
//             p = q; //now, p is a reference of parent class created by using child class instance

//             //Now you can call members of A class as follows
//             p.Method1();
//             p.Method2();

//             //We cannot call any pure child class members using the reference p
//             //p.Method3();
//         }
//     }
// } 

// 4. Every class that is defined by us or predefined in the libraries of the language has a default parent class, i.e., the Object class of the System namespace, so the members (Equals, GetHashCode, GetType, and ToString) of the Object class are accessible from anywhere.
// Generally, when we define a class, we think that we did not inherit it from any class. But by default, our class is Inherited from the Object class. So, Object is the parent class for all the classes defined in our Base Class Library as well as all the classes that we defined in our application.
// Because Object is the parent class, four important methods (Equals, GetHashCode, GetType, and ToString) of the Object class can be called or accessed from anywhere.
// static void Main()
// {
//     object obj = new object();
//     obj.Equals(obj);
//     obj.GetHashCode(obj);
//     obj.GetType();
//     obj.ToString(obj);
// }

// Now, let us create an object of class A, and when you type obj., then the intelligence shows 6 methods, i.e., 2 methods (Method1 and Method2) from class A and four methods (Equals, GetHashCode, GetType, and ToString) from Object class.
// Generally, when you compile your code, the compiler verifies if this class is inheriting from any other class. If yes, there are no issues. If no, automatically compiler makes this class inherited from the Object class.


// What is the Default Parent Class in C#?
// The Default Parent class is the Object class present in the System namespace.
// using System;
// namespace InheritanceDemo
// {
//     class A
//     {
//         public A()
//         {
//             Console.WriteLine("Class A Constructor is Called");
//         }
//         public void Method1()
//         {
//             Console.WriteLine("Method 1");
//         }
//         public void Method2()
//         {
//             Console.WriteLine("Method 2");
//         }
//     }
//     class B : A
//     {
//         public B()
//         {
//             Console.WriteLine("Class B Constructor is Called");
//         }
//         public void Method3()
//         {
//             Console.WriteLine("Method 3");
//         }
//         static void Main()
//         {
//             Object obj1 = new Object();
//             Console.WriteLine($"obj1 type: {obj1.GetType()}");
//             A obj2 = new A();
//             Console.WriteLine($"obj2 type: {obj2.GetType()}");
//             B obj3 = new B();
//             Console.WriteLine($"obj3 type: {obj3.GetType()}");
//         }
//     }
// }

// 5. In C#, we don’t have support for multiple inheritances through classes.
// That means with classes, only one immediate parent class is allowed (i.e., Single, Multilevel, and Hierarchical supported), and more than one immediate parent class is not allowed in C# with classes (i.e., Multiple and Hybrid are not supported). 

// 6.  the constructor of the Parent class is parameterized, then the Child class constructor cannot implicitly call its Parent’s constructor. So, to overcome this problem, it is the responsibility of the programmer to explicitly call the Parent classes constructor from the child class constructor and pass values to those parameters.
// To call the Parent’s constructor from the child class, we need to use the base keyword.

// using System;
// namespace InheritanceDemo
// {
//     class A
//     {
//         public A(int number)
//         {
//             Console.WriteLine($"Class A Constructor is Called : {number}");
//         }
//         public void Method1()
//         {
//             Console.WriteLine("Method 1");
//         }
//         public void Method2()
//         {
//             Console.WriteLine("Method 2");
//         }
//     }

//     class B : A
//     {
//         public B() : base(10)
//         {
//             Console.WriteLine("Class B Constructor is Called");
//         }
//         public void Method3()
//         {
//             Console.WriteLine("Method 3");
//         }
//         static void Main()
//         {
//             B obj = new B();
//         }
//     }
// }


// How to pass dynamic value to Parent class constructor in C#?
// using System;
// namespace InheritanceDemo
// {
//     class A
//     {
//         public A(int number)
//         {
//             Console.WriteLine($"Class A Constructor is Called : {number}");
//         }
//         public void Method1()
//         {
//             Console.WriteLine("Method 1");
//         }
//         public void Method2()
//         {
//             Console.WriteLine("Method 2");
//         }
//     }

//     class B : A
//     {
//         public B(int num) : base(num)
//         {
//             Console.WriteLine("Class B Constructor is Called");
//         }
//         public void Method3()
//         {
//             Console.WriteLine("Method 3");
//         }
//         static void Main()
//         {
//             B obj1 = new B(10);
//             B obj2 = new B(20);
//             B obj3 = new B(30);
//         }
//     }
// }


// Advantages of Inheritance in C#:
// Code reusability