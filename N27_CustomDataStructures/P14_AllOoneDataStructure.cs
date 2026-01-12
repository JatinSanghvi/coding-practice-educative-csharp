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

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P14_AllOOneDataStructure;

// Space complexity: O(n).
public class AllOne
{
    private readonly Dictionary<string, int> counts = new();
    private readonly LinkedList<HashSet<string>> setList = new();
    private readonly Dictionary<int, LinkedListNode<HashSet<string>>> countNodes = new();

    public AllOne()
    {
        var zeroSet = new HashSet<string>([""]);
        setList.AddFirst(zeroSet);
        countNodes[0] = setList.First;
    }

    // Time complexity: O(1).
    public void Inc(string key)
    {
        if (!counts.ContainsKey(key)) { counts[key] = 0; }

        int count = counts[key];
        counts[key] = count + 1;

        if (!countNodes.ContainsKey(count + 1))
        {
            setList.AddAfter(countNodes[count], new HashSet<string>());
            countNodes[count + 1] = countNodes[count].Next;
        }

        countNodes[count + 1].Value.Add(key);
        if (count != 0) { countNodes[count].Value.Remove(key); }

        if (countNodes[count].Value.Count == 0)
        {
            setList.Remove(countNodes[count]);
            countNodes.Remove(count);
        }
    }

    // Time complexity: O(1).
    public void Dec(string key)
    {
        int count = counts[key];
        counts[key] = count - 1;
        if (counts[key] == 0) { counts.Remove(key); }

        if (!countNodes.ContainsKey(count - 1))
        {
            setList.AddBefore(countNodes[count], new HashSet<string>());
            countNodes[count - 1] = countNodes[count].Previous;
        }

        if (count - 1 != 0) { countNodes[count - 1].Value.Add(key); }
        countNodes[count].Value.Remove(key);

        if (countNodes[count].Value.Count == 0)
        {
            setList.Remove(countNodes[count]);
            countNodes.Remove(count);
        }
    }

    // Time complexity: O(1).
    public string GetMaxKey()
    {
        return setList.Last.Value.First();
    }

    // Time complexity: O(1).
    public string GetMinKey()
    {
        return (setList.First.Next ?? setList.First).Value.First();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([
                "Inc a", "GetMaxKey", "GetMinKey", "Inc b", "GetMaxKey", "GetMinKey",
                "Inc a", "GetMaxKey", "GetMinKey", "Inc a", "GetMaxKey", "GetMinKey",
                "Dec a", "GetMaxKey", "GetMinKey", "Dec b", "GetMaxKey", "GetMinKey",
                "Dec a", "GetMaxKey", "GetMinKey", "Dec a", "GetMaxKey", "GetMinKey",
                ],
                [
                    null, "a", "a", null, "a", "a",
                    null, "a", "b", null, "a", "b",
                    null, "a", "b", null, "a", "a",
                    null, "a", "a", null, "", "",
                ]);
    }

    private static void Run(string[] operations, string[] expectedResults)
    {
        var allOne = new AllOne();

        for (int i = 0; i != operations.Length; i++)
        {
            string result = null;
            string[] operands = operations[i].Split();

            switch (operands[0])
            {
                case "Inc":
                    allOne.Inc(operands[1]);
                    break;
                case "Dec":
                    allOne.Dec(operands[1]);
                    break;
                case "GetMaxKey":
                    result = allOne.GetMaxKey();
                    break;
                case "GetMinKey":
                    result = allOne.GetMinKey();
                    break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
