// What is linq?
// It stands for language integrated query.
// LINQ enables us to query any type of data store (SQL server, XML documents, Objects in memory etc)

// why to use?
// dot net application ------> ado.net sql | database
//                             xpath xslt | xml documents
//                             arrays generics | in memory objects

// linq enables us to work with different data sources using a similar coding style without having the need to know the syntax specific to the data source.
// another benefit of using is it provides intellisense and compile time error checking.

// Linq architecture

// Dot net application (c#, vb, j#, others)
//             linq query
//           linq providers
// (linq to xml, linq to sql, linq to objects, linq to entities, linq to dataset)
//           Data sources
// (xml docs, databases, object data, entities, datasets)

// linq query can be written using any .NET supported programming language
// linq provider is a component between the linq query and the actual data source, which converts the linq query into a format that the underlying data source can understand.

// eg. linq to sql provider converts a linq query to tsql that sql server db can understand. 

// problems with  ado.net
// it has no intellisense as the query is inside the string so there can be typo error which will not give the compile time error and gives runtime error.


// LINQ query
// for db

// from student in dataContext.Students
// where student.Gender == "Male"
// select student;


// for in memory objects
// int[] numbers = {1, 2,3,4,5,6,7,8,9,10};
// from number in numbers
// where (umber%2) == 0
// select number;