// Create Maximum Number
// =====================
//
// You are given two integer arrays, `nums1` and `nums2`, of lengths `m` and `n`, respectively. Each array represents
// the digits of a number.
//
// You are also given an integer `k`. Create the largest possible number of length `k` (where `k` ≤ `m` + `n`) using
// digits from both arrays. You may interleave digits from the two arrays, but the relative order of digits within the
// same array must be preserved.
//
// Return an array of `k` digits representing the maximum number.
//
// Constraints:
//
// - `m` == `nums1.length`
// - `n` == `nums2.length`
// - 1 ≤ `m`, `n` ≤ 500
// - 0 ≤ `nums1[i]`, `nums2[i]` ≤ 9
// - 1 ≤ `k` ≤ `m` + `n`
// - `nums1` and `nums2` do not have leading zeros.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P15_CreateMaximumNumber;

public class Solution
{
    // Time complexity: O((m+n).k^2), Space complexity: O((m+n).k).
    public static int[] MaxNumber(int[] num1, int[] num2, int k)
    {
        var cache = new Dictionary<(int start1, int start2, int k), IEnumerable<int>>();
        return MaxNumberInternal(0, 0, k).ToArray();

        IEnumerable<int> MaxNumberInternal(int start1, int start2, int k)
        {
            if (k == 0)
            {
                return Enumerable.Empty<int>();
            }

            (int start1, int start2, int k) cacheKey = (start1, start2, k);

            if (!cache.ContainsKey(cacheKey))
            {
                int take = (num1.Length - start1) + (num2.Length - start2) - k + 1;
                (int maxIndex1, int maxDigit1) = GetMaxDigitIndex(num1, start1, take);
                (int maxIndex2, int maxDigit2) = GetMaxDigitIndex(num2, start2, take);

                if (maxDigit1 > maxDigit2)
                {
                    cache[cacheKey] = new List<int> { maxDigit1 }
                        .Concat(MaxNumberInternal(maxIndex1 + 1, start2, k - 1));
                }
                else if (maxDigit2 > maxDigit1)
                {
                    cache[cacheKey] = new List<int> { maxDigit2 }
                        .Concat(MaxNumberInternal(start1, maxIndex2 + 1, k - 1));
                }
                else
                {
                    cache[cacheKey] = new List<int> { maxDigit1 }
                        .Concat(
                            GetMaxSequence(
                                MaxNumberInternal(maxIndex1 + 1, start2, k - 1),
                                MaxNumberInternal(start1, maxIndex2 + 1, k - 1)));
                }
            }

            return cache[cacheKey];
        }
    }

    public static (int, int) GetMaxDigitIndex(int[] num, int start, int take)
    {
        int maxIndex = -1;
        int maxDigit = -1;

        for (int index = start; index < start + take && index < num.Length; index++)
        {
            if (maxDigit < num[index])
            {
                maxIndex = index;
                maxDigit = num[index];
            }
        }

        return (maxIndex, maxDigit);
    }

    public static IEnumerable<int> GetMaxSequence(IEnumerable<int> num1, IEnumerable<int> num2)
    {
        foreach ((int digit1, int digit2) in num1.Zip(num2))
        {
            if (digit1 > digit2) { return num1; }
            else if (digit2 > digit1) { return num2; }
        }

        return num1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 1, new[] { 3 });
        Run(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 2, new[] { 3, 3 });
        Run(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 4, new[] { 3, 3, 2, 1 });
        Run(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 5, new[] { 3, 2, 3, 2, 1 });
        Run(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 6, new[] { 3, 2, 1, 2, 3, 1 });

        // int[] num = Enumerable.Repeat(5, 100).ToArray();
        // int[] expectedResult = Enumerable.Repeat(5, 200).ToArray();
        // Run(num, num, 200, expectedResult);
    }

    private static void Run(int[] num1, int[] num2, int k, int[] expectedResult)
    {
        int[] result = Solution.MaxNumber(num1, num2, k);
        Utilities.PrintSolution((num1, num2, k), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
