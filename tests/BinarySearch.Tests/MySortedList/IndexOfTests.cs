using FluentAssertions;
using MySortedListModel = BinarySearch.Console.Models.MySortedList;

namespace BinarySearch.Tests.MySortedList;

public class IndexOfTests
{
    [Theory]
    [MemberData(nameof(ExistingElements))]
    public void GivenExistingElement_ThenReturnItsIndex(int[] elements, int existingElement, int expectedElement)
    {
        var mySortedList = new MySortedListModel();

        mySortedList.Add(elements);

        var index = mySortedList.IndexOf(existingElement);

        index.Should().Be(expectedElement);
    }

    [Fact]
    public void GivenThereIsNoElement_ThenReturnNull()
    {
        var mySortedList = new MySortedListModel();

        mySortedList.Add(1, 3, 5, 7, 9);

        var index = mySortedList.IndexOf(13);

        index.Should().BeNull();
    }

    public static IEnumerable<object[]> ExistingElements
    {
        get
        {
            yield return new object[] 
            { 
                new int[] { 1 },    // elements
                1,                  // existing element
                0                   // expected index
            };
            yield return new object[] 
            { 
                new int[] { 1, 3 }, // elements
                3,                  // existing element
                1                   // expected index
            };
            yield return new object[] 
            { 
                new int[] { 1, 3, 5, 7, 9 },    // elements
                7,                              // existing element
                3                               // expected index
            };
        }
    } 
}