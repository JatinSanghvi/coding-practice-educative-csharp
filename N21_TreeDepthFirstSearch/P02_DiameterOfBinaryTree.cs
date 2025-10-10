// Diameter of Binary Tree
// =======================
//
// Given a binary tree, you need to compute the length of the tree's diameter. The diameter of a binary tree is the
// length of the longest path between any two nodes in a tree. This path may or may not pass through the root.
//
// > Note: The length of the path between two nodes is represented by the number of edges between them.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [1, 500].
// - -100 ≤ `Node.value` ≤ 100

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P02_DiameterOfBinaryTree;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int DiameterOfBinaryTree(TreeNode<int> root)
    {
        return Solve(root).diameter;

        static (int depth, int diameter) Solve(TreeNode<int> node)
        {
            if (node == null) { return (0, 0); }

            (int leftDepth, int leftDiameter) = Solve(node.left);
            (int rightDepth, int rightDiameter) = Solve(node.right);

            return (
                Math.Max(leftDepth, rightDepth) + 1,
                Math.Max(Math.Max(leftDiameter, rightDiameter), leftDepth + rightDepth)
            );
        }
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
        Run([1, 2, null, 3, 4, 5, null, null, 6], 4);
    }

    private static void Run(int?[] rootValues, int expectedResult)
    {
        TreeNode<int> root = rootValues.ToTree();
        int result = Solution.DiameterOfBinaryTree(root);
        Utilities.PrintSolution(rootValues, result);
        Assert.AreEqual(expectedResult, result);
    }

    private static TreeNode<T> ToTree<T>(this T?[] values) where T : struct
    {
        var nodes = new List<TreeNode<T>> { new(default) };
        int parentIndex = 0;
        bool isLeft = false;

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
