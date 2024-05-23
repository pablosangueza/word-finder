using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordFinder.App
{
    public class WordFinder : IWordFinder
    {
        private char[][] _matrix;
        private int _rows;
        private int _cols;

        public WordFinder(IEnumerable<string> matrix)
        {
            _matrix = matrix.Select(row => row.ToCharArray()).ToArray();
            _rows = _matrix.Length;
            _cols = _matrix[0].Length;

        }
        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            var foundWords = new HashSet<string>();
            var wordCounts = new Dictionary<string, int>();

            foreach (var word in wordstream)
            {
                if (foundWords.Contains(word)) continue; // Avoid processing the same word multiple times
                if (ExistsInMatrix(word))
                {
                    foundWords.Add(word);
                    if (!wordCounts.ContainsKey(word))
                        wordCounts[word] = 0;
                    wordCounts[word]++;
                }
            }
            return wordCounts.OrderByDescending(pair => pair.Value)
                              .ThenBy(pair => pair.Key)
                              .Take(10)
                              .Select(pair => pair.Key);
        }
       

        private bool ExistsInMatrix(string word)
        {
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col < _cols; col++)
                {
                    if (SearchHorizontally(word, row, col) || SearchVertically(word, row, col))
                        return true;
                }
            }
            return false;
        }

        private bool SearchHorizontally(string word, int row, int col)
        {
            if (col + word.Length > _cols) return false;

            for (int i = 0; i < word.Length; i++)
            {
                if (_matrix[row][col + i] != word[i])
                    return false;
            }
            return true;
        }

        private bool SearchVertically(string word, int row, int col)
        {
            if (row + word.Length > _rows) return false;
            for (int i = 0; i < word.Length; i++)
            {
                if (_matrix[row + i][col] != word[i])
                    return false;
            }
            return true;
        }
    }
}