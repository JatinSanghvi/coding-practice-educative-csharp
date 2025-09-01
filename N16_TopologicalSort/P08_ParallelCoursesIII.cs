// Parallel Courses III
// ====================
//
// You are tasked with determining the minimum time required to complete a set of courses, given their prerequisite
// relationships and individual durations.
//
// There are `n` courses labeled from `1` to `n`. The prerequisite relationships between these courses are provided as a
// 2D integer array `relations`, where each entry `relations[j] = [prevCourse_j, nextCourse_j]` indicates that course
// `prevCourse_j` must be completed before course `nextCourse_j`. An array, `time`, is also given, where `time[i]`
// specifies the number of months required to complete the course labeled `i + 1`.
//
// You may begin any course as soon as you have completed all its prerequisites. If all the prerequisites are satisfied,
// multiple courses may be taken simultaneously. Calculate the minimum months needed to finish all the courses.
//
// > Note: The given prerequisite structure is guaranteed to form a directed acyclic graph (DAG), ensuring that all
// > courses can be completed.
//
// Constraints:
//
// - 1 ≤ n ≤ 5 × 10^4
// - 0 ≤ `relations.length` ≤ min(n ⋅ (n - 1) / 2, 5 × 10^4)
// - `relations[j].length` == 2
// - 1 ≤ `prevCourse_j`, `nextCourse_j` ≤ n
// - `prevCourse_j` ≠ `nextCourse_j`
// - All pairs (`prevCourse_j`, `nextCourse_j`) are unique.
// - `time.length` == n
// - 1 ≤ `time[i]` ≤ 10^4
// - The prerequisite graph is a directed acyclic graph (DAG).

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N16_TopologicalSort.P08_ParallelCoursesIII;

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
