// K Maximum Sum Combinations From Two Arrays
// ==========================================
//
// You are given two integer arrays, `arr1` and `arr2`, each of size n. You are also given an integer `k`. Your task is
// to return the `k` largest sum combinations that can be formed by adding one element from `arr1` and one element from
// `arr2`, for all possible pairs (`arr1[i]` + `arr2[j]`), where 0 ≤ i, j < n.
//
// > Note: The output should be sorted in non-increasing order.
//
// Constraints:
//
// - 1 ≤ n ≤ 1000
// - 1 ≤ `arr1[i]`, `arr2[i]` ≤ 10^3
// - 1 ≤ k ≤ n

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P13_KMaximumSumCombinationsFromTwoArrays;

public class Solution
{
    // Time complexity: O(n1*logn1 + n2*logn2 + klogk), Space complexity: O(k).
    public List<int> MaxCombinations(List<int> arr1, List<int> arr2, int k)
    {
        arr1.Sort((a, b) => b - a);
        arr2.Sort((a, b) => b - a);

        var combinations = new List<int>(k);

        var queue = new PriorityQueue<(int i1, int i2), int>();
        queue.Enqueue((0, 0), -(arr1[0] + arr2[0]));

        var visited = new HashSet<(int, int)> { (0, 0) };

        for (int i = 0; i < k; i++)
        {
            queue.TryDequeue(out (int, int) item, out int negativeSum);
            (int i1, int i2) = item;
            combinations.Add(-negativeSum);

            if (i1 != arr1.Count - 1 && !visited.Contains((i1 + 1, i2)))
            {
                queue.Enqueue((i1 + 1, i2), -(arr1[i1 + 1] + arr2[i2]));
                visited.Add((i1 + 1, i2));
            }

            if (i2 != arr2.Count - 1 && !visited.Contains((i1, i2 + 1)))
            {
                queue.Enqueue((i1, i2 + 1), -(arr1[i1] + arr2[i2 + 1]));
                visited.Add((i1, i2 + 1));
            }
        }

        return combinations;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3], [3, 2, 1], 9, [6, 5, 5, 4, 4, 4, 3, 3, 2]);
    }

    private static void Run(List<int> arr1, List<int> arr2, int k, List<int> expectedResult)
    {
        List<int> result = new Solution().MaxCombinations(arr1, arr2, k);
        Utilities.PrintSolution((arr1, arr2, k), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
