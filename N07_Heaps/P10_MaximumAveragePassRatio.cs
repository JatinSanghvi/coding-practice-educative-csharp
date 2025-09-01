// Maximum Average Pass Ratio
// ==========================
//
// A school has several classes of students, each taking a final exam. You are provided a 2D integer array, `classes`,
// where `classes[i] = [pass_i, total_i]`. Here, `pass_i` represents the number of students in the ith class who are
// expected to pass the exam, and `total_i` represents the total number of students in that class.
//
// Additionally, you are given an integer, `extraStudents`, which denotes the number of brilliant extra students
// guaranteed to pass their exams. These students can be assigned to any class, and your goal is to distribute them to
// maximize the average pass ratio across all classes.
//
// The pass ratio for a class is defined as the ratio of the number of students passing to the total number of students
// in the class:
//
// Pass Ratio = pass_i / total_i
//
// The average pass ratio is the sum of the pass ratios of all classes divided by the total number of classes:
//
// Average Pass Ratio = ∑(Pass Ratio of each class) / Total Number of Classes
//
// Your task is to return the maximum achievable average pass ratio after assigning all `extraStudents` to the classes.
// Answers within 10^-5 of the actual answer will be accepted.
//
// Constraints:
//
// - 1 ≤ `classes.length` ≤ 10^3
// - `classes[i].length` == 2
// - 1 ≤ `pass_i` ≤ `total_i` ≤ 10^4
// - 1 ≤ `extraStudents` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P10_MaximumAveragePassRatio;

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
