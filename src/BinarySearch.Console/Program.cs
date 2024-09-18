using BinarySearch.Console.Models;

Console.WriteLine("*** Binary Search example ***");
Console.WriteLine("*****************************");
Console.WriteLine();

Console.Write("Provide sorted items separated by comma: ");
var sortedItems = Console.ReadLine()!
    .Split(",")
    .Select(x => x.Trim())
    .Select(int.Parse)
    .ToArray();

Console.Write("Provide item you would like to find in that list: ");
var item = int.Parse(Console.ReadLine()!);

var mySortedList = new MySortedList();
mySortedList.Add(sortedItems);
var itemIndex = mySortedList.IndexOf(item);

Console.WriteLine();

if (itemIndex != null)
    Console.WriteLine($"The element was found at index {itemIndex}.");
else
    Console.WriteLine("The element was not found in the list.");

Console.ReadKey();