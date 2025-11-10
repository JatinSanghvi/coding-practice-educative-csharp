// Time Based Key-Value Store
// ==========================
//
// Implement a data structure that can store multiple values of the same key at different timestamps and retrieve the
// key's value at a certain timestamp.
//
// You'll need to implement the TimeStamp class. This class has the following functions:
//
// - Init(): This function initializes the values dictionary and timestamp dictionary.
// - Set Value(key, value, timestamp): This function stores the key and value at any given timestamp.
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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P02_TimeBasedKeyValueStore;

// Space complexity: O(s) where s = number of set operations.
public class TimeStamp
{
    private readonly Dictionary<string, List<(int, string)>> store = new();

    public void Init() { }

    // Time complexity: O(1).
    public void SetValue(string key, string value, int timestamp)
    {
        store.TryAdd(key, new List<(int, string)>());

        store[key].Add((timestamp, value));
    }

    // Time complexity: O(log s). where s = number of set operations on that key.
    public string GetValue(string key, int timestamp)
    {
        store.TryAdd(key, new List<(int, string)>());

        List<(int, string)> list = store[key];
        int low = -1, high = list.Count;
        while (high - low != 1)
        {
            int mid = (low + high) / 2;
            if (list[mid].Item1 <= timestamp) { low = mid; }
            else { high = mid; }
        }

        return low == -1 ? string.Empty : list[low].Item2;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["Set aa a1 1", "Set aa a3 3", "Set bb b5 5", "Get aa 0", "Get aa 1", "Get aa 2", "Get aa 3"], [null, null, null, "", "a1", "a1", "a3"]);
    }

    private static void Run(string[] operations, string[] expectedResults)
    {
        var timestamp = new TimeStamp();
        for (int i = 0; i != operations.Length; i++)
        {
            string result = null;
            string[] operands = operations[i].Split();
            switch (operands[0])
            {
                case "Set":
                    timestamp.SetValue(operands[1], operands[2], int.Parse(operands[3]));
                    break;
                case "Get":
                    result = timestamp.GetValue(operands[1], int.Parse(operands[2]));
                    break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
