// namespace StaticKeywordDemo
// {
//     public class CommonTask
//     {
//         public bool IsEmpty(string value)
//         {
//             if (value.Length > 0)
//             {
//                 return true;
//             }

//             return false;
//         }

//         public string GetComputerName()
//         {
//             return System.Environment.MachineName;
//         }
//     }
// }


// What is the problem in the above solution?
// This CommonTask class is a collection of unrelated methods and properties that are not related to each other. Because it has unrelated methods, properties, or logic, it does not represent any real-world objects.
// As it does not represent any real-world objects, so any kind of OOPs principles (inheritance, abstraction, polymorphism, encapsulation) should not be applied to this CommonTask class.
// So, in simple words, we can say that this is a fixed class i.e. a class with a fixed behavior. That is, its behavior cannot be changed by inheritance, and its behavior cannot be polymorphism by using either static or dynamic polymorphism. So, we can say that this class is a fixed class or static class.

// How do we avoid Inheritance, how do we avoid abstraction, or how do we avoid the OOPs principle in a class?
// The answer is by using the static keyword

namespace StaticKeywordDemo
{
    public static class CommonTask
    {
        public static bool IsEmpty(string value)
        {
            if (value.Length > 0)
            {
                return true;
            }

            return false;
        }

        public static string ComputerName
        {
            get
            {
                return System.Environment.MachineName;
            }
        }
    }
}


// How is the Static Class Instantiated in C#?
// We cannot apply any OOPs principles to the static class like inheritance, polymorphism, encapsulation, and abstraction. But in the end, it is a class.
// And at least to use a class it has to be instantiated. Why because once it is instantiated. then only the static members get memory allocation.
// Until and unless the memory is not allocated, we cannot access them.
// So, if the static class is not instantiated then we cannot invoke the methods and properties that are present inside the static class.
// The CLR (Common Language Runtime) internally will create only one instance of the CommonTask class irrespective of how many times they called from the Customer and CountryMaster class. And it is going to be created for the first time when we use consume the CommonTask class.
// Due to the single instance behavior, the static class is also going to be used to share the common data.