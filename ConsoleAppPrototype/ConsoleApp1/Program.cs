// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Models;

Console.WriteLine("Hello, World!");
var suffixText = " [Changed after cloning]";
var unit = new Unit("Kg", "Unit for counting mass", false);
var storageProduct = new StorageProduct(1, "Potatoes", "Red", 10, "Big Storage of Irkutsk", unit);

Console.WriteLine("IMyCloneable block:");
Console.WriteLine("Making clone with MemberwiseClone, including nested class types:");
var myClone1 = storageProduct.CloneWithInners();
myClone1.Name += suffixText;
myClone1.Unit.Name += suffixText;
Console.WriteLine("storageProduct: " + storageProduct.ToString());
Console.WriteLine("myClone1: " + myClone1.ToString() + "\n");

Console.WriteLine("\"Making clone with MemberwiseClone, without nested types:");
var myClone2 = storageProduct.CloneMemberWise();
myClone2.Name += suffixText + "1";
myClone2.Unit.Name += suffixText + "1";
Console.WriteLine("storageProduct: " + storageProduct.ToString());
Console.WriteLine("myClone2: " + myClone2.ToString() + "\n");

Console.WriteLine("Making clone with ctor:");
var myClone3 = myClone2.CloneCtor();
myClone3.Name += suffixText + "2";
myClone3.Unit.Name += suffixText + "2";
Console.WriteLine("myClone2: " + myClone2.ToString());
Console.WriteLine("myClone3: " + myClone3.ToString());
Console.WriteLine("End of block");
Console.WriteLine("");

Console.WriteLine("IClonable block:");
Console.WriteLine("Making clone through ICloneable interface, without nested types:");
var unit2 = new Unit("Meter", "Unit for counting distance", false);
var storageProduct2 = new StorageProduct(2, "Asphalt", "N/A", 100, "Big Storage of Irkutsk", unit2);
var clone1 = storageProduct2.Clone() as StorageProduct;
clone1.Name += suffixText + "3";
clone1.Unit.Name += suffixText + "3";

Console.WriteLine("storageProduct2: " + storageProduct2.ToString());
Console.WriteLine("clone1: " + clone1.ToString());
Console.WriteLine("End of block");
Console.WriteLine("");
//TODO: Fix ToString Overrides, Debug this, Add conclusion of using IMyCloneable vs ICloneable