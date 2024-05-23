using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordFinder.App
{
    public interface IWordFinder
    {
        IEnumerable<string> Find(IEnumerable<string> wordstream);
    }
}