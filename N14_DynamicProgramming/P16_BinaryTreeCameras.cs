// Binary Tree Cameras
// ===================
//
// You are given the `root` of a binary tree. Cameras can be installed on any node, and each camera can monitor itself,
// its parent, and its immediate children.
//
// Your task is to determine the minimum number of cameras required to monitor every node in the tree.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [1, 1000].
// - `Node.data` == 0

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P16_BinaryTreeCameras;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(logn).
    public int MinCameraCover(TreeNode<int> root)
    {
        (int _, int covered, int coveredWithCamera) = Solve(root);
        return Math.Min(covered, coveredWithCamera);
    }

    private (int, int, int) Solve(TreeNode<int> node)
    {
        if (node == null) { return (0, 0, 1); }

        (int leftNotCovered, int leftCovered, int leftCoveredWithCamera) = Solve(node.left);
        (int rightNotCovered, int rightCovered, int rightCoveredWithCamera) = Solve(node.right);

        int notCovered = leftCovered + rightCovered;

        int covered = Math.Min(
            leftCoveredWithCamera + Math.Min(rightCovered, rightCoveredWithCamera),
            rightCoveredWithCamera + Math.Min(leftCovered, leftCoveredWithCamera));

        int coveredWithCamera = leftNotCovered + rightNotCovered + 1;

        return (notCovered, covered, coveredWithCamera);
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
        Run([1], 1);
        Run([1, 2, 3], 1);
        Run([1, 2, 3, 4, 5, 6, 7], 2);
        Run([1, 2, null, null, 5, 10, null, null, 21, 42], 2);
    }

    private static void Run(int?[] values, int expectedResult)
    {
        TreeNode<int> root = values.ToTree();
        int result = new Solution().MinCameraCover(root);
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
