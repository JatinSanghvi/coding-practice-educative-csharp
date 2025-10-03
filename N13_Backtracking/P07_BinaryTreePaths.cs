// Binary Tree Paths
// =================
//
// Given the `root` of a binary tree, return all paths from the root to the leaf nodes in any order. Each path should be
// represented as a string of node values, separated by arrows (`→`), where a leaf is defined as a node with no
// children.
//
// Constraints:
//
// - 1 ≤ `nodes` ≤ 100
// - -10^4 ≤ `nodes.data` ≤ 10^4

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P07_BinaryTreePaths;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public IList<string> BinaryTreePaths(TreeNode<int> root)
    {
        var paths = new List<string>();
        var path = new LinkedList<int>();
        path.AddLast(root.data);

        Solve(root);
        return paths;

        void Solve(TreeNode<int> node)
        {
            if (node.left == null && node.right == null)
            {
                paths.Add(string.Join("->", path)); // ~O(logn).
                return;
            }

            if (node.left != null)
            {
                path.AddLast(node.left.data);
                Solve(node.left);
                path.RemoveLast();
            }

            if (node.right != null)
            {
                path.AddLast(node.right.data);
                Solve(node.right);
                path.RemoveLast();
            }
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
        Run([1, 2, 3, 4, null, 6, 7], ["1->2->4", "1->3->6", "1->3->7"]);
    }

    private static void Run(int?[] values, string[] expectedResult)
    {
        TreeNode<int> root = values.ToTree();
        string[] result = new Solution().BinaryTreePaths(root).ToArray();
        Utilities.PrintSolution(values, result);
        CollectionAssert.AreEqual(expectedResult, result);
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
