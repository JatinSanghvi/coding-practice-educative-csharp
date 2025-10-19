// Serialize and Deserialize Binary Tree
// =====================================
//
// Serialize a given binary tree to a file and deserialize it back to a tree. Make sure that the original and the
// deserialized trees are identical.
//
// - Serialize: Write the tree to a file.
//
// - Deserialize: Read from a file and reconstruct the tree in memory.
//
// Serialize the tree into a list of integers, and then, deserialize it back from the list to a tree. For simplicity's
// sake, there's no need to write the list to the files.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [0, 500].
// - -1000 ≤ `Node.data` ≤ 1000

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P03_SerializeAndDeserializeBinaryTree;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static List<string> Serialize(TreeNode<int> root)
    {
        var parents = new List<TreeNode<int>> { new(0) { right = root } };
        var stream = new List<string>();

        for (int i = 0; i != parents.Count; i++)
        {
            stream.Add(parents[i].left?.data.ToString());
            stream.Add(parents[i].right?.data.ToString());

            if (parents[i].left != null) { parents.Add(parents[i].left); }
            if (parents[i].right != null) { parents.Add(parents[i].right); }
        }

        return stream;
    }

    // Time complexity: O(n), Space complexity: O(n).
    public static TreeNode<int> Deserialize(List<string> stream)
    {
        var parents = new List<TreeNode<int>> { new TreeNode<int>(0) };

        for (int i = 0; i != parents.Count; i++)
        {
            parents[i].left = stream[2 * i] == null ? null : new TreeNode<int>(int.Parse(stream[2 * i]));
            parents[i].right = stream[2 * i + 1] == null ? null : new TreeNode<int>(int.Parse(stream[2 * i + 1]));

            if (parents[i].left != null) { parents.Add(parents[i].left); }
            if (parents[i].right != null) { parents.Add(parents[i].right); }
        }

        return parents[0].right;
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
        Run([1, 2, null, 3, 4, 5, null, null, 6]);
        Run([]);
    }

    private static void Run(int?[] values)
    {
        TreeNode<int> root1 = values.ToTree();
        List<string> stream = Solution.Serialize(root1);
        Utilities.PrintSolution(values, stream);
        TreeNode<int> root2 = Solution.Deserialize(stream);
        Assert.IsTrue(CompareTrees(root1, root2));
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
                node = new TreeNode<int>(val.Value);
                parents.Add(node);
            }

            if (isLeft) { parents[i].left = node; }
            else { parents[i++].right = node; }

            isLeft = !isLeft;
        }

        return parents[0].right;
    }

    private static bool CompareTrees(TreeNode<int> root1, TreeNode<int> root2)
    {
        if (root1 == null && root2 == null) { return true; }
        if (root1 == null || root2 == null) { return false; }

        if (root1 == root2 || root1.data != root2.data)
        {
            return false;
        }

        return CompareTrees(root1.left, root2.left) && CompareTrees(root1.right, root2.right);
    }
}
