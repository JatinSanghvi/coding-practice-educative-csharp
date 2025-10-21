// Maximum Frequency Stack
// =======================
//
// Design a stack-like data structure. You should be able to push elements to this data structure and pop elements with
// maximum frequency.
//
// You'll need to implement the FreqStack class that should consist of the following:
//
// - FreqStack: This is a class used to declare a frequency stack.
// - Push(value): This is used to push an integer data onto the top of the stack.
// - Pop(): This is used to remove and return the most frequent element in the stack.
//
// > Note: If there is a tie for the most frequent element, then the most recently pushed element is removed and
// > returned.
//
// Constraints:
//
// - 0 ≤ `value` ≤ 10^4
// - At most, 2 × 10^3 calls will be made to Push() and Pop().
// - It is guaranteed that there will be at least one element in the stack before calling Pop().

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P05_MaximumFrequencyStack;

// Space complexity: O(n), where n = number of operations.
public class FreqStack
{
    private readonly List<Stack<int>> frequencyStacks = new();
    private readonly Dictionary<int, int> frequencies = new();
    private int maxFrequency = 0;

    // Time complexity: O(1).
    public void Push(int value)
    {
        frequencies.TryAdd(value, 0);
        frequencies[value]++;

        if (maxFrequency < frequencies[value])
        {
            maxFrequency++;
        }

        if (frequencyStacks.Count < maxFrequency)
        {
            frequencyStacks.Add(new Stack<int>());
        }

        frequencyStacks[frequencies[value] - 1].Push(value);
    }

    // Time complexity: O(1).
    public int Pop()
    {
        int value = frequencyStacks[maxFrequency - 1].Pop();
        frequencies[value]--;

        if (frequencyStacks[maxFrequency - 1].Count == 0)
        {
            maxFrequency--;
        }

        return value;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["Push 1", "Push 1", "Push 2", "Pop", "Pop", "Pop"], [null, null, null, 1, 2, 1]);
    }

    private static void Run(string[] operations, int?[] expectedResult)
    {
        var stack = new FreqStack();

        for (int i = 0; i != operations.Length; i++)
        {
            string[] tokens = operations[i].Split(' ');
            int? result = null;

            if (tokens[0] == "Push") { stack.Push(int.Parse(tokens[1])); }
            else if (tokens[0] == "Pop") { result = stack.Pop(); }
            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResult[i], result);
        }
    }
}
