// Lowest Common Ancestor of a Binary Tree III
// ===========================================
// 
// You are given two nodes, `p` and `q`. The task is to return their lowest common ancestor(LCA). Both nodes have a
// reference to their parent node. The tree's root is not provided; you must use the parent pointers to find the nodes'
// common ancestor.
// 
// > Note: The lowest common ancestor of two nodes, `p` and `q`, is the lowest node in the binary tree, with both `p`
// > and `q` as descendants.
// >
// > In a tree, a descendant of a node is any node reachable by following edges downward from that node, including the
// > node itself.
// 
// Constraints:
// 
// - -10^4 ≤ `Node.data` ≤ 10^4
// - The number of nodes in the tree is in the range [2,500].
// - All `Node.data` are unique.
// - `p` != `q`
// - Both `p` and `q` are present in the tree.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P10_LowestCommonAncestorOfABinaryTreeIII;

public class Solution
{
    public EduTreeNode LowestCommonAncestor(EduTreeNode p, EduTreeNode q)
    {
        int pDepth = 0;
        int qDepth = 0;

        for (EduTreeNode ancestor = p; ancestor != null; ancestor = ancestor.parent) { pDepth++; }
        for (EduTreeNode ancestor = q; ancestor != null; ancestor = ancestor.parent) { qDepth++; }

        for (; pDepth > qDepth; pDepth--) { p = p.parent; }
        for (; qDepth > pDepth; qDepth--) { q = q.parent; }

        while (p != q)
        {
            p = p.parent;
            q = q.parent;
        }

        return p;
    }
}

public class EduTreeNode(int value)
{
    public int data = value;
    public EduTreeNode left = null;
    public EduTreeNode right = null;
    public EduTreeNode parent = null;
}

internal static class Tests
{
    public static void Run()
    {
        int?[] values = new int?[] { 1, 2, 3, 4, 5, null, null, 6, null, null, 7 };

        Run(values, 1, 7, 1);
        Run(values, 2, 7, 2);
        Run(values, 3, 7, 1);
        Run(values, 4, 7, 2);
        Run(values, 5, 7, 5);
        Run(values, 6, 7, 2);
    }

    private static void Run(int?[] values, int pData, int qData, int expectedResultData)
    {
        EduTreeNode tree = values.ToTree();
        EduTreeNode p = tree.Find(pData);
        EduTreeNode q = tree.Find(qData);

        EduTreeNode result = new Solution().LowestCommonAncestor(p, q);
        Utilities.PrintSolution((values, p.data, q.data), result.data);
        Assert.AreEqual(expectedResultData, result.data);
    }

    private static EduTreeNode ToTree(this int?[] values)
    {
        var nodes = new List<EduTreeNode> { new EduTreeNode(0) };
        int parentIndex = 0;
        bool isLeft = false;

        foreach (int? value in values)
        {
            if (value != null)
            {
                var node = new EduTreeNode(value.Value)
                {
                    parent = nodes[parentIndex]
                };

                if (isLeft)
                {
                    nodes[parentIndex].left = node;
                }
                else
                {
                    nodes[parentIndex].right = node;
                }

                nodes.Add(node);
            }

            if (!isLeft)
            {
                parentIndex++;
            }

            isLeft = !isLeft;
        }

        return nodes[0].right;
    }

    private static int?[] ToArray(this EduTreeNode root)
    {
        var nodes = new List<EduTreeNode> { root };
        for (int index = 0; index < nodes.Count; index++)
        {
            var node = nodes[index];
            if (node != null)
            {
                nodes.Add(node.left);
                nodes.Add(node.right);
            }
        }

        return nodes.Select(node => node?.data).ToArray();
    }

    private static EduTreeNode Find(this EduTreeNode root, int data)
    {
        if (root == null) { return null; }
        if (root.data == data) { return root; }

        return root.left.Find(data) ?? root.right.Find(data);
    }
}
