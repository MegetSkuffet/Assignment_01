namespace Assignment1.Tests;

public class IteratorsTests
{
    // Test Iterators.cs
    [Fact]
    public void Flatten_Given_123_123_123_should_return_123123123(){
        var list = new List<List<int>> {new List<int> {1, 2, 3},new List<int> {1, 2, 3},new List<int> {1,2,3}};
        var flattened = Iterators.Flatten(list);
        Assert.Equal(new List<int> {1,2,3,1,2,3,1,2,3}, flattened);
    }
}