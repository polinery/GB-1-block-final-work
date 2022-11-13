using System;
using static System.Console;
Clear();

string[] startArray = {"hello", "2", "world", ":-)"};
// ["hello", "2", "world", ":-)"]
// ["1234", "1567", "-2", "computer science"]
// ["Russia", "Denmark", "Kazan"]

var newArray = startArray.Where(x => x.Length < 4).ToArray();

WriteLine($"[{String.Join(", ", newArray)}]");