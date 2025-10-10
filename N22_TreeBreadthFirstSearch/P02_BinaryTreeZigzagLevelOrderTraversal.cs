// Binary Tree Zigzag Level Order Traversal
// ========================================
//
// Given a binary tree, return its zigzag level order traversal. The zigzag level order traversal corresponds to
// traversing nodes from left to right for one level, and then right to left for the next level, and so on, reversing
// direction after every level.
//
// Constraints:
//
// - The number of nodes in the tree is in the range 0 to 500.
// - -100 ≤ `node.data` ≤ 100

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P02_BinaryTreeZigzagLevelOrderTraversal;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(logn).
    public static IList<IList<int>> ZigzagLevelOrder(TreeNode<int> root)
    {
        var zigzagOrder = new List<IList<int>>();

        if (root != null)
        {
            var levelNodes = new Stack<TreeNode<int>>();
            levelNodes.Push(root);

            var isLeft = true;
            while (levelNodes.Count != 0)
            {
                var levelOrder = new List<int>();
                var nextLevelNodes = new Stack<TreeNode<int>>();

                while (levelNodes.Count != 0)
                {
                    TreeNode<int> node = levelNodes.Pop();
                    levelOrder.Add(node.data);

                    if (isLeft)
                    {
                        if (node.left != null) { nextLevelNodes.Push(node.left); }
                        if (node.right != null) { nextLevelNodes.Push(node.right); }
                    }
                    else
                    {
                        if (node.right != null) { nextLevelNodes.Push(node.right); }
                        if (node.left != null) { nextLevelNodes.Push(node.left); }
                    }
                }

                zigzagOrder.Add(levelOrder);
                levelNodes = nextLevelNodes;
                isLeft = !isLeft;
            }
        }

        return zigzagOrder;
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
        Run([1, 2, null, 3, 4, 5, null, null, 6], [[1], [2], [3, 4], [6, 5]]);
    }

    private static void Run(int?[] rootValues, int[][] expectedResult)
    {
        TreeNode<int> root = rootValues.ToTree();
        int[][] result = Solution.ZigzagLevelOrder(root).Select(level => level.ToArray()).ToArray();
        Utilities.PrintSolution(rootValues, result);
        CollectionAssert.AreEqual(expectedResult, result);
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
