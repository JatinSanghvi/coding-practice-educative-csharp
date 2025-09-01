// Implement Queue Using Stacks
// ============================
//
// Design a custom queue, MyQueue, using only two stacks. Implement the Push(), Pop(), Peek(), and Empty() methods:
//
// - Void Push(int x): Pushes element at the end of the queue.
// - Int Pop(): Removes and returns the element from the front of the queue.
// - Int Peek(): Returns the element at the front of the queue.
// - Boolean Empty(): Returns TRUE if the queue is empty. Otherwise FALSE.
//
// You are required to only use the standard stack operations, which means that only the Push() to top, Peek() and Pop()
// from the top, Size(), and Is Empty() operations are valid.
//
// > Note: In some interview questions, Void Push(int x) and Int Pop() might be referred to as Void Enqueue(int x) and
// > Int Dequeue(), respectively.
//
// Constraints:
//
// - 1 ≤ `x` ≤ 100
// - A maximum of 100 calls can be made to Push(), Pop(), Peek(), and Empty().
// - The Pop() and Peek() methods will always be called on non-empty stacks.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P06_ImplementQueueUsingStacks;

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
