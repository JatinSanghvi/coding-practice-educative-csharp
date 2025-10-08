// Compilation Order
// =================
//
// There are a total of n classes labeled with the English alphabet (A, B, C, and so on). Some classes are dependent on
// other classes for compilation. For example, if class B extends class A, then B has a dependency on A. Therefore, A
// must be compiled before B.
//
// Given a list of the dependency pairs, find the order in which the classes should be compiled.
//
// Constraints:
//
// - Class name should be an uppercase character.
// - 0 ≤ `dependencies.length` ≤ 676
// - `dependencies[i].length` == 2
// - All dependency pairs should be unique.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N16_TopologicalSort.P01_CompilationOrder;

public class Solution
{
    // Time complexity: O(V+E), Space complexity: O(V+E).
    public static List<char> FindCompilationOrder(List<List<char>> dependencies)
    {
        var graph = new Dictionary<char, List<char>>();
        var inDegrees = new Dictionary<char, int>();

        foreach (List<char> dependency in dependencies)
        {
            char child = dependency[0], parent = dependency[1];

            graph.TryAdd(parent, new List<char>());
            graph.TryAdd(child, new List<char>());
            graph[parent].Add(child);

            inDegrees.TryAdd(parent, 0);
            inDegrees.TryAdd(child, 0);
            inDegrees[child]++;
        }

        var queue = new Queue<char>();
        foreach ((char node, int degree) in inDegrees)
        {
            if (degree == 0)
            {
                queue.Enqueue(node);
            }
        }

        var order = new List<char>();
        while (queue.Count != 0)
        {
            char parent = queue.Dequeue();
            order.Add(parent);

            foreach (char child in graph[parent])
            {
                inDegrees[child]--;
                if (inDegrees[child] == 0)
                {
                    queue.Enqueue(child);
                }
            }
        }

        return order.Count == inDegrees.Count ? order : new List<char>();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([['B', 'A'], ['C', 'A'], ['C', 'B'], ['D', 'C'], ['D', 'B'], ['E', 'B'], ['E', 'D']], ['A', 'B', 'C', 'D', 'E']);
    }

    private static void Run(char[][] dependencyArray, char[] expectedResult)
    {
        List<List<char>> dependencies = dependencyArray.Select(d => d.ToList()).ToList();
        char[] result = Solution.FindCompilationOrder(dependencies).ToArray();
        Utilities.PrintSolution(dependencies, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
