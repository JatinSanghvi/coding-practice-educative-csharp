// All O`one Data Structure
// ========================
//
// Design a data structure that tracks the frequency of string keys and allows for efficient updates and queries.
//
// Implement the `AllOne` class with these methods:
//
// - Constructor: Initializes the data structure.
//
// - inc(String key): Increases the count of the given `key` by 1. If the key is absent, insert it with a count of 1.
//
// - dec(String key): Decreases the count of the given `key` by 1. If the count becomes 0 after decrementing, remove the
//   key entirely. The assumption is that the key exists when this function is called.
//
// - getMaxKey(): Returns *any one* key with the highest count. If the data structure is empty, return an empty string.
//
// - getMinKey(): Returns *any one* key with the lowest count. If the data structure is empty, return an empty string.
//
// > Note: All operations must be performed in average O(1) time complexity.
//
// Constraints:
//
// - 1 ≤ `key.length` ≤ 10
// - `key` consists only of lowercase English letters.
// - It is guaranteed that each call to `dec` is made with a key that exists in the data structure.
// - At most 5 × 10^2 calls will be made to inc, dec, getMaxKey, and getMinKey.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P14_AllOoneDataStructure;

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
