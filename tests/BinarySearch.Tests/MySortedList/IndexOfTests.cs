using BinarySearch.Console.Models;
using FluentAssertions;
using MySortedListModel = BinarySearch.Console.Models.MySortedList;

namespace BinarySearch.Tests.MySortedList;

public class IndexOfTests
{
    [Fact]
    public void GivenExistingElement_ThenReturnItsIndex()
    {
        var mySortedList = new MySortedListModel();

        mySortedList.Add(1, 3, 5, 7, 9);

        var index = mySortedList.IndexOf(7);

        index.Should().Be(3);
    }

    [Fact]
    public void GivenThereIsNoElement_ThenReturnNull()
    {
        var mySortedList = new MySortedListModel();

        mySortedList.Add(1, 3, 5, 7, 9);

        var index = mySortedList.IndexOf(13);

        index.Should().BeNull();
    }
}
