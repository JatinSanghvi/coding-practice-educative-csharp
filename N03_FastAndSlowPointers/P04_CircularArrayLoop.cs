// Circular Array Loop
// ===================
// 
// There is a circular list of non-zero integers called `nums`. Each number in the list tells you how many steps to move
// forward or backward from your current position:
// - If `nums[i]` is positive, move `nums[i]` steps forward.
// - If `nums[i]` is negative, move `nums[i]` steps backward.
// 
// As the list is circular:
// - Moving forward from the last element takes you back to the first element.
// - Moving backward from the first element takes you to the last element.
// 
// A cycle in this list means:
// 
// 1. You keep moving according to the numbers, and you end up repeating a sequence of indexes.
// 2. All numbers in the cycle have the same sign (either all positive or all negative).
// 3. The cycle length is greater than 1 (it involves at least two indexes).
// 
// Return `true` if such a cycle exists in the list or `false` otherwise.
// 
// Constraints:
// - 1 ≤ `nums.length` ≤ 10^4
// - -5000 ≤ `nums[i]` ≤ 5000
// - `nums[i]` != 0

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N03_FastAndSlowPointers.P04_CircularArrayLoop;

public class Solution
{
    public static bool CircularArrayLoop(int[] nums)
    {
        int length = nums.Length;
        bool[] visited = new bool[nums.Length];

        for (int index = 0; index < length; index++)
        {
            if (visited[index]) { continue; }

            int slow = index, fast = index;

            while (true)
            {
                int nextFast = GetNextIndex(fast);
                if (nextFast == fast || (nums[nextFast] > 0) != (nums[fast] > 0)) { break; }
                fast = nextFast;
                visited[fast] = true;

                nextFast = GetNextIndex(fast);
                if (nextFast == fast || (nums[nextFast] > 0) != (nums[fast] > 0)) { break; }
                fast = nextFast;
                visited[fast] = true;

                slow = GetNextIndex(slow);
                if (slow == fast) { return true; }
            }
        }

        return false;

        int GetNextIndex(int index)
        {
            int next = (index + nums[index]) % length;
            return next >= 0 ? next : next + length;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new[] { 5, 4, 3, 2, 1 }, false);
        Run(new[] { 1, 1, 1, -1, -1 }, false);
        Run(new[] { -15, -14, -13, -12, -11 }, true);
    }

    private static void Run(int[] nums, bool expectedResult)
    {
        bool result = Solution.CircularArrayLoop(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
