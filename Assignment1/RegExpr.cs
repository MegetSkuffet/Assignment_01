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

    public static IEnumerable<(int width, int height)> Resolution(string resolutions) 
    {
        var pattern = @"(?<width>[0-9]+)[x+](?<height>[0-9]+)";
            var matches = Regex.Matches(resolutions, pattern);
            foreach (Match match in matches)
            {
                var groups = match.Groups;
                int width = Int32.Parse(groups["width"].Value);
                int height = Int32.Parse(groups["height"].Value);
                yield return (width, height);
            }
    }

    public static IEnumerable<string> InnerText(string html, string tag) 
    {
            var pattern = $@"<{tag}>(?<innertext>.+)</{tag}>";
            var matches = Regex.Matches(html, pattern);

             foreach (Match match in matches)
             {
                var value = match.Groups["innertext"].Value;
                Regex rg = new Regex(@"(</?.?>)");
                string innertext = rg.Replace(value,"");
                yield return innertext;
             }
           
    }
    

    public static IEnumerable<(Uri url, string title)> Urls(string html) => throw new NotImplementedException();
}

