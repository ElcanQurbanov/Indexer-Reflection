﻿

using Indexer_Reflection;
using Indexer_Reflection.Controllers;
using System.Reflection;
using System.Runtime.InteropServices;




#region Indexer, Reflection
//Book book1 = new Book() { Id = 1, Name = "Xosrov" };
//Book book2 = new Book() { Id = 2, Name = "7 gozel" };


//Library library = new();

////library.Books[0] = book1;
////library.Books[1] = book2;

////Console.WriteLine(library.Books[0].Name);
////Console.WriteLine(library.Books[1].Name);

//library[0] = book1;
//library[1] = book2;

//Console.WriteLine(library[0].Name);
//Console.WriteLine(library[1].Name);


//Assembly assembly = Assembly.GetExecutingAssembly();

//foreach (var item in assembly.GetTypes())
//{
//	foreach (var item2 in item.GetMembers())
//	{
//		Console.WriteLine(item2);
//	}
//}
#endregion


AccountController account = new AccountController();

account.Register();





