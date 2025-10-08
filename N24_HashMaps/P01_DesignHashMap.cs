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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P01_DesignHashMap;

// Space complexity: O(k+n).
public class MyHashMap()
{
    private const int keyBase = 2069;
    private readonly LinkedList<(int, int)>[] buckets = new LinkedList<(int, int)>[keyBase];

    // Average-case time complexity: O(n/k), Worst-case time complexity: O(n).
    public void Put(int key, int value)
    {
        buckets[key % keyBase] ??= new LinkedList<(int, int)>();

        LinkedListNode<(int, int)> node;
        for (node = buckets[key % keyBase].First; node != null; node = node.Next)
        {
            if (node.Value.Item1 == key)
            {
                node.Value = (key, value);
                break;
            }
        }

        if (node == null)
        {
            buckets[key % keyBase].AddLast((key, value));
        }
    }

    // Average-case time complexity: O(n/k), Worst-case time complexity: O(n).
    public int Get(int key)
    {
        if (buckets[key % keyBase] == null) { return -1; }

        LinkedListNode<(int, int)> node;
        for (node = buckets[key % keyBase].First; node != null; node = node.Next)
        {
            if (node.Value.Item1 == key)
            {
                return node.Value.Item2;
            }
        }

        return -1;
    }

    // Average-case time complexity: O(n/k), Worst-case time complexity: O(n).
    public void Remove(int key)
    {
        if (buckets[key % keyBase] == null) { return; }

        LinkedListNode<(int, int)> node;
        for (node = buckets[key % keyBase].First; node != null; node = node.Next)
        {
            if (node.Value.Item1 == key)
            {
                buckets[key % keyBase].Remove(node);
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            ["Get 1", "Put 1 10", "Get 1", "Remove 1", "Get 1"],
            [-1, null, 10, null, -1]
        );
    }

    private static void Run(string[] operations, int?[] expectedResult)
    {
        var hashMap = new MyHashMap();

        for (int i = 0; i != operations.Length; i++)
        {
            string[] tokens = operations[i].Split();
            int? result = null;
            switch (tokens[0])
            {
                case "Put": hashMap.Put(int.Parse(tokens[1]), int.Parse(tokens[2])); break;
                case "Get": result = hashMap.Get(int.Parse(tokens[1])); break;
                case "Remove": hashMap.Remove(int.Parse(tokens[1])); break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResult[i], result);
        }
    }
}
