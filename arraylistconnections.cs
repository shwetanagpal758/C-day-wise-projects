// using System;
// namespace shweta
// {
//     class Program
//     {
//         static void Main (string[] args)
//         {
//             var names= new List<string> {"<name>","raju","mohit"};
//             foreach( string name in names)
//             {
//                 Console.WriteLine($"{name.ToUpper()}");
//             }
//             names.Add("hi");
//             names.Add("hello");
//             names.Remove("raju");
//             foreach(string name in names)
//             {
//                 Console.WriteLine(name);
//             }
//             Console.WriteLine($"my name is{names[0]}");
//             Console.WriteLine($"The list has {names.Count} people in it.");

//             var index = names.IndexOf("mohit");
//             Console.WriteLine($" the name { names[index]} is at index{index}");

//             var notfound = names.IndexOf("ashu");
//             Console.WriteLine($"Name is not found, Index returns {notfound}");

//             names.Sort();
//             foreach(var name in names)
//             {
//                 Console.WriteLine($"hi{name.ToUpper()}");
//             }   
//         }
//     }
// }