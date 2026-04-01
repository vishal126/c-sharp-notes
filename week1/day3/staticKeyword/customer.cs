// namespace StaticKeyowrdDemo
// {
//     public class Customer
//     {
//         public string CustomerCode { get; set; }
//         public string CustomerName { get; set; }
//         private string MachineName = "";
//         private bool IsEmpty(string value)
//         {
//             if(value.Length > 0)
//             {
//                 return true;
//             }

//             return false;
//         }        
//         public void Insert()
//         {
//             if(IsEmpty(CustomerCode) && IsEmpty(CustomerName))
//             {
//                 //Insert the data
//             }
//         }
//     }
// }

//we need to use the IsEmpty method in staticKeyword.cs  so we need to make it public
// namespace StaticKeyowrdDemo
// {
//     public class Customer
//     {
//         public string CustomerCode { get; set; }
//         public string CustomerName { get; set; }
//         private string MachineName = "";
//         public bool IsEmpty(string value)
//         {
//             if(value.Length > 0)
//             {
//                 return true;
//             }

//             return false;
//         }        
//         public void Insert()
//         {
//             if(IsEmpty(CustomerCode) && IsEmpty(CustomerName))
//             {
//                 //Insert the data
//             }
//         }
//     }
// }

// we violate the OOPs principle.

// How we are Violating the OOPs Principle?
// Once you created the Customer class object, and when you write the object name and dot operator, then the intelligence will show you all the public members of the Customer class
// we have exposed the CustomerCode, CustomerName, Insert, and IsEmpty methods
// There is a clear violation of the Abstraction OOPs Principle. Abstraction means showing only what is necessary
// The IsEmpty method is for internal use i.e. used by other internal methods of the class and not by the consumer of the class.
// In this case, the Program class is the consumer of the Customer class i.e. Program class is going to consume the Customer class. As we make the IsEmpty method as public, we are violating the OOPs principle.
// In the same way, we are also violating the abstraction principle with the CountryMaster object as we are exposing the ComputerName property to the external world.


// How to solve the above problem?
// we need to create a commonTask.cs

// namespace StaticKeyowrdDemo
// {
//     public class Customer
//     {
//         public string CustomerCode { get; set; }
//         public string CustomerName { get; set; }
//         private string MachineName = "";

//         public Customer()
//         {
//             CommonTask commonTask = new CommonTask();
//             MachineName = commonTask.ComputerName;
//         }

//         public void Insert()
//         {
//             CommonTask commonTask = new CommonTask();
//             if (!commonTask.IsEmpty(CustomerCode) && !commonTask.IsEmpty(CustomerName))
//             {
//                 //Insert the data
//             }
//         }
//     }
// }


// How do we avoid Inheritance, how do we avoid abstraction, or how do we avoid the OOPs principle in a class?
// Modify the Customer Class:
namespace StaticKeyowrdDemo
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        private string MachineName = "";

        public Customer()
        {
            MachineName = CommonTask.GetComputerName();
        }
        
        public void Insert()
        {
            if(!CommonTask.IsEmpty(CustomerCode) && !CommonTask.IsEmpty(CustomerName))
            {
                //Insert the data
            }
        }
    }
}