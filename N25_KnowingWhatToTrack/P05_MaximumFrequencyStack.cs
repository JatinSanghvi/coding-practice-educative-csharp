// Maximum Frequency Stack
// =======================
//
// Design a stack-like data structure. You should be able to push elements to this data structure and pop elements with
// maximum frequency.
//
// You'll need to implement the FreqStack class that should consist of the following:
//
// - FreqStack: This is a class used to declare a frequency stack.
// - Push(value): This is used to push an integer data onto the top of the stack.
// - Pop(): This is used to remove and return the most frequent element in the stack.
//
// > Note: If there is a tie for the most frequent element, then the most recently pushed element is removed and
// > returned.
//
// Constraints:
//
// - 0 ≤ `value` ≤ 10^4
// - At most, 2 × 10^3 calls will be made to Push() and Pop().
// - It is guaranteed that there will be at least one element in the stack before calling Pop().

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P05_MaximumFrequencyStack;

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
