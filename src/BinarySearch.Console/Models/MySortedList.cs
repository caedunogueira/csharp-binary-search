using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BinarySearch.Tests")]

namespace BinarySearch.Console.Models;

internal class MySortedList
{
    /// <summary>
    /// The purpose to use Array data structure instead of SortedList<T> data structure is to exercise
    /// handling the elements without using existing .NET data structures like SortedList<T>
    /// </summary>
    private int[] _items;

    public MySortedList() =>
        _items = [];

    internal void Add(params int[] newItems)
    {
        var lastIndex = _items.Length - 1;

        Array.Resize(ref _items, _items.Length + newItems.Length);

        for (int i = lastIndex + 1, j = 0; i < newItems.Length; i++, j++) 
            _items[i] = newItems[j];
    }

    internal int? IndexOf(int existingElement)
    {
        var lowerBound = 0;
        var upperBound = _items.Length - 1;

        while (lowerBound <= upperBound)
        {
            var middle = (lowerBound + upperBound) / 2;

            if (existingElement == _items[middle])
                return middle;
            else if (existingElement < _items[middle])
                upperBound = middle - 1;
            else
                lowerBound = middle + 1;
        }
        
        return null;
    }
}
