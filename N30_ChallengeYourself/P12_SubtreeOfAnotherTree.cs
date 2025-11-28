// Subtree of Another Tree
// =======================
//
// Given the roots of two binary trees, `root` and `subRoot`, return TRUE if there is a subtree of `root` with the same
// structure and nodes as `subRoot`. Otherwise, return FALSE.
//
// A tree can only be considered a subtree of the `root` tree iff all the descendants (children) of the node appear in
// `subRoot`.
//
// Constraints:
//
// - The number of nodes in the `root` tree is in the range [1,500].
// - The number of nodes in the `subRoot` tree is in the range [1,250].
// - -10^4 ≤ [`root.data`](https://www.educative.io/courses/grokking-coding-interview-in-csharp/root.data) ≤ 10^4
// - -10^4 ≤ [`subRoot.data`](https://www.educative.io/courses/grokking-coding-interview-in-csharp/subRoot.data) ≤ 10^4

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P12_SubtreeOfAnotherTree;

public class Solution
{
    // Time complexity: O(mn), Space complexity: O(m + n).
    public static bool IsSubTree(TreeNode<int> root, TreeNode<int> subRoot)
    {
        return Check(root);

        bool Check(TreeNode<int> node)
        {
            if (node == null) { return false; }
            return Check2(node, subRoot) || Check(node?.left) || Check(node?.right);
        }

        bool Check2(TreeNode<int> node, TreeNode<int> subNode)
        {
            if (node == null && subNode == null) { return true; }
            if (node?.data != subNode?.data) { return false; }
            return Check2(node.left, subNode.left) && Check2(node.right, subNode.right);
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
        Run([1, 2, 3, 4, null, null, 7], [2, 4, null], true);
        Run([1, 2, 3, 4, null, null, 7], [2, 4, 5], false);
        Run([1, 2, 3, 4, null, null, 7], [1, 2, 3, 4, null, null, null], false);
    }

    private static void Run(int?[] values, int?[] subValues, bool expectedResult)
    {
        TreeNode<int> root = values.ToTree();
        TreeNode<int> subRoot = subValues.ToTree();

        bool result = Solution.IsSubTree(root, subRoot);
        Utilities.PrintSolution((values, subValues), result);
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
