// LFU Cache
// =========
//
// Design and implement a data structure for a Least Frequently Used (LFU) cache.
//
// Implement the LFUCache class. Here is how it should be implemented:
//
// - LFUCache(capacity): This function initializes the object with the capacity of the data structure.
//
// - Get(key): This function gets the value of the key if it exists in the cache. Otherwise, it returns -1.
//
// - Put(key, value): This function updates the value of the key if present, or inserts the key if it's not present.
//   When the cache reaches its capacity, it should invalidate and remove the least frequently used key before inserting
//   a new item. For this problem, when there's a tie, that is, two or more keys have the same frequency, the least
//   recently used key is invalidated.
//
// To determine the least frequently used key, a UseCounter is maintained for each key in the cache. The key with the
// smallest UseCounter is the least frequently used key. When a key is first inserted into the cache, its UseCounter is
// set to 1 (due to the Put() operation). The UseCounter for a key in the cache is incremented and either a Get() or
// Put() operation is called on it.
//
// The Get and Put functions should both run with an average time complexity of O(1).
//
// Constraints:
//
// - 0 ≤ capacity ≤ 10^4
// - 0 ≤ key ≤ 10^5
// - 0 ≤ value ≤ 10^5
// - At most 2 × 10^3 calls will be made to Get() and Put().

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P16_LFUCache;

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
