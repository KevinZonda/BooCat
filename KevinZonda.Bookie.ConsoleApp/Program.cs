﻿using HtmlAgilityPack;

using KevinZonda.Bookie.Library;
using KevinZonda.Bookie.Library.Provider;


var z = new Zibrary();
var m = z.SearchBook(Console.ReadLine()).Result;
foreach (var item in m)
{
    Console.WriteLine(item);
}
