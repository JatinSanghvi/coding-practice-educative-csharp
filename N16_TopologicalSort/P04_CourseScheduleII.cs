// Course Schedule II
// ==================
//
// You are given `n` courses, labeled from `0` to `n - 1`. Some courses have prerequisites, which are provided as a list
// of pairs: `prerequisites[i] = [a, b]`. To take course `a`, you must first complete course `b`.
//
// Your task is to determine a valid order in which you can complete all the courses and return it as an array of course
// labels.
//
// - If there are multiple valid orderings, you can return any of them.
// - If it's impossible to finish all courses (due to a cycle in prerequisites), return an empty array.
//
// > Note: There can be a course in the `0` to `n - 1` range with no prerequisites.
//
// Constraints:
//
// - 1 ≤ n ≤ 1500
// - 0 ≤ `prerequisites.length` ≤ 1000
// - `prerequisites[i].length` == 2
// - 0 ≤ a, b < n
// - a ≠ b
// - All the pairs [a, b] are distinct.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N16_TopologicalSort.P04_CourseScheduleII;

public class Solution
{
    // Time complexity: O(v+e), Space complexity: O(v+e).
    public static int[] FindOrder(int n, int[][] prerequisites)
    {
        var graph = new List<int>[n];
        var inDegrees = new int[n];

        for (int i = 0; i != n; i++)
        {
            graph[i] = new List<int>();
        }

        foreach (int[] prereq in prerequisites)
        {
            int course1 = prereq[0], course2 = prereq[1];
            graph[course1].Add(course2);
            inDegrees[course2]++;
        }

        var queue = new Queue<int>();
        for (int i = 0; i != n; i++)
        {
            if (inDegrees[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        var order = new List<int>();
        while (queue.Count != 0)
        {
            var course1 = queue.Dequeue();
            order.Add(course1);

            foreach (int course2 in graph[course1])
            {
                inDegrees[course2]--;
                if (inDegrees[course2] == 0)
                {
                    queue.Enqueue(course2);
                }
            }
        }

        foreach (int inDegree in inDegrees)
        {
            if (inDegree != 0) { return new int[0]; }
        }

        return order.ToArray();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(4, [[0, 1], [1, 2], [2, 3], [3, 0]], []);
        Run(4, [[0, 1], [0, 2], [1, 2], [2, 3]], [0, 1, 2, 3]);
        Run(4, [[0, 1], [0, 2], [0, 3], [1, 2]], [0, 1, 3, 2]);
    }

    private static void Run(int n, int[][] prerequisites, int[] expectedResult)
    {
        int[] result = Solution.FindOrder(n, prerequisites);
        Utilities.PrintSolution((n, prerequisites), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
