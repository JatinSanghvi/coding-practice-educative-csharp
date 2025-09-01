// Course Schedule
// ===============
//
// You are given an integer, `numCourses`, representing the total number of courses you need to complete, labeled from
// `0` to `numCourses - 1`.
//
// You are also given a `prerequisites` array, where `prerequisites[i] = [a[i], b[i]]` indicates that you must take
// course `b[i]` first if you want to take the course `a[i]`. For example, the pair `[1, 0]` indicates that to take
// course 1, you have to first take course 0.
//
// Return TRUE if all of the courses can be finished. Otherwise, return FALSE.
//
// Constraints:
//
// - 1 ≤ `numCourses` ≤ 1500
// - 0 ≤ `prerequisites.length` ≤ 1000
// - `prerequisites[i].length` == 2
// - 0 ≤ `a[i]`, `b[i]` < `numCourses`
// - All the pairs `prerequisites[i]` are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N16_TopologicalSort.P05_CourseSchedule;

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
