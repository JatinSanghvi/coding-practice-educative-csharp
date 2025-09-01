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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N16_TopologicalSort.P04_CourseScheduleII;

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
