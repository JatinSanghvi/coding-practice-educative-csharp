// Design HashSet
// ==============
//
// Design a MyHashSet class without using any built-in hash table libraries and implement the following methods in it:
//
// - `void add(key)`: Inserts the value `key` into the HashSet.
// - `bool contains(key)`: Returns TRUE if the `key` exists in the HashSet, FALSE otherwise.
// - `void remove(key)`: Removes the value `key` if it exists in the HashSet.
//
// Constraints:
//
// - 0 ≤ `key` ≤ 10^6
// - At most, 10^4 calls will be made to `add`, `contains`, and `remove` methods.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P08_DesignHashSet;

// Space complexity: O(n + set-size).
public class MyHashSet
{
    private const int SetSize = 1000;
    private readonly LinkedList<int>[] set = new LinkedList<int>[SetSize];

    // Time complexity: O(n).
    public void Add(int key)
    {
        int hash = key % SetSize;
        set[hash] ??= new LinkedList<int>();
        LinkedList<int> list = set[hash];

        LinkedListNode<int> node = list.First;
        for (; node?.Value < key; node = node.Next) ;

        if (node == null) { list.AddLast(key); }
        else if (node.Value > key) { list.AddBefore(node, key); }
    }

    // Time complexity: O(n).
    public void Remove(int key)
    {
        int hash = key % SetSize;
        if (set[hash] == null) { return; }
        LinkedList<int> list = set[hash];

        LinkedListNode<int> node = list.First;
        for (; node?.Value < key; node = node.Next) ;

        if (node?.Value == key) { list.Remove(node); }
    }

    // Time complexity: O(n).
    public bool Contains(int key)
    {
        int hash = key % SetSize;
        if (set[hash] == null) { return false; }
        LinkedList<int> list = set[hash];

        LinkedListNode<int> node = list.First;
        for (; node?.Value < key; node = node.Next) ;

        return node?.Value == key;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["Add 1", "Add 2", "Add 1", "Contains 1", "Remove 1", "Contains 1", "Remove 1"], [null, null, null, true, null, false, null]);
        Run(["Add 2000", "Add 1000", "Add 0", "Contains 1000", "Remove 1000", "Contains 1000"], [null, null, null, true, null, false]);
    }

    private static void Run(string[] operations, bool?[] expectedResults)
    {
        var hashSet = new MyHashSet();

        for (int i = 0; i != operations.Length; i++)
        {
            bool? result = null;
            string[] operands = operations[i].Split();

            switch (operands[0])
            {
                case "Add":
                    hashSet.Add(int.Parse(operands[1]));
                    break;
                case "Remove":
                    hashSet.Remove(int.Parse(operands[1]));
                    break;
                case "Contains":
                    result = hashSet.Contains(int.Parse(operands[1]));
                    break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
