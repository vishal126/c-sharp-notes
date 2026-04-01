// Why do we need Properties in C#?
// In order to encapsulate and protect the data members (i.e. fields or variables) of a class, we use properties in C#.
// The Properties in C# are used as a mechanism to set and get the values of data members of a class outside of that class.

// If a class contains any values in it and if we want to access those values outside of that class, then we can provide access to those values in 2 different ways.
// 1. By storing the value under a public variable, we can give direct access to the value outside of the class.
// 2. By storing that value in a private variable, we can also give access to that value outside of the class by defining a property for that variable.


// What is a Property in C#?
// A Property in C# is a member of a class that is used to set and get the data from a data field (i.e. variable) of a class.
// We use the Properties as they are public data members of a class, but they are actually special methods called **accessors**.

// What are Accessors in C#?
// The Assessors are nothing but special methods which are used to set and get the values from the underlying data member (i.e. variable) of a class.
// Assessors are of two types.
// 1. Set Accessor
// 2. Get Accessor

// What is a Set Accessor?
// The set accessor is used to set the data (i.e. value) into a data field i.e. a variable of a class.
// This set accessor contains a fixed variable named value.
// Whenever we call the property to set the data, whatever data (value) we are supplying will come and store inside the variable called value by default.
// Syntax: set { Data_Field_Name = value; }

// What is Get Accessor?
// The get accessor is used to get the data from the data field i.e. variable of a class.
// Syntax: get {return Data_Field_Name;}

// using System;
// namespace PropertyDemo
// {
//     public class Employee
//     {
//         //Private Data Members
//         private int _EmpId;
//         private string _EmpName;

//         //Public Properties
//         public int EmpId
//         {
//             //The Set Accessor is used to set the _EmpId private variable value
//             set
//             {
//                 _EmpId = value;
//             }
//             //The Get Accessor is used to return the _EmpId private variable value
//             get
//             {
//                 return _EmpId;
//             }
//         }
//         public string EmpName
//         {
//             //The Set Accessor is used to set the _EmpName private variable value
//             set
//             {
//                 _EmpName = value;
//             }
//             //The Get Accessor is used to return the _EmpName private variable value
//             get
//             {
//                 return _EmpName;
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee employee = new Employee();
//             //We cannot access the private data members
//             //So, using public properties (SET Accessor) we are setting 
//             //the values of private data members
//             employee.EmpId = 101;
//             employee.EmpName = "Pranaya";

//             //Using public properties (Get Accessor) we are Getting 
//             //the values of private data members
//             Console.WriteLine("Employee Details:");
//             Console.WriteLine("Employee id:" + employee.EmpId);
//             Console.WriteLine("Employee name:" + employee.EmpName);
//         }
//     }
// } 


// What are the Different types of Properties Supported by C#.NET?
// 1. Read-Only Property
// 2. Write Only Property
// 3. Read Write Property
// 4. Auto-Implemented Property


// What is Read-only Property in C#?
// The Read-Only Property is used to read the data from the data field i.e. read the data of a variable.
// This property will contain only one accessor i.e. get accessor.

// Syntax:
// AccessModifier Datatype PropertyName
// {
//       get {return DataFieldName;}
// }


// What is Write only Property in C#?
//  Write-Only Property is used to write the data into the data field i.e. write the data to a variable of a class.
// This property will contain only one accessor i.e. set accessor.

// Syntax:
// AccessModifier Datatype PropertyName
// {
//      set {DataFieldName = value;}
// }


// What is Read Write Property in C#?
// The Read-Write Property is used for both reading the data from the data field as well as writing the data into the data field of a class.
// This property will contain two accessors i.e. set and get. The set accessor is used to set or write the value to a data field and the get accessor is read the data from a variable.

// Syntax:
// AccessModifier Datatype PropertyName
// {
//       set {DataFieldName = value;}
//       get {return DataFieldName;}
// }


// Note: Whenever we create a property for a variable, the data type of the property must be the same as the data type of the variable. A property can never accept any argument.


// Example to understand the Read and Write Property
// using System;
// namespace PropertyDemo
// {
//     public class Employee
//     {
//         //Private Data Members
//         private int _EmpId, _Age;
//         private string _EmpName, _Address;

//         //Public Properties
//         public int EmpId
//         {
//             //The Set Accessor is used to set the _EmpId private variable value
//             set
//             {
//                 _EmpId = value;
//             }
//             //The Get Accessor is used to return the _EmpId private variable value
//             get
//             {
//                 return _EmpId;
//             }
//         }

//         public int Age
//         {
//             //The Set Accessor is used to set the _Age private variable value
//             set
//             {
//                 _Age = value;
//             }
//             //The Get Accessor is used to return the _Age private variable value
//             get
//             {
//                 return _Age;
//             }
//         }
//         public string EmpName
//         {
//             //The Set Accessor is used to set the _EmpName private variable value
//             set
//             {
//                 _EmpName = value;
//             }
//             //The Get Accessor is used to return the _EmpName private variable value
//             get
//             {
//                 return _EmpName;
//             }
//         }
//         public string Address
//         {
//             //The Set Accessor is used to set the _Address private variable value
//             set
//             {
//                 _Address = value;
//             }
//             //The Get Accessor is used to return the _Address private variable value
//             get
//             {
//                 return _Address;
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee employee = new Employee();
//             //We cannot access the private data members
//             //So, using public properties (SET Accessor) we are setting 
//             //the values of private data members
//             employee.EmpId = 101;
//             employee.Age = 101;
//             employee.EmpName = "Pranaya";
//             employee.Address = "BBSR, Odisha, India";

//             //Using public properties (Get Accessor) we are Getting 
//             //the values of private data members
//             Console.WriteLine("Employee Details:");
//             Console.WriteLine($"Id: {employee.EmpId}");
//             Console.WriteLine($"Name: {employee.EmpName}");
//             Console.WriteLine($"Age: {employee.Age}");
//             Console.WriteLine($"Address: {employee.Address}");
//         }
//     }
// }



// Example to understand the Read-Only and Write-Only Properties
// using System;
// namespace PropertyDemo
// {
//     public class Calculator
//     {
//         int _Number1, _Number2, _Result;

//         //Write-Only Properties
//         //Only Set Accessor, No Get Accessor
//         public int SetNumber1
//         {
//             set
//             {
//                 _Number1 = value;
//             }
//         }
//         public int SetNumber2
//         {
//             set
//             {
//                 _Number2 = value;
//             }
//         }

//         //Read-Only Property
//         //Only Get Accessor, No Set Accessor
//         public int GetResult
//         {
//             get
//             {
//                 return _Result;
//             }
//         }
//         public void Add()
//         {
//             _Result = _Number1 + _Number2;
//         }
//         public void Sub()
//         {
//             _Result = _Number1 - _Number2;
//         }
//         public void Mul()
//         {
//             _Result = _Number1 * _Number2;
//         }
//         public void Div()
//         {
//             _Result = _Number1 / _Number2;
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Calculator calculator = new Calculator();
//             Console.WriteLine("Enter two Numbers:");
//             calculator.SetNumber1 = int.Parse(Console.ReadLine());
//             calculator.SetNumber2 = int.Parse(Console.ReadLine());

//             calculator.Add();
//             Console.WriteLine($"The Sum is: {calculator.GetResult}");

//             calculator.Sub();
//             Console.WriteLine($"The Sub is: {calculator.GetResult}");

//             calculator.Mul();
//             Console.WriteLine($"The Mul is: {calculator.GetResult}");

//             calculator.Div();
//             Console.WriteLine($"The Div is: {calculator.GetResult}");
//         }
//     }
// }


// What are the advantages of using Properties in C#?
// 1. Properties will provide the abstraction to the data fields.
// 2. They also provide security to the data fields.
// 3. Properties can also validate the data before storing it in the data fields.


// What is the Default Accessibility Specifier of Accessors in C#?
// The default accessibility specifier of the accessor is the same as the accessibility specifier of the property.

// public int EmpId
// {
//      set { _EmpId = value; }
//      get {  return _EmpId; }
// }

// In the above example, the property Empid is declared as public. So, the set and get accessor will be public. If the property is private then both set and get accessors will also be private.


// What are symmetric and asymmetric accessors in C#?
// If the accessibility specifier of the accessors (both get and set) are the same within a property accessibility specifier then the accessors are known as symmetric accessors.

// public int EmpId
// {
//       protected set { _EmpId = value; }
//       get { return _EmpId; }
// }


// In the above property, the set accessor is declared as protected while the get accessor is public by default, so they are known as asymmetric.
// In general, asymmetric accessors are used in the inheritance process.


// We can also write the Read-only property using two accessors as follows.
// public int EmpId
// {
//       private set { _EmpId = value; }
//       get { return _EmpId; }
// }

// We can also write the Write only property using two accessors as follows.
// public int EmpId
// {
//       set { _EmpId = value; }
//       private get { return _EmpId; }
// }


// Note: The point that you need to remember is once you declare the accessor as private, then you cannot access that accessor from outside the class.


// What are Auto-Implemented Properties in C#?
// If you do not have any additional logic while setting and getting the data from a data field i.e. from a variable of a class, then you can make use of the auto-implemented properties which was introduced as part of C# 3.0.
// The Auto-Implemented Property in C# reduces the amount of code that we have to write.
// When we use auto-implemented properties, then the C# compiler implicitly creates a private, anonymous field or variable for that property behind the scene which is going to hold the data.

// Syntax: Access_specifier Datatype Property_Name { get; set; }
// Example: public int A { get; set; }

// using System;
// namespace PropertyDemo
// {
//     public class Employee
//     {
//         public int Id { get; set; }
//         public int Age { get; set; }
//         public string Name { get; set; }
//         public string Address { get; set; }

//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee employee = new Employee();
//             employee.Id = 101;
//             employee.Age = 101;
//             employee.Name = "Pranaya";
//             employee.Address = "BBSR, Odisha, India";

//             Console.WriteLine("Employee Details:");
//             Console.WriteLine($"Id: {employee.Id}");
//             Console.WriteLine($"Name: {employee.Name}");
//             Console.WriteLine($"Age: {employee.Age}");
//             Console.WriteLine($"Address: {employee.Address}");
//         }
//     }
// }


// Why do we need Properties in C# Real-time Applications?
// Declaring the class fields or variables as public and exposing those fields or variables to the outside world is bad as we do not have any control over what gets assigned and what gets returned.

// using System;
// namespace PropertyDemo
// {
//     public class Student
//     {
//         public int ID;
//         public string Name;
//         public int PassMark;
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student student = new Student();
//             student.ID = -100;
//             student.Name = null;
//             student.PassMark = 0;
//             Console.WriteLine($"ID = {student.ID}, Name = {student.Name}, PassMark = {student.PassMark}");
//         }
//     }
// }

// Problems with the above public fields are as follows
// An ID value should always be a non-negative number.
// The name cannot be set to NULL.
// If a student’s name is missing then we should return “No Name”.
// The PassMark value should always be read-only.


// Example using Setter and Getter Methods in C#:
// using System;
// namespace PropertyDemo
// {
//     public class Student
//     {
//         private int _ID;
//         private string _Name;
//         private int _PassMark = 35;
//         public void SetID(int ID)
//         {
//             if (ID < 0)
//             {
//                 throw new Exception("ID value should be greater than zero");
//             }
//             _ID = ID;
//         }
//         public int GetID()
//         {
//             return _ID;
//         }
//         public void SetName(string Name)
//         {
//             if (string.IsNullOrEmpty(Name))
//             {
//                 throw new Exception("Name should not be empty");
//             }
//             _Name = Name;
//         }
//         public string GetName()
//         {
//             if (string.IsNullOrEmpty(_Name))
//             {
//                 return "No Name";
//             }
//             return _Name;
//         }
//         public int GetPassMark()
//         {
//             return _PassMark;
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student student = new Student();
//             student.SetID(101);
//             student.SetName("Pranaya");
            
//             Console.WriteLine($"ID = {student.GetID()}");
//             Console.WriteLine($"Name = {student.GetName()}");
//             Console.WriteLine($"Pass Mark = {student.GetPassMark()}");
//         }
//     }
// }


// Example using Properties in C#:
// using System;
// namespace PropertyDemo
// {
//     public class Student
//     {
//         private int _ID;
//         private string _Name;
//         private int _PassMark = 35;
//         public int ID
//         {
//             set
//             {
//                 if (value < 0)
//                 {
//                     throw new Exception("ID value should be greater than zero");
//                 }
//                 _ID = value;
//             }
//             get
//             {
//                 return _ID;
//             }
//         }
//         public string Name
//         {
//             set
//             {
//                 if (string.IsNullOrEmpty(value))
//                 {
//                     throw new Exception("Name should not be empty");
//                 }
//                 _Name = value;
//             }
//             get
//             {
//                 return string.IsNullOrEmpty(_Name) ? "No Name" : _Name;
//             }
//         }
//         public int PassMark
//         {
//             get
//             {
//                 return _PassMark;
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student student = new Student();
//             student.ID = 101;
//             student.Name = "Pranaya";
            
//             Console.WriteLine($"ID = {student.ID}");
//             Console.WriteLine($"Name = {student.Name}");
//             Console.WriteLine($"Pass Mark = {student.PassMark}");
//         }
//     }
// }


