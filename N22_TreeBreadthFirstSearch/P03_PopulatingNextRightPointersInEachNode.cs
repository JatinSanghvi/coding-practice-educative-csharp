// Populating Next Right Pointers in Each Node
// ===========================================
//
// Given a perfect binary tree, where each node contains an additional pointer called `next`. This pointer is initially
// set to `NULL` for all nodes. Your task is to connect all nodes of the same hierarchical level by setting the `next`
// pointer to its immediate right node.
//
// The `next` pointer of the rightmost node at each level is set to NULL.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [0, 500].
// - -1000 ≤ `Node.data` ≤ 1000

using System.Collections.Generic;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P03_PopulatingNextRightPointersInEachNode;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static EduTreeNode<int> PopulateNextPointers(EduTreeNode<int> root)
    {
        for (EduTreeNode<int> left = root; left?.left != null; left = left.left)
        {
            for (EduTreeNode<int> node = left; node != null; node = node.next)
            {
                node.left.next = node.right;
                node.right.next = node.next?.left;
            }
        }

        return root;
    }
}

public class EduTreeNode<T>(T data)
{
    public T data = data;
    public EduTreeNode<T> left;
    public EduTreeNode<T> right;
    public EduTreeNode<T> next;
}

internal static class Tests
{
    public static void Run()
    {
        Run(0);
        Run(1);
        Run(2);
    }

    private static void Run(int depth)
    {
        Solution.PopulateNextPointers(CreateTree(depth));
        // Not asserting the correctness to save time.
    }

    private static EduTreeNode<int> CreateTree(int depth)
    {
        if (depth == 0) { return null; }

        var root = new EduTreeNode<int>(1);
        var nodes = new List<EduTreeNode<int>> { root };

        for (int i = 1; i != depth + 1; i++)
        {
            var childNodes = new List<EduTreeNode<int>>();

            foreach (EduTreeNode<int> node in nodes)
            {
                node.left = new EduTreeNode<int>(2 * node.data);
                node.right = new EduTreeNode<int>(2 * node.data + 1);
                childNodes.Add(node.left);
                childNodes.Add(node.right);
            }

            nodes = childNodes;
        }

        return root;
    }
}
