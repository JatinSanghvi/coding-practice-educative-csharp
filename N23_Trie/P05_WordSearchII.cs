// Word Search II
// ==============
//
// You are given a list of strings that you need to find in a 2D grid of letters such that the string can be constructed
// from letters in sequentially adjacent cells. The cells are considered sequentially adjacent when they are neighbors
// to each other either horizontally or vertically. The solution should return a list containing the strings from the
// input list that were found in the grid.
//
// Constraints:
//
// - 1 ≤ rows, columns ≤ 12
// - 1 ≤ `words.length` ≤ 3×10^3
// - 1 ≤ `words[i].length` ≤ 10
// - `grid[i][j]` is an uppercase English letter.
// - `words[i]` consists of uppercase English letters.
// - All the strings are unique.
//
// > Note: The order of the strings in the output does *not* matter.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P05_WordSearchII;

public class Solution
{
    private class TrieNode
    {
        public bool isLeaf;
        public TrieNode[] children = new TrieNode[26];
    }

    // Time complexity: O(r*c*l), Space complexity: O(l) where l = sum of letters across all words.
    public static IList<string> FindStrings(char[][] grid, string[] words)
    {
        var root = new TrieNode();

        // Construct trie.
        foreach (string word in words)
        {
            TrieNode node = root;
            foreach (char ch in word)
            {
                node = node.children[ch - 'A'] ??= new TrieNode();
            }

            node.isLeaf = true;
        }

        int rows = grid.Length;
        int cols = grid[0].Length;

        var visited = new HashSet<(int, int)>(10);
        var chars = new List<char>(10);
        var strings = new HashSet<string>();

        for (int row = 0; row != rows; row++)
        {
            for (int col = 0; col != cols; col++)
            {
                Visit(row, col, root);
            }
        }

        return strings.ToList();

        void Visit(int row, int col, TrieNode node)
        {
            if (row == -1 || row == rows || col == -1 || col == cols || visited.Contains((row, col)))
            {
                return;
            }

            var childNode = node.children[grid[row][col] - 'A'];
            if (childNode != null)
            {
                visited.Add((row, col));
                chars.Add(grid[row][col]);

                if (childNode.isLeaf)
                {
                    strings.Add(string.Concat(chars));
                }

                Visit(row - 1, col, childNode);
                Visit(row + 1, col, childNode);
                Visit(row, col - 1, childNode);
                Visit(row, col + 1, childNode);

                visited.Remove((row, col));
                chars.RemoveAt(chars.Count - 1);
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([['A', 'B', 'C'], ['A', 'B', 'C']], ["AABBCC", "ABCCBA", "AC", "B", "BB", "BBB"], ["AABBCC", "ABCCBA", "B", "BB"]);
    }

    private static void Run(char[][] grid, string[] words, string[] expectedResult)
    {
        string[] result = Solution.FindStrings(grid, words).ToArray();
        Utilities.PrintSolution((grid, words), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
