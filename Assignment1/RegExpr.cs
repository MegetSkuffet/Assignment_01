namespace Assignment1;
using System.Text.RegularExpressions;

public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
    {
        var pattern = @"\w+";
        foreach (var line in lines)
        {
            var matches = Regex.Matches(line, pattern);
            foreach (Match word in matches)
            {
                yield return word.Value;
            }
        }

         
        /*foreach(string line in lines) {
            var words = Regex.Split(line, @" ").ToList();
            foreach(var word in words) yield return word;
        }*/
    }

    public static IEnumerable<(int width, int height)> Resolution(string resolutions) => throw new NotImplementedException();

    public static IEnumerable<string> InnerText(string html, string tag) => throw new NotImplementedException();
}