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

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P10_MaximumAveragePassRatio;

public class Solution
{
    // Time complexity: O((s+n)*logn) where s=extraStudents, Space complexity: O(n).
    public static double MaxAverageRatio(int[][] classes, int extraSudents)
    {
        var classQueue = new PriorityQueue<int, double>();

        for (int ci = 0; ci < classes.Length; ci++)
        {
            Enqueue(ci);
        }

        for (int si = 0; si < extraSudents; si++)
        {
            int ci = classQueue.Dequeue();
            classes[ci][0]++;
            classes[ci][1]++;
            Enqueue(ci);
        }

        double sumRatio = 0.0;
        foreach (int[] class_ in classes)
        {
            sumRatio += (double)class_[0] / class_[1];
        }

        return sumRatio / classes.Length;

        void Enqueue(int index)
        {
            int passing = classes[index][0];
            int total = classes[index][1];

            // Difference a student makes to pass ratio.
            double passRatioIncrease = (double)(total - passing) / (total * (total + 1));
            classQueue.Enqueue(index, -passRatioIncrease);
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2], [2, 3], [3, 4]], 6, 0.8);
    }

    private static void Run(int[][] classes, int extraStudents, double expectedResult)
    {
        var classesCopy = classes.Select(class_ => class_.ToArray()).ToArray();
        double result = Solution.MaxAverageRatio(classes, extraStudents);
        Utilities.PrintSolution((classesCopy, extraStudents), result);
        Assert.AreEqual(expectedResult, result, 1e-5);
    }
}
