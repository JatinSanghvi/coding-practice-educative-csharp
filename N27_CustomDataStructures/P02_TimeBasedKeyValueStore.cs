// Time Based Key-Value Store
// ==========================
//
// Implement a data structure that can store multiple values of the same key at different timestamps and retrieve the
// key's value at a certain timestamp.
//
// You'll need to implement the TimeStamp class. This class has the following functions:
//
// - Init(): This function initializes the values dictionary and timestamp dictionary.
//
// - Set Value(key, value, timestamp): This function stores the key and value at any given timestamp.
//
// - Get Value(key, timestamp): This function returns the value set for this key at the specified timestamp.
//
// > Note: When a query requests the value of a key at a timestamp that isn't recorded, return the value corresponding
// > to the most recent timestamp before the query's timestamp. If there are no timestamps before the query's timestamp,
// > return an empty string.
//
// Constraints:
//
// - 1 ≤ `key.length`, `value.length` ≤ 20
// - `key` and `value` consist of lowercase English letters and digits.
// - 1 ≤ `timestamp` ≤ 10^3
// - At most 1 × 10^3 calls will be made to Set Value and Get Value.
// - All the timestamps, `timestamp`, of Set Value are strictly increasing.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P02_TimeBasedKeyValueStore;

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
