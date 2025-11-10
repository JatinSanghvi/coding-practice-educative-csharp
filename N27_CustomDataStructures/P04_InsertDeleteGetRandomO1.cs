// Insert Delete GetRandom O(1)
// ============================
//
// Implement a Random Set data structure that can perform the following operations:
//
// - Constructor(): This initializes the Random Set object.
//
// - Insert(): This function takes an integer, data, as its parameter and, if it does not already exist in the set, add
//   it to the set, returning TRUE. If the integer already exists in the set, the function returns FALSE.
//
// - Delete(): This function takes an integer, data, as its parameter and, if it exists in the set, removes it,
//   returning TRUE. If the integer does not exist in the set, the function returns FALSE.
//
// - GetRandom(): This function takes no parameters. It returns an integer chosen at random from the set.
//
// > Note: Your implementation should aim to have a running time of O(1) (on average) for each operation.
//
// Constraints:
//
// - -2^31 ≤ data ≤ 2^31
// - No more than 2 × 10^5 calls will be made to the Insert(), Delete() and GetRandom() functions.
// - There will be at least one element in the data structure when the GetRandom() function is called.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P04_InsertDeleteGetRandomO1;

// Space complexity: O(n).
public class RandomSet
{
    private readonly List<int> list = new();
    private readonly Dictionary<int, int> indexes = new();
    private readonly Random random = new();

    // Time complexity: O(1).
    public bool Insert(int value)
    {
        if (indexes.ContainsKey(value)) { return false; }

        list.Add(value);
        indexes[value] = list.Count - 1;
        return true;
    }

    // Time complexity: O(1).
    public bool Delete(int value)
    {
        if (!indexes.ContainsKey(value)) { return false; }

        int index = indexes[value];
        list[index] = list[^1];
        indexes[list[index]] = index;
        list.RemoveAt(list.Count - 1);
        indexes.Remove(value);
        return true;
    }

    // Time complexity: O(1).
    public int GetRandomData()
    {
        return list[random.Next(list.Count)];
    }
}

internal static class Tests
{
    public static void Run()
    {
        // Not a comprehensive test.
        Run(["Insert 1", "GetRandom", "Insert 2", "Insert 1", "Delete 1", "Delete 1", "GetRandom"],
            [true, 1, true, false, true, false, 2]);
    }

    private static void Run(string[] operations, object[] expectedResults)
    {
        var randomSet = new RandomSet();
        for (int i = 0; i != operations.Length; i++)
        {
            object result = null;
            string[] operands = operations[i].Split();
            switch (operands[0])
            {
                case "Insert":
                    result = randomSet.Insert(int.Parse(operands[1]));
                    break;
                case "Delete":
                    result = randomSet.Delete(int.Parse(operands[1]));
                    break;
                case "GetRandom":
                    result = randomSet.GetRandomData();
                    break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
