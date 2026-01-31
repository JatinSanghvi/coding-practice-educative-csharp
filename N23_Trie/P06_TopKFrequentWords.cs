// Top K Frequent Words
// ====================
//
// Given a list of strings `words` and an integer `k`, return the `k` most frequently occurring strings.
//
// > Note: The result should be sorted in descending order based on frequency. If multiple words have the same
// > frequency, they should be sorted in lexicographical order.
//
// Constraints:
//
// - 1 ≤ `words.length` ≤ 100
// - 1 ≤ `words[i].length` ≤ 10
// - 1 ≤ `k` ≤ number of unique words in the list
// - `words[i]` consists of lowercase English letters.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P06_TopKFrequentWords;

public class Solution
{
    // Time complexity: O(n*logk), Space complexity: O(n).
    public static IList<string> TopKFrequentWords(IList<string> words, int k)
    {
        // Trie does not make sense for this problem.
        var counts = new Dictionary<string, int>();

        foreach (string word in words)
        {
            counts[word] = counts.GetValueOrDefault(word) + 1;
        }

        var queue = new PriorityQueue<string, (int, string)>(new FrequencyComparer());

        foreach ((string word, int count) in counts)
        {
            queue.Enqueue(word, (count, word));
            if (queue.Count == k + 1)
            {
                queue.Dequeue();
            }
        }

        var frequentWords = new Stack<string>();
        while (queue.Count != 0)
        {
            frequentWords.Push(queue.Dequeue());
        }

        return frequentWords.ToList();
    }

    private class FrequencyComparer : IComparer<(int, string)>
    {
        public int Compare((int, string) x, (int, string) y)
        {
            return x.Item1 != y.Item1 ? x.Item1.CompareTo(y.Item1) : -x.Item2.CompareTo(y.Item2);
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["a", "ab", "a", "ab", "ba", "b"], 3, ["a", "ab", "b"]);
    }

    private static void Run(string[] words, int k, string[] expectedResult)
    {
        string[] result = Solution.TopKFrequentWords(words, k).ToArray();
        Utilities.PrintSolution((words, k), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
