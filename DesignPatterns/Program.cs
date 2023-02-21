using DesignPatterns;
using DesignPatterns.Interfaces;
using DesignPatterns.Models;
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

// Open/Closed Principle
Product[] products =
{
    new Product("Apple", Color.Green, Size.Small),
    new Product("Tree", Color.Green, Size.Large),
    new Product("House", Color.Blue, Size.Large)
};

var pf = new ProductFilter();
WriteLine("Green products (old):");
foreach (var product in pf.FilterByColor(products, Color.Green))
{
    WriteLine($" - {product.Name} is green");
}

WriteLine("Filter By Size");
foreach (var product in pf.FilterBySize(products, Size.Large))
{
    WriteLine($" - {product.Name} is large");
}

WriteLine("Filter By Color via Open Closed Principle");
var bf = new BetterFilter();
foreach (var product in bf.Filter(products, new ColorSpecification(Color.Green)))
{
    WriteLine($" - {product.Name} is green");
}

WriteLine("Filter By Size and Color via Open Closed Principle");
IEnumerable<ISpecification<Product>> Specifications = new List<ISpecification<Product>>()
{
    new ColorSpecification(Color.Green),
    new SizeSpecification(Size.Small),
    new NameSpecification("Apple")
};
foreach (var product in bf.Filter(products, new AndSpecification(Specifications)))
{
    WriteLine($" - {product.Name} is an apple and green and large");
}