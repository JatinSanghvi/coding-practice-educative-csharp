// Shortest Word Distance II
// =========================
//
// Design a data structure that takes in an array of strings and efficiently computes the shortest distance between any
// two different strings in the array.
//
// Implement the `WordDistance` class:
//
// - `WordDistance(String[] wordsDict)`: Initializes the object with an array of strings.
//
// - `int shortest(String word1, String word2)`: Returns the shortest distance between `word1` and `word2` in the array
//   of strings.
//
// Constraints:
//
// - 1 ≤ `wordsDict.length` ≤ 10^3
// - 1 ≤ `wordsDict[i].length` ≤ 10
// - `wordsDict[i]` consists of lowercase English letters
// - `word1` and `word2` are in `wordsDict`
// - `word1` != `word2`
// - At most, 1000 calls will be made to the `shortest`

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P07_ShortestWordDistanceII;

// Space complexity: O(n).
public class WordDistance
{
    private readonly Dictionary<string, List<int>> indexes = new();

    // Time complexity: O(n).
    public WordDistance(string[] wordDict)
    {
        for (int index = 0; index != wordDict.Length; index++)
        {
            string word = wordDict[index];
            if (!indexes.ContainsKey(word))
            {
                indexes.TryAdd(word, new List<int>());
            }

            indexes[word].Add(index);
        }
    }

    // Time complexity: O(n).
    public int Shortest(string word1, string word2)
    {
        List<int> list1 = indexes[word1];
        List<int> list2 = indexes[word2];

        int shortest = int.MaxValue;

        int index1 = 0, index2 = 0;
        while (index1 != list1.Count && index2 != list2.Count)
        {
            int wordIndex1 = list1[index1];
            int wordIndex2 = list2[index2];

            if (wordIndex1 <= wordIndex2)
            {
                shortest = Math.Min(shortest, wordIndex2 - wordIndex1);
                index1++;
            }
            else
            {
                shortest = Math.Min(shortest, wordIndex1 - wordIndex2);
                index2++;
            }
        }

        return shortest;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["a", "b", "c", "d", "e", "a", "c"], [("a", "b"), ("a", "c"), ("a", "d"), ("a", "e")], [1, 1, 2, 1]);
    }

    private static void Run(string[] wordDict, (string, string)[] words, int[] expectedResults)
    {
        var wordDistance = new WordDistance(wordDict);

        for (int i = 0; i != words.Length; i++)
        {
            (string word1, string word2) = words[i];
            int result = wordDistance.Shortest(word1, word2);
            Utilities.PrintSolution((word1, word2), result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
