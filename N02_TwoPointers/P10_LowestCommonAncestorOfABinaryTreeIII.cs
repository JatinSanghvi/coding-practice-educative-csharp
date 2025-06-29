// You are given two nodes, `p` and `q`. The task is to return theirlowest common ancestor(LCA). Both nodes have a
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
        for (EduTreeNode? ancestor = p; ancestor != null; ancestor = ancestor.parent)
        {
            pDepth += 1;
        }

        int qDepth = 0;
        for (EduTreeNode? ancestor = q; ancestor != null; ancestor = ancestor.parent)
        {
            qDepth += 1;
        }

        while (pDepth > qDepth) { p = p.parent!; pDepth -= 1; }
        while (qDepth > pDepth) { q = q.parent!; qDepth -= 1; }
        while (p.data != q.data) { p = p.parent!; q = q.parent!; }

        return p;
    }
}

public class EduTreeNode(int value)
{
    public int data = value;
    public EduTreeNode? left = null;
    public EduTreeNode? right = null;
    public EduTreeNode? parent = null;
}

internal static class Tests
{
    public static void Run()
    {
        int?[] values = new int?[] { 1, 2, 3, 4, 5, null, null, 6, null, null, 7 };

        Assert.AreEqual(1, RunInternal(values, 1, 7));
        Assert.AreEqual(2, RunInternal(values, 2, 7));
        Assert.AreEqual(1, RunInternal(values, 3, 7));
        Assert.AreEqual(2, RunInternal(values, 4, 7));
        Assert.AreEqual(5, RunInternal(values, 5, 7));
        Assert.AreEqual(2, RunInternal(values, 6, 7));
    }

    private static int RunInternal(int?[] values, int pData, int qData)
    {
        EduTreeNode? tree = values.ToTree();
        EduTreeNode p = tree.Find(pData)!;
        EduTreeNode q = tree.Find(qData)!;
        EduTreeNode ancestor = new Solution().LowestCommonAncestor(p, q);
        return ancestor.data;
    }

    private static EduTreeNode? Find(this EduTreeNode? root, int data)
    {
        if (root is null) { return null; }
        if (root.data == data) { return root; }

        EduTreeNode? node;
        if ((node = root.left.Find(data)) is not null) { return node; }
        if ((node = root.right.Find(data)) is not null) { return node; }
        return null;
    }

    private static EduTreeNode? ToTree(this int?[] values)
    {
        List<EduTreeNode> nodes = new() { new EduTreeNode(0) };

        int index = 0;
        bool isLeft = false;
        foreach (int? value in values)
        {
            if (value is not null)
            {
                EduTreeNode node = new(value.Value) { parent = nodes[index] };
                nodes.Add(node);

                if (isLeft)
                {
                    nodes[index].left = node;
                }
                else
                {
                    nodes[index].right = node;
                }
            }

            if (!isLeft)
            {
                index += 1;
            }

            isLeft = !isLeft;
        }

        return nodes[0].right;
    }

    private static int?[] ToArray(this EduTreeNode? root)
    {
        List<EduTreeNode?> nodes = new() { root };

        for (int index = 0; index < nodes.Count; index++)
        {
            if (nodes[index] is not null)
            {
                nodes.Add(nodes[index]!.left);
                nodes.Add(nodes[index]!.right);
            }
        }

        return nodes.Select(node => node?.data).ToArray();
    }
}
