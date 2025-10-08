// Binary Tree Level Order Traversal
// =================================
//
// Given the root of a binary tree, display the values of its nodes while performing a level order traversal. Return the
// node values for all levels in a string separated by the character `:`. If the tree is empty, i.e., the number of
// nodes is 0, then return "None" as the output.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [0, 500].
// - -10^3 ≤ `Node.data` ≤ 10^3

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P01_BinaryTreeLevelOrderTraversal;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static string LevelOrderTraversal(TreeNode<int> root)
    {
        if (root == null) { return "None"; }

        var levels = new List<string>();
        var levelNodes = new List<TreeNode<int>> { root };

        while (levelNodes.Count != 0)
        {
            var level = new List<int>();
            var nextLevelNodes = new List<TreeNode<int>>();

            foreach (TreeNode<int> node in levelNodes)
            {
                level.Add(node.data);
                if (node.left != null) { nextLevelNodes.Add(node.left); }
                if (node.right != null) { nextLevelNodes.Add(node.right); }
            }

            levels.Add(string.Join(", ", level));
            levelNodes = nextLevelNodes;
        }

        return string.Join(" : ", levels);
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
        Run([1, null, 2, 3, 4, 5, null, null, 6], "1 : 2 : 3, 4 : 5, 6");
    }

    private static void Run(int?[] rootValues, string expectedResult)
    {
        TreeNode<int> root = rootValues.ToTree();
        string result = Solution.LevelOrderTraversal(root);
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
