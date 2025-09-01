// Design HashMap
// ==============
//
// Design a HashMap data structure that supports the following operations:
//
// - Constructor(): Initializes the hash map object with an empty map to store the key-value pairs.
// - Put(key, value): Inserts a key-value pair into the hash map. If the specified key is already present in the hash
//   map, the associated value is updated. Otherwise, the key-value pair is added to the hash map.
// - Get(key): Returns the value associated with the specified key if the key exists in the hash map. Otherwise, it
//   returns -1, indicating the absence of a mapping for the key.
// - Remove(key): Removes the entry for the specified key from the hash map, effectively removing both the key and its
//   associated value. This elimination only takes place when the key exists in the hash map.
//
// > Note: Your implementation should not utilize the built-in hash table libraries.
//
// Constraints:
//
// - 0 ≤ `key` ≤ 10^6
// - 0 ≤ `value` ≤ 10^6
// - At most, 10^4 calls can be made to the Put, Get, and Remove functions.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P01_DesignHashMap;

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
