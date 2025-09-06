// Happy Number
// ============
//
// We use the following process to check if a given number is a happy number:
//
// - Starting with the given number n, replace the number with the sum of the squares of its digits.
// - Repeat the process until:
//     - The number equals 1, which will depict that the given number n is a happy number.
//     - The number enters a cycle, which will depict that the given number n is not a happy number.
//
// Return TRUE if n is a happy number, and FALSE if not.
//
// Constraints:
//
// - 1 ≤ n ≤ 2^31-1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N03_FastAndSlowPointers.P01_HappyNumber;

public class Solution
{
    // Time complexity: O(logn), Space complexity: O(1).
    public static bool IsHappyNumber(int n)
    {
        int slow = n, fast = n;

        do
        {
            slow = Translate(slow);
            fast = Translate(Translate(fast));
        }
        while (fast != 1 && fast != slow);

        return fast == 1;
    }

    private static int Translate(int num)
    {
        int result = 0;
        for (; num != 0; num /= 10)
        {
            int digit = num % 10;
            result += digit * digit;
        }

        return result;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, true);
        Run(2, false);
        Run(999999995, true);
        Run(int.MaxValue, false);

    }

    private static void Run(int n, bool expectedResult)
    {
        bool result = Solution.IsHappyNumber(n);
        Utilities.PrintSolution(n, result);
        Assert.AreEqual(expectedResult, result);
    }
}
