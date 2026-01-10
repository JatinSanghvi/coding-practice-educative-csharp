// Encode and Decode Strings
// =========================
//
// Create a method, `Encode`, that converts an array of strings into a single string and then sends it over the network.
// Create another method, `Decode`, that takes the encoded string and converts it back into the original array of
// strings.
//
// Constraints:
//
// - 1 <= `strings.length` <= 200
// - 0 <= `strings[i].length` <= 200
// - `strings[i]` consist of any possible combinations of characters from 256 valid ASCII characters.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P06_EncodeAndDecodeStrings;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static string Encode(List<string> strings)
    {
        var charList = new List<char>();

        foreach (string str in strings)
        {
            foreach (char ch in str)
            {
                if (ch == '\\' || ch == ',') { charList.Add('\\'); }
                charList.Add(ch);
            }

            charList.Add(',');
        }

        return new string(charList.ToArray());
    }

    // Time complexity: O(n), Space complexity: O(1).
    public static List<string> Decode(string str)
    {
        var strings = new List<string>();
        var charList = new List<char>();
        bool escapeChar = false;

        foreach (char ch in str)
        {
            if (escapeChar) { charList.Add(ch); escapeChar = false; }
            else if (ch == '\\') { escapeChar = true; }
            else if (ch == ',') { strings.Add(new string(charList.ToArray())); charList.Clear(); }
            else { charList.Add(ch); }
        }

        return strings;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([",,", "\\\\", "aa"]);
    }

    private static void Run(string[] strings)
    {
        string[] expectedResult = strings;
        string[] result = Solution.Decode(Solution.Encode(strings.ToList())).ToArray();
        Utilities.PrintSolution(strings, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
