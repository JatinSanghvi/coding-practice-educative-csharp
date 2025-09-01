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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P03_SerializeAndDeserializeBinaryTree;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
