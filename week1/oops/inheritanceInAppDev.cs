// What is an Entity?
// An Entity is something that is associated with a set of attributes.
// eg. for a bank application customer is an entity.

// Application Development Process:
// Step1: Identify the Entities that are associated with the application
// eg. application for a School
// Entities: Student, TeachingStaff, NonTeachingStaff

// Step2: Identify the attributes of each and every entity.
// Entity: Student
// Student Attributes: Id, Name, Address, Phone, Class, Marks, Grade, Fees

// Entity: TeachingStaff
// TeachingStaff Attributes: Id, Name, Address, Phone, Designation, Salary, Qualification, Subject

// Entity: NonTeachingStaff
// NonTeachingStaff Attributes: Id, Name, Address, Phone, Designation, Salary, DeptName, ManagerId

// Step3: Identify the common attributes and put them in a hierarchical order
// Person (id, name, address, phone)
    // Student (class, marks, grade, fees)
    // Staff (designation, salary)
        // Teaching (qualification, subject)
        // Non teaching (deptName, managerId)

// Step4: Defining the classes that are representing the entities in Hierarchical order
// public class Person
// {
//     public int Id;
//     public string Name;
//     public string Address;
//     public string Phone;
// }

// public class Student : Person
// {
//     public int Class;
//     public float Fees;
//     public float Marks;
//     public char Grade;
// }

// public class Staff : Person
// {
//     string Designation;
//     double Salary;
// }

// public class Teaching : Staff
// {
//     string Qualification;
//     string Subject;
// }
// public class NonTeaching : Staff
// {
//     string Deptname;
//     string ManagerId;
// }