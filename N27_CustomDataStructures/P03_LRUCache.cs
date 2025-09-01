// LRU Cache
// =========
//
// Implement an LRU cache class with the following functions:
//
// - Init(capacity): Initializes an LRU cache with the capacity size.
//
// - Set(key, value): Adds a new key-value pair or updates an existing key with a new value.
//
// - Get(key): Returns the value of the key, or -1 if the key does not exist.
//
// If the number of keys has reached the cache capacity, evict the least recently used key and then add the new key.
//
// As caches use relatively expensive, faster memory, they are not designed to store very large data sets. Whenever the
// cache becomes full, we need to evict some data from it. There are several caching algorithms to implement a cache
// eviction policy. LRU is a very simple and commonly used algorithm. The core concept of the LRU algorithm is to evict
// the oldest data from the cache to accommodate more data.
//
// Constraints:
//
// - 1 ≤ capacity ≤ 3000
// - 0 ≤ key ≤ 10^4
// - 0 ≤ value ≤ 10^5
// - At most 10^3 calls will be made to Set and Get.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P03_LRUCache;

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
