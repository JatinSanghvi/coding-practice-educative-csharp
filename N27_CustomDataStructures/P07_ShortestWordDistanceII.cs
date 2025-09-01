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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P07_ShortestWordDistanceII;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
