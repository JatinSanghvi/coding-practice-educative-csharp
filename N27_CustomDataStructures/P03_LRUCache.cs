// LRU Cache
// =========
//
// Implement an LRU cache class with the following functions:
//
// - Init(capacity): Initializes an LRU cache with the capacity size.
// - Set(key, value): Adds a new key-value pair or updates an existing key with a new value.
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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P03_LRUCache;

// Space complexity: O(capacity).
public class Solution(int capacity)
{
    private int size = 0;
    private readonly LinkedList<(int, int)> list = new();
    private readonly Dictionary<int, LinkedListNode<(int, int)>> nodes = new();

    // Time complexity: O(1).
    public void Set(int key, int value)
    {
        if (nodes.ContainsKey(key))
        {
            LinkedListNode<(int, int)> node = nodes[key];
            node.Value = (key, value);
            list.Remove(node);
            list.AddFirst(node);
            return;
        }

        if (size == capacity)
        {
            LinkedListNode<(int, int)> node = list.Last;
            list.RemoveLast();
            nodes.Remove(node.Value.Item1);
            size--;
        }

        list.AddFirst((key, value));
        nodes[key] = list.First;
        size++;
    }

    // Time complexity: O(1).
    public int Get(int key)
    {
        if (!nodes.ContainsKey(key)) { return -1; }

        LinkedListNode<(int, int)> node = nodes[key];
        list.Remove(node);
        list.AddFirst(node);
        return node.Value.Item2;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            2,
            ["Set 1 10", "Set 2 20", "Get 1", "Set 3 30", "Set 3 31", "Get 1", "Get 2", "Get 3"],
            [null, null, 10, null, null, 10, -1, 31]);
    }

    private static void Run(int capacity, string[] operations, int?[] expectedResults)
    {
        var lruCache = new Solution(capacity);
        for (int i = 0; i != operations.Length; i++)
        {
            int? result = null;
            string[] operands = operations[i].Split();
            switch (operands[0])
            {
                case "Set":
                    lruCache.Set(int.Parse(operands[1]), int.Parse(operands[2]));
                    break;
                case "Get":
                    result = lruCache.Get(int.Parse(operands[1]));
                    break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
