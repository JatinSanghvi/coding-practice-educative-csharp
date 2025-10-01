// Number of Steps to Reduce a Binary Number to One
// ================================================
//
// You are given a string, `str`, as a binary representation of an integer. Your task is to return the number of steps
// needed to reduce it to 1 by following these rules:
//
// - If the number is even, divide it by 2.
// - If the number is odd, add 1 to it.
//
// You can always reach 1 for all provided test cases.
//
// Constraints:
//
// - 1 <= `str.length` <= 500
// - `str` consists of characters '0' or '1'.
// - `str[0]` == '1'

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P09_NumberOfStepsToReduceABinaryNumberToOne;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int numSteps(string str)
    {
        int steps = 0;
        int carry = 0;
        for (int i = str.Length - 1; i != 0; i--)
        {
            int bit = str[i] == '0' ? 0 : 1;
            int sum = (bit + carry) % 2;

            if (sum == 0)
            {
                carry = (bit + carry) / 2;
                steps++;
            }
            else
            {
                carry = 1;
                steps += 2;
            }
        }

        // Remaining number is "1" on no carry, and "10" on carry. Add an extra step accordingly.
        return steps + carry;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("101100111", 13);
    }

    private static void Run(string str, int expectedResult)
    {
        int result = Solution.numSteps(str);
        Utilities.PrintSolution(str, result);
        Assert.AreEqual(expectedResult, result);
    }
}
