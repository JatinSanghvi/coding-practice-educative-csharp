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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P16_LFUCache;

// Space complexity: O(capacity).
public class LFUCache(int capacity)
{
    private class Info
    {
        public int value;
        public int count;
        public LinkedListNode<int> node;
    }

    private readonly Dictionary<int, Info> infos = new();
    private readonly LinkedList<LinkedList<int>> frequencyList = new();
    private readonly Dictionary<int, LinkedListNode<LinkedList<int>>> frequencyNodes = new();
    private int size = 0;

    // Time complexity: O(1).
    public int Get(int key)
    {
        if (infos.TryGetValue(key, out Info info))
        {
            IncrementKeyCount(key);
            return info.value;
        }

        return -1;
    }

    // Time complexity: O(1).
    public void Put(int key, int value)
    {
        if (infos.ContainsKey(key))
        {
            IncrementKeyCount(key);
            infos[key].value = value;
        }
        else
        {
            if (size == capacity)
            {
                RemoveKey(frequencyList.First.Value.Last.Value);
            }

            AddKey(key, value);
        }
    }

    private void AddKey(int key, int value)
    {
        if (!frequencyNodes.ContainsKey(1))
        {
            frequencyNodes[1] = frequencyList.AddFirst(new LinkedList<int>());
        }

        infos[key] = new Info { value = value, count = 1, node = frequencyNodes[1].Value.AddFirst(key) };
        size++;
    }

    private void RemoveKey(int key)
    {
        int count = infos[key].count;
        frequencyNodes[count].Value.Remove(infos[key].node);

        if (frequencyNodes[count].Value.Count == 0)
        {
            frequencyList.Remove(frequencyNodes[count]);
            frequencyNodes.Remove(count);
        }

        infos.Remove(key);
        size--;
    }

    private void IncrementKeyCount(int key)
    {
        int count = infos[key].count;

        if (!frequencyNodes.ContainsKey(count + 1))
        {
            frequencyNodes[count + 1] = frequencyList.AddAfter(frequencyNodes[count], new LinkedList<int>());
        }

        frequencyNodes[count].Value.Remove(infos[key].node);

        infos[key].count = count + 1;
        infos[key].node = frequencyNodes[count + 1].Value.AddFirst(key);

        if (frequencyNodes[count].Value.Count == 0)
        {
            frequencyList.Remove(frequencyNodes[count]);
            frequencyNodes.Remove(count);
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            2,
             [
                "Put 1 11", "Get 1", "Put 1 12", "Get 1", "Get 2", // Test Get functionality.
                "Put 2 21", "Get 2", "Put 2 22", "Put 3 31", "Get 2",  // LFU 2 should be evicted
                "Put 3 32", "Put 3 33", "Put 3 34", "Put 4 41", "Get 1", // LRU 1 should be evicted
                "Get 3", "Get 4"
            ],
            [
                null, 11, null, 12, -1,
                null, 21, null, null, -1,
                null, null, null, null, -1,
                34, 41
            ]);
    }

    private static void Run(int capacity, string[] operations, int?[] expectedResults)
    {
        var lfuCache = new LFUCache(capacity);

        for (int i = 0; i != operations.Length; i++)
        {
            int? result = null;
            string[] operands = operations[i].Split();

            switch (operands[0])
            {
                case "Put":
                    lfuCache.Put(int.Parse(operands[1]), int.Parse(operands[2]));
                    break;
                case "Get":
                    result = lfuCache.Get(int.Parse(operands[1]));
                    break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
