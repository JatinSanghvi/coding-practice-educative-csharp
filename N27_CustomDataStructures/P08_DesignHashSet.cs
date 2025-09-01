// Design HashSet
// ==============
//
// Design a MyHashSet class without using any built-in hash table libraries and implement the following methods in it:
//
// - `void add(key)`: Inserts the value `key` into the HashSet.
//
// - `bool contains(key)`: Returns TRUE if the `key` exists in the HashSet, FALSE otherwise.
//
// - `void remove(key)`: Removes the value `key` if it exists in the HashSet.
//
// Constraints:
//
// - 0 ≤ `key` ≤ 10^6
// - At most, 10^4 calls will be made to `add`, `contains`, and `remove` methods.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P08_DesignHashSet;

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
