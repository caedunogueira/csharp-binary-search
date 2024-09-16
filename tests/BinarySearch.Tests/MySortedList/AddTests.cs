using FluentAssertions;
using MySortedListModel = BinarySearch.Console.Models.MySortedList;

namespace BinarySearch.Tests.MySortedList;

public class AddTests
{
    [Fact]
    public void GivenElement_ThenAddToArray()
    {
        var mySortedList = new MySortedListModel();

        mySortedList.HasElements().
            Should().
            BeFalse("There is no element added to MySortedList newly created.");

        mySortedList.Add(5);

        mySortedList.HasElements()
            .Should()
            .BeTrue("There are elements added to MySortedList.");
    }
}
