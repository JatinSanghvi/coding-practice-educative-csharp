// Same Tree
// =========
//
// Given the roots of two binary trees, `p` and `q`, write a function to check whether or not they are the same. Two
// binary trees are considered the same if they're structurally identical and the nodes have the same value.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [0,100]
// - -10^4 ≤ `node.data` ≤ 10^4

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P33_SameTree;

public class Solution
{
    // Time complexity: O(m + n), Space complexity: O(m + n).
    public static bool SameTree(TreeNode<int> p, TreeNode<int> q)
    {
        if (p == null && q == null) { return true; }
        if (p == null || q == null || p.data != q.data) { return false; }

        return SameTree(p.left, q.left) && SameTree(p.right, q.right);
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
        Run([1, 2, 3, 4, null, null, 7], [1, 2, 3, 4, null, null, 7], true);
        Run([1, 2, 3, 4, null, 6, 7], [1, 2, 3, 4, null, 6, null], false);
        Run([1, 2, 3, 4, null, 6, 7], [1, 2, 3, 4, null, 6, 77], false);
    }

    private static void Run(int?[] pValues, int?[] qValues, bool expectedResult)
    {
        TreeNode<int> p = pValues.ToTree();
        TreeNode<int> q = qValues.ToTree();
        bool result = Solution.SameTree(p, q);
        Utilities.PrintSolution((pValues, qValues), result);
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
