// Flatten Nested List Iterator
// ============================
//
// You're given a nested list of integers. Each element is either an integer or a list whose elements may also be
// integers or other integer lists. Your task is to implement an iterator to flatten the nested list.
//
// You will have to implement the Nested Iterator class. This class has the following functions:
//
// - Constructor: This initializes the iterator with the nested list.
// - Next (): This returns the next integer in the nested list.
// - Has Next (): This returns TRUE if there are still some integers in the nested list. Otherwise, it returns FALSE.
//
// Constraints
//
// - The nested list length is between 1 and 200.
// - The nested list consists of integers between [1, 10^4].

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P05_FlattenNestedListIterator;

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
