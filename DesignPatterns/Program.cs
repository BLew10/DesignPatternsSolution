using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


var j = new Journal();
j.AddEntry("I cried today.");
j.AddEntry("I ate a bug.");
Console.WriteLine(j);
var p = new Persistence();
// @ sign allows you to use backslashes in a string and reads it as verbatim
var filename = @"C:\Users\BrandonLewis\source\repos\journal.txt";
p.SaveToFile(j, filename, true);
