using System.Collections.Generic;
using Xunit;

public class WordFinderTests
{
    [Fact]
    public void Find_ShouldReturnWordsFoundInMatrix()
    {
        // Arrange
        var matrix = new List<string>
        {
            "coldw",
            "oiznz",
            "llilz",
            "ldhiz",
            "zwind"
        };

        var wordstream = new List<string> { "cold", "wind", "chill", "snow", "ice" };
        var wordFinder = new WordFinder.Core.WordFinder(matrix);

        // Act
        var foundWords = wordFinder.Find(wordstream);

        // Assert
        var expectedWords = new List<string> { "cold", "wind" };
        Assert.Equal(expectedWords.OrderBy(w => w), foundWords.OrderBy(w => w));
    }

    [Fact]
    public void Find_ShouldReturnEmptyWhenNoWordsFound()
    {
        // Arrange
        var matrix = new List<string>
        {
            "abcd",
            "efgh",
            "ijkl",
            "mnop"
        };

        var wordstream = new List<string> { "xyz", "uvw" };
        var wordFinder = new WordFinder.Core.WordFinder(matrix);

        // Act
        var foundWords = wordFinder.Find(wordstream);

        // Assert
        Assert.Empty(foundWords);
    }

    [Fact]
    public void Find_ShouldReturnTop10MostRepeatedWords()
    {
        // Arrange
        var matrix = new List<string>
        {
            "abcdefghij",
            "klmnopqrst",
            "uvwxyzabcd",
            "efghijklmn",
            "opqrstuvwx",
            "yzabcdefgh",
            "ijklmnopqr",
            "stuvwxyzab",
            "cdefghijkl",
            "mnopqrstuv"
        };

        var wordstream = new List<string>
        {
            "abcd", "mnop", "qrst", "uvwx", "ijkl", "efgh", "mnop",
            "qrst", "uvwx", "ijkl", "efgh", "mnop", "qrst", "uvwx",
            "ijkl", "efgh", "mnop", "qrst", "uvwx", "ijkl", "efgh"
        };
        var wordFinder = new WordFinder.Core.WordFinder(matrix);

        // Act
        var foundWords = wordFinder.Find(wordstream);

        // Assert
        var expectedWords = new List<string> { "abcd", "efgh", "ijkl", "mnop", "qrst", "uvwx" };
        Assert.Equal(expectedWords.OrderBy(w => w), foundWords.OrderBy(w => w));
    }
}
