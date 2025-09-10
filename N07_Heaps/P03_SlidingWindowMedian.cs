// Sliding Window Median
// =====================
//
// Given an integer array, `nums`, and an integer, `k`, there is a sliding window of size `k`, which is moving from the
// very left to the very right of the array. We can only see the `k` numbers in the window. Each time the sliding window
// moves right by one position.
//
// Given this scenario, return the median of each window. Answers within 10^-5 of the actual value will be accepted.
//
// Constraints:
//
// - 1 ≤ `k` ≤ `nums.length` ≤ 10^3
// - -2^31 ≤ `nums[i]` ≤ 2^31 - 1

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P03_SlidingWindowMedian;

public class Solution
{
    // Time complexity: O(n*logn) (amortized), Space complexity: O(n).
    public static double[] MedianSlidingWindow(int[] nums, int k)
    {
        var lowerNums = new PriorityQueue<int, int>();
        var upperNums = new PriorityQueue<int, int>();
        var removeNums = new Dictionary<int, int>();
        int lowerExtra = 0;

        var medians = new double[nums.Length - k + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if (lowerNums.Count == 0 || num <= lowerNums.Peek())
            {
                lowerNums.Enqueue(num, -num-1); // -num-1 is necessary to handle -2^31
                if (lowerNums.Count - lowerExtra == upperNums.Count + 2)
                {
                    int num2 = lowerNums.Dequeue();
                    upperNums.Enqueue(num2, num2);
                }
            }
            else
            {
                upperNums.Enqueue(num, num);
                if (upperNums.Count == lowerNums.Count - lowerExtra + 1)
                {
                    int num2 = upperNums.Dequeue();
                    lowerNums.Enqueue(num2, -num2-1);
                }
            }

            if (i >= k)
            {
                int removeNum = nums[i - k];
                removeNums.TryAdd(removeNum, 0);
                removeNums[removeNum]++;
                lowerExtra += removeNum <= lowerNums.Peek() ? 1 : -1;

                // The following while-loop can possibly be optimized.
                while (true)
                {
                    // Lazily remove old numbers only when they have reached the top of the heap.
                    while (lowerNums.Count != 0 && removeNums.ContainsKey(lowerNums.Peek()) && removeNums[lowerNums.Peek()] != 0)
                    {
                        removeNums[lowerNums.Dequeue()]--;
                        lowerExtra--;
                    }

                    while (upperNums.Count != 0 && removeNums.ContainsKey(upperNums.Peek()) && removeNums[upperNums.Peek()] != 0)
                    {
                        removeNums[upperNums.Dequeue()]--;
                        lowerExtra++;
                    }

                    if (lowerNums.Count - lowerExtra < upperNums.Count)
                    {
                        int num2 = upperNums.Dequeue();
                        lowerNums.Enqueue(num2, -num2-1);
                    }
                    else if (lowerNums.Count - lowerExtra > upperNums.Count + 1)
                    {
                        int num2 = lowerNums.Dequeue();
                        upperNums.Enqueue(num2, num2);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (i >= k - 1)
            {
                medians[i - k + 1] = k % 2 == 0
                    ? (upperNums.Peek() / 2.0 + lowerNums.Peek() / 2.0) // Handle integer overflow.
                    : lowerNums.Peek();
            }
        }

        return medians;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 4, 2, 3, 1, 4], 6, [2.5]);
        Run([1, 4, 2, 3, 1, 4], 5, [2.0, 3.0]);
        Run([1, 4, 2, 3, 1, 4], 4, [2.5, 2.5, 2.5]);
        Run([1, 4, 2, 3, 1, 4], 3, [2.0, 3.0, 2.0, 3.0]);
        Run([1, 4, 2, 3, 1, 4], 2, [2.5, 3.0, 2.5, 2.0, 2.5]);
        Run([1, 4, 2, 3, 1, 4], 1, [1.0, 4.0, 2.0, 3.0, 1.0, 4.0]);
        Run([3, 4, 5, 6, 1, 2], 2, [3.5, 4.5, 5.5, 3.5, 1.5]);
    }

    private static void Run(int[] nums, int k, double[] expectedResult)
    {
        double[] result = Solution.MedianSlidingWindow(nums, k);
        Utilities.PrintSolution((nums, k), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
