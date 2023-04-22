using System;
namespace shweta
{
    class Program
    {
        public static void Main (string[] args)
        {
            var account= new bankaccount("shweta", 1000);
            Console.WriteLine($"account{account.number} was created for{account.owner} with {account.balance}. ");
        }
    }
}
// using System;
// namespace shweta
// {
//     class Program
//     {
//         public static async Task Main (string[] args)
//         {
//             var account= bankaccount("shweta",1000);
//             Console.WriteLine($"account(account.number) was created for(account.owner) with (account.balance). ");
//         }

        
//     }
// }


// using System;
// namespace shweta
// {
//     // class Abc
//     // {
//     //     static void Main (string[] args)
//     //     {
//     // string afriend = "bill";
//     // Console.WriteLine(afriend);
//     // Console.WriteLine("hello");
//     // Console.WriteLine("hi" + afriend);
//     //     }
//     }    
// }    