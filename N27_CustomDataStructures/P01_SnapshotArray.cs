// Snapshot Array
// ==============
//
// In this challenge, you have to implement a Snapshot Array with the following properties:
//
// - Constructor (length): This is the constructor and it initializes the data structure to hold the specified number of
//   indexes.
//
// - Set Value (idx, val): This property sets the value at a given index idx to value val.
//
// - Snapshot(): This method takes no parameters and returns the Snap ID. Snap ID is the number of times that the
//   snapshot function was called, less 1, as we start the count at 0. The first time this function is called, it saves
//   a snapshot and returns 0. The nth time it is called, after saving the snapshot, it returns n-1.
//
// - Get Value (idx, Snap ID) method returns the value at the index in the snapshot with the given Snap ID.
//
// Suppose that we have three nodes whose values we wish to track in the snapshot array. Initially, the value of all the
// nodes will be 0. After calling the Set Value (1, 4) function, the value of node 1 will change to 4. If we take a
// snapshot at this point, the current values of all the nodes will be saved with Snap ID 0. Now, if we call Set Value
// (1, 7), the current value for node 1 will change to 7. Now, if we call the Get Value (1, 0) function, we will get the
// value of node 1 from snapshot 0, that is, 4.
//
// Constraints:
//
// - 1 ≤ `length` ≤ 1000
// - 0 ≤ `idx` < `length`
// - 0 ≤ `val` ≤ 10^9
// - 0 ≤ `snapid` < (the total number of times we call Snapshot)
// - At most 5 × 10^3 calls will be made to Set Value, Snapshot, and Get Value.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P01_SnapshotArray;

// Space complexity: O(l*s) where l = length, s = snapshots.
public class Solution(int length)
{
    private readonly int[] array = new int[length];
    private readonly List<int[]> snapshots = new();

    // Time complexity: O(1).
    public void SetValue(int idx, int state)
    {
        array[idx] = state;
    }

    // Time complexity: O(n).
    public int Snapshot()
    {
        var snapshot = new int[length];
        Array.Copy(array, snapshot, length);
        snapshots.Add(snapshot);
        return snapshots.Count - 1;
    }

    // Time complexity: O(1).
    public int GetValue(int idx, int snapshotId)
    {
        return snapshots[snapshotId][idx];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(2, ["Set 1 1", "Snapshot", "Set 1 2", "Snapshot", "Get 1 0", "Get 1 1"], [null, 0, null, 1, 1, 2]);
    }

    private static void Run(int length, string[] operations, int?[] expectedResults)
    {
        var snapshotArray = new Solution(length);
        for (int i = 0; i != operations.Length; i++)
        {
            int? result = null;
            string[] operands = operations[i].Split();
            switch (operands[0])
            {
                case "Set":
                    snapshotArray.SetValue(int.Parse(operands[1]), int.Parse(operands[2]));
                    break;
                case "Snapshot":
                    result = snapshotArray.Snapshot();
                    break;
                case "Get":
                    result = snapshotArray.GetValue(int.Parse(operands[1]), int.Parse(operands[2]));
                    break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
