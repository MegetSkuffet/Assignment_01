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

    [Fact]
    public void Resolution_test(){
        var resolutions = "4000x2000, 5000x2000, 786868x20";
        var result = RegExpr.Resolution(resolutions);

       
        Assert.Equal(new List<(int, int)> {(4000,2000), (5000,2000), (786868,20)}, result);
    }

    [Fact]
    public void html_to_innertext(){
        var html = "<p>hej med <i>dig</i></p>";
        var result = RegExpr.InnerText(html,"p");

       
        Assert.Equal(new string[]{"hej med dig"}, result);
    }

    [Fact]
    public void html_to_innertext_with_link(){
        var html = "<a href='asd'><p>hej med <i>dig</i> <a href='google.dk'>link</a></p></a>";
        var result = RegExpr.InnerText(html,"a");

       
        Assert.Equal(new string[]{"hej med dig link"}, result);
    }
}