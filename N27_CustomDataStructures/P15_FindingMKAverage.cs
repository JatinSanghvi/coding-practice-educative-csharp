// Finding MK Average
// ==================
//
// You are given two integers, `m` and `k`, and a stream of integers. Your task is to design and implement a data
// structure that efficiently calculates the MK Average for the stream.
//
// To compute the MK Average, follow these steps:
//
// 1. Stream length check: If the stream contains fewer than `m` elements, return `-1` as the MK Average.
//
// 2. Window selection: Otherwise, copy the last `m` elements of the stream to a separate container and remove the
//    smallest `k` elements and the largest `k` elements from the container.
//
// 3. Average calculation: Calculate the average of the remaining elements (rounded down to the nearest integer).
//
// Implement the `MKAverage` class
//
// - `MKAverage(int m, int k)`: Initializes the object with integers `m` and `k` and an empty stream.
//
// - `void addElement(int num)`: Adds the integer `num` to the stream.
//
// - `int calculateMKAverage()`: Returns the current MK Average for the stream as described above, or `-1` if the stream
//   contains fewer than `m` elements.
//
// Constraints:
//
// - 3 ≤ `m` ≤ 10^5
// - 1 < `k * 2` < m
// - 1 ≤ `num` ≤ 10^5
// - 10^3 calls will be made to `addElement` and `calculateMKAverage`, at most.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P15_FindingMKAverage;

// Space complexity: O(m).
public class MKAverage(int m, int k)
{
    private int[] sortedNums = new int[m];
    private Queue<int> queue = new(m);
    private int sum = 0;

    // Time complexity: O(m).
    public void AddElement(int num)
    {
        int oldNum = 0;
        if (queue.Count == m)
        {
            oldNum = queue.Dequeue();
        }

        queue.Enqueue(num);
        int index = FindIndex(oldNum);

        if (sortedNums[index] < num)
        {
            while (index != m - 1 && sortedNums[index + 1] < num)
            {
                if (index >= k && index <= m - k - 1) { sum += sortedNums[index + 1] - sortedNums[index]; }
                sortedNums[index] = sortedNums[index + 1];
                index++;
            }
        }
        else
        {
            while (index != 0 && sortedNums[index - 1] > num)
            {
                if (index >= k && index <= m - k - 1) { sum += sortedNums[index - 1] - sortedNums[index]; }
                sortedNums[index] = sortedNums[index - 1];
                index--;
            }
        }

        if (index >= k && index <= m - k - 1) { sum += num - sortedNums[index]; }
        sortedNums[index] = num;
    }

    private int FindIndex(int num)
    {
        int low = 0, high = m;
        while (high - low != 1)
        {
            int mid = (low + high) / 2;
            if (sortedNums[mid] <= num) { low = mid; }
            else { high = mid; }
        }

        return low;
    }

    // Time complexity: O(1).
    public int CalculateMKAverage()
    {
        return queue.Count == m ? sum / (m - 2 * k) : -1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(4, 1, [0, 20, 40, 60, 10, 30, 50, 70], [-1, -1, -1, 30, 30, 35, 40, 40]);
    }

    private static void Run(int m, int k, int[] nums, int[] expectedResults)
    {
        var mkAverage = new MKAverage(m, k);

        for (int i = 0; i != nums.Length; i++)
        {
            mkAverage.AddElement(nums[i]);
            int result = mkAverage.CalculateMKAverage();
            Utilities.PrintSolution(nums[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
