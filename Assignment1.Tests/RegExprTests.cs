namespace Assignment1.Tests;

public class RegExprTests
{
     // Test regex.cs
    [Fact]
    public void splitline_given_hejmeddig_returns_hej_med_dig(){
        var list = new List<string>{"hej med dig"};
        var result = RegExpr.SplitLine(list);

       
        Assert.Equal(new List<string> {"hej","med","dig"}, result);
    }
}