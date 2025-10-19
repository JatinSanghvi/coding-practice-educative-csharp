// Vertical Order Traversal of a Binary Tree
// =========================================
//
// Find the vertical order traversal of a binary tree when the root of the binary tree is given. In other words, return
// the values of the nodes from top to bottom in each column, column by column from left to right. If there is more than
// one node in the same column and row, return the values from left to right.
//
// Constraints:
//
// - The number of nodes in the tree is in the range `[1, 500]`.
// - -1000 ≤ `Node.data` ≤ 1000

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P04_VerticalOrderTraversalOfABinaryTree;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static IList<IList<int>> VerticalOrder(TreeNode<int> root)
    {
        var row = new List<(TreeNode<int>, int)> { (root, 0) };
        var columns = new Dictionary<int, List<int>>();
        int leftIndex = 0;

        while (row.Count != 0)
        {
            var nextRow = new List<(TreeNode<int>, int)>();

            foreach ((TreeNode<int> node, int i) in row)
            {
                columns.TryAdd(i, new List<int>());
                columns[i].Add(node.data);
                leftIndex = Math.Min(leftIndex, i);

                if (node.left != null) { nextRow.Add((node.left, i - 1)); }
                if (node.right != null) { nextRow.Add((node.right, i + 1)); }
            }

            row = nextRow;
        }

        var order = new List<IList<int>>();

        for (int i = leftIndex; columns.ContainsKey(i); i++)
        {
            order.Add(columns[i]);
        }

        return order;
    }
}

public class TreeNode<T>(T data)
{
    public T data = data;
    public TreeNode<T> left;
    public TreeNode<T> right;
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, null, 3, 4, 5, null, null, 6], [[5], [3], [2], [1, 4], [6]]);
    }

    private static void Run(int?[] values, int[][] expectedResult)
    {
        int[][] result = Solution.VerticalOrder(values.ToTree())
            .Select(column => column.ToArray())
            .ToArray();

        Utilities.PrintSolution(values, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }

    private static TreeNode<int> ToTree(this int?[] values)
    {
        var parents = new List<TreeNode<int>> { new(0) };
        int i = 0;
        bool isLeft = false;

        foreach (int? val in values)
        {
            TreeNode<int> node = null;
            if (val != null)
            {
                node = new(val.Value);
                parents.Add(node);
            }

            if (isLeft) { parents[i].left = node; }
            else { parents[i++].right = node; }

            isLeft = !isLeft;
        }

        return parents[0].right;
    }
}
