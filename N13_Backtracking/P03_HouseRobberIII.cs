// House Robber III
// ================
//
// A thief has discovered a new neighborhood to target, where the houses can be represented as nodes in a binary tree.
// The money in the house is the data of the respective node. The thief can enter the neighborhood from a house
// represented as `root` of the binary tree. Each house has only one parent house. The thief knows that if he robs two
// houses that are directly connected, the police will be notified. The thief wants to know the maximum amount of money
// he can steal from the houses without getting caught by the police. The thief needs your help determining the maximum
// amount of money he can rob without alerting the police.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [1, 500].
// - 0 ≤ `node.data` ≤ 10^4

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P03_HouseRobberIII;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int Rob(TreeNode<int> root)
    {
        (int withRoot, int withoutRoot) = Solve(root);
        return Math.Max(withRoot, withoutRoot);

        (int withRoot, int withoutRoot) Solve(TreeNode<int> root)
        {
            if (root == null) { return (0, 0); }

            (int withLeftRoot, int withoutLeftRoot) = Solve(root.left);
            (int withRightRoot, int withoutRightRoot) = Solve(root.right);

            int withRoot = root.data + withoutLeftRoot + withoutRightRoot;
            int withoutRoot = Math.Max(withLeftRoot, withoutLeftRoot) + Math.Max(withRightRoot, withoutRightRoot);

            return (withRoot, withoutRoot);
        }
    }
}

public class TreeNode<T>(T data)
{
    public T data = data;
    public TreeNode<T> left = null;
    public TreeNode<T> right = null;
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, null, null, 6, 7], 15);
    }

    private static void Run(int?[] values, int expectedResult)
    {
        TreeNode<int> root = values.ToTree();
        int result = Solution.Rob(root);
        Utilities.PrintSolution(values, result);
        Assert.AreEqual(expectedResult, result);
    }

    private static TreeNode<T> ToTree<T>(this T?[] values) where T : struct
    {
        var nodes = new List<TreeNode<T>> { new TreeNode<T>(default) };
        var parentIndex = 0;
        var isLeft = false;

        foreach (T? value in values)
        {
            if (value != null)
            {
                var node = new TreeNode<T>(value.Value);
                nodes.Add(node);

                if (isLeft) { nodes[parentIndex].left = node; }
                else { nodes[parentIndex].right = node; }
            }

            if (!isLeft) { parentIndex++; }
            isLeft = !isLeft;
        }

        return nodes[0].right;
    }
}
