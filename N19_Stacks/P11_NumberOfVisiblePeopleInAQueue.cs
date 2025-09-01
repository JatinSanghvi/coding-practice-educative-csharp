// Number of Visible People in a Queue
// ===================================
//
// You are given an array `heights` representing `n` people standing in a queue, numbered from `0` to `n - 1` from left
// to right. Each element `heights[i]` denotes the height of the person at position `i`. All heights are distinct.
//
// A person at position `i` can see a person at position `j` (`i < j`) to their right if every person between them is
// shorter than both `heights[i]` and `heights[j]`.
//
// Formally, person `i` can see person `j` if:
//
// - i < j and min(heights[i], heights[j]) > max(heights[i+1], heights[i+2], ..., heights[j-1])
//
// Your task is to return an array `answer` of length `n`, where `answer[i]` is the number of people that person `i` can
// see to their right in the queue.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 1000
// - 1 ≤ `heights[i]` ≤ 1000
// - All elements in `heights` are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P11_NumberOfVisiblePeopleInAQueue;

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
