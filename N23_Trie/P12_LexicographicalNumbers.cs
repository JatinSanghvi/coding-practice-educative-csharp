// Lexicographical Numbers
// =======================
//
// Given an integer value n, write a function that returns all the numbers in the range 1 to n in lexicographical order.
//
// Constraints:
//
// - 1 ≤ n ≤ 5×10^4

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P12_LexicographicalNumbers;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static IList<int> LexicographicalOrder(int n)
    {
        var order = new List<int>(n);
        int prefix = 1;

        for (int i = 0; i != n; i++)
        {
            order.Add(prefix);

            if (prefix * 10 <= n)
            {
                prefix *= 10;
                continue;
            }

            while (prefix == n || prefix % 10 == 9)
            {
                prefix /= 10;
            }

            prefix++;
        }

        return order;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(12, [1, 10, 11, 12, 2, 3, 4, 5, 6, 7, 8, 9]);
    }

    private static void Run(int n, int[] expectedResult)
    {
        int[] result = Solution.LexicographicalOrder(n).ToArray();
        Utilities.PrintSolution(n, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
