// The Skyline Problem
// ===================
//
// Imagine standing at a distance, viewing the skyline of a city. The skyline is the shape formed by all the buildings
// in the city when viewed together. Your task is to determine the shape of this skyline, given all the buildings'
// position and height. Each building is represented by three values in the array `buildings`, where buildings[i] =
// [left_i, right_i, height_i]:
//
// 1. `left_i` is the x-coordinate where the i-th building starts.
// 2. `right_i` is the x-coordinate where the i-th building ends.
// 3. `height_i` is the height of the i-th building.
//
// All buildings are rectangles that sit on flat ground (height 0). The skyline should be a list of points that define
// its outline, with each point showing where the height changes as you move from left to right. The final point should
// have a height of 0, marking where the last building ends.
//
// > Note: The output skyline should not have multiple horizontal lines at the same height in a row. For example, an
// > output like [...,[1,4],[3,6],[5,6],[7,6],[8,3],...] is incorrect. The three lines with height 6 should be combined
// > into one, so the correct version would be [...,[1,4],[3,6],[8,3],...].
//
// Constraints:
//
// - 1 ≤ `buildings.length` ≤ 10^3
// - 0 ≤ `left_i` < `right_i` ≤ 10^4
// - 0 ≤ `height_i` ≤ 10^4
// - `buildings` is sorted by `left_i` in ascending order.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P10_TheSkylineProblem;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public static int[][] GetSkyline(int[][] buildings)
    {
        var changes = new SortedDictionary<int, List<(bool isStart, int index)>>();
        for (int i = 0; i != buildings.Length; i++)
        {
            changes.TryAdd(buildings[i][0], new List<(bool, int)>());
            changes.TryAdd(buildings[i][1], new List<(bool, int)>());

            changes[buildings[i][0]].Add((true, i));
            changes[buildings[i][1]].Add((false, i));
        }

        var heap = new PriorityQueue<int, int>();
        var ended = new HashSet<int>();
        var skyline = new List<int[]>();

        foreach ((int pos, List<(bool, int)> values) in changes)
        {
            foreach ((bool isStart, int index) in values)
            {
                if (isStart)
                {
                    heap.Enqueue(index, -buildings[index][2]); // Height
                }
                else
                {
                    ended.Add(index);
                    while (heap.Count != 0 && ended.Contains(heap.Peek()))
                    {
                        ended.Remove(heap.Dequeue());
                    }
                }
            }

            int height = heap.Count == 0 ? 0 : buildings[heap.Peek()][2];
            if (skyline.Count != 0 || height != skyline[^1][1])
            {
                skyline.Add([pos, height]);
            }
        }

        return skyline.ToArray();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2, 1], [3, 4, 2]], [[1, 1], [2, 0], [3, 2], [4, 0]]); // Disconnected.
        Run([[1, 2, 1], [2, 3, 3], [3, 4, 2]], [[1, 1], [2, 3], [3, 2], [4, 0]]); // Connected.
        Run([[1, 4, 1], [2, 3, 2]], [[1, 1], [2, 2], [3, 1], [4, 0]]); // Overlap
        Run([[1, 4, 1], [2, 4, 2], [3, 4, 3]], [[1, 1], [2, 2], [3, 3], [4, 0]]); // Staircase up.
        Run([[1, 4, 1], [1, 3, 2], [1, 2, 3]], [[1, 3], [2, 2], [3, 1], [4, 0]]); // Staircase down.
    }

    private static void Run(int[][] buildings, int[][] expectedResult)
    {
        int[][] result = Solution.GetSkyline(buildings);
        Utilities.PrintSolution(buildings, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
