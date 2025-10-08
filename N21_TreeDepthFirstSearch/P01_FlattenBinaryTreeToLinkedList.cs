// Flatten Binary Tree to Linked List
// ==================================
//
// Given the `root` of a binary tree, the task is to flatten the tree into a linked list using the same `TreeNode`
// class. The left child pointer of each node in the linked list should always be NULL, and the right child pointer
// should point to the next node in the linked list. The nodes in the linked list should be in the same order as that of
// the preorder traversal of the given binary tree.
//
// Constraints:
//
// - -100 ≤ `Node.data` ≤ 100.
// - The tree contains nodes in the range [1, 500].

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P01_FlattenBinaryTreeToLinkedList;

public class Solution
{
    public static TreeNode<int> FlattenTree(TreeNode<int> root)
    {
        return Visit(root).Item1;

        (TreeNode<int>, TreeNode<int>) Visit(TreeNode<int> node)
        {
            if (node == null) { return (null, null); }

            (TreeNode<int> leftFirst, TreeNode<int> leftLast) = Visit(node.left);
            (TreeNode<int> rightFirst, TreeNode<int> rightLast) = Visit(node.right);

            TreeNode<int> last = node;
            node.left = null;

            if (leftFirst != null)
            {
                last.right = leftFirst;
                last = leftLast;
            }

            if (rightFirst != null)
            {
                last.right = rightFirst;
                last = rightLast;
            }

            return (node, last);
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
        Run([1, 2, 4, 3, null, 5], [1, null, 2, null, 3, null, 4, null, 5, null, null]);
    }

    private static void Run(int?[] rootValues, int?[] expectedResultValues)
    {
        TreeNode<int> root = rootValues.ToTree();
        TreeNode<int> result = Solution.FlattenTree(root);
        int?[] resultValues = result.ToValues();
        Utilities.PrintSolution(rootValues, resultValues);
        CollectionAssert.AreEqual(expectedResultValues, resultValues);
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

    private static T?[] ToValues<T>(this TreeNode<T> root) where T : struct
    {
        var values = new List<T?>();
        var nodes = new List<TreeNode<T>>() { root };

        for (int i = 0; i != nodes.Count; i++)
        {
            TreeNode<T> node = nodes[i];
            if (node == null)
            {
                values.Add(null);
            }
            else
            {
                values.Add(node.data);
                nodes.Add(node.left);
                nodes.Add(node.right);
            }
        }

        return values.ToArray();
    }
}
