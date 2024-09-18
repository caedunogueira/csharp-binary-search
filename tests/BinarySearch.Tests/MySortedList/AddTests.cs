using FluentAssertions;
using MySortedListModel = BinarySearch.Console.Models.MySortedList;

namespace BinarySearch.Tests.MySortedList;

public class AddTests
{
    [Theory]
    [MemberData(nameof(SortedItems))]
    public void GivenElement_ThenAddToArray(int[] sortedItems)
    {
        var mySortedList = new MySortedListModel();

        mySortedList.Items.Should().BeEmpty("There is no elements in a newly instance.");

        mySortedList.Add(sortedItems);

        mySortedList.Items.Should().BeEquivalentTo(sortedItems);
    }

    public static IEnumerable<object[]> SortedItems
    {
        get
        {
            yield return new object[] { new int[] { 5 } };
            yield return new object[] { new int[] { 1, 3, 5, 7, 9 } };
        }
    }
}
