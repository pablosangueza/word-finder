// See https://aka.ms/new-console-template for more information
using WordFinder.App;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Word Finder");
        var matrix = new List<string>
        {
            "coldw",
            "oiznz",
            "llilz",
            "ldhiz",
            "zwind"
        };
        var wordstream = new List<string> { "cold", "wind", "chill", "snow", "cold", "ice" };

        IWordFinder wordFinder = new WordFinder.App.WordFinder(matrix);
        
        var foundWords = wordFinder.Find(wordstream);

        Console.WriteLine("Found Words:");
        foreach (var word in foundWords)
        {
            Console.WriteLine(word);
        }
    }
}