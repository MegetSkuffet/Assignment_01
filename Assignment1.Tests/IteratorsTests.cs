namespace Assignment1.Tests;

public class IteratorsTests
{
    // Test Iterators.cs
    [Fact]
    public void Flatten_Given_123_123_123_should_return_123123123()
    {
        var list = new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 3 } };
        var flattened = Iterators.Flatten(list);
        Assert.Equal(new List<int> { 1, 2, 3, 1, 2, 3, 1, 2, 3 }, flattened);
    }

    [Fact]
    //Test that the list is filtered correctly given predicate function
    public void Filter_Given_123_should_return_2()
    {
        Predicate<int> even = Even;
        bool Even(int i) => i % 2 == 0;
        var list = new List<int> { 1, 2, 3, };
        var filtered = Iterators.Filter(list, even);
        Assert.Equal(new List<int> { 2 }, filtered);
    }
}