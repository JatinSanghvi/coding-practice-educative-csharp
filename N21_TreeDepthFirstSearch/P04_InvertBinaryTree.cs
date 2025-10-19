// Invert Binary Tree
// ==================
//
// Given the root node of a binary tree, transform the tree by swapping each node's left and right subtrees, thus
// creating a mirror image of the original tree. Return the root of the transformed tree.
//
// Constraints:
//
// - 0 ≤ Number of nodes in the tree ≤ 100
// - -1000 ≤ `Node.value` ≤ 1000

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P04_InvertBinaryTree;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static TreeNode<int> Invert(TreeNode<int> root)
    {
        if (root != null)
        {
            (root.left, root.right) = (root.right, root.left);
            Invert(root.left);
            Invert(root.right);
        }

        return root;
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
        Run([1, 2, null, 3, 4, 5, null, null, 6], [1, null, 2, 4, 3, 6, null, null, 5]);
    }

    private static void Run(int?[] values, int?[] expectedResult)
    {
        int?[] result = Solution.Invert(values.ToTree()).ToValues();
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

    private static int?[] ToValues(this TreeNode<int> root)
    {
        var values = new List<int?>();

        var parents = new List<TreeNode<int>> { new(0) { right = root } };
        int i = 0;
        bool isLeft = false;

        while (i != parents.Count)
        {
            TreeNode<int> node = isLeft ? parents[i].left : parents[i].right;
            if (node != null)
            {
                values.Add(node.data);
                parents.Add(node);
            }
            else
            {
                values.Add(null);
            }

            if (!isLeft) { i++; }
            isLeft = !isLeft;
        }

        while (values.Count != 0 && values[^1] == null)
        {
            values.RemoveAt(values.Count - 1);
        }

        return values.ToArray();
    }
}
