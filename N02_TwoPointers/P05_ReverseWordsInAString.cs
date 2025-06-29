// Reverse Words in a String
// =========================
// 
// You are given a string, `sentence`, comprising words and leading or trailing spaces or multiple spaces between words.
// Your task is to reverse the order of its words without affecting the order of letters within the given word. Return
// the modified `sentence`.
// 
// > Note: A word is defined as a continuous sequence of non-space characters. Multiple words separated by single spaces
// form a valid English sentence. Therefore, ensure there is only a single space between any two words in the returned
// string, with no leading, trailing, or extra spaces.
// 
// Constraints:
// 
// - The `sentence` contains English uppercase and lowercase letters, digits, and spaces.
// - There is at least one word in a `sentence`.
// -1 ≤ `sentence.length` ≤ 10^4

using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P05_ReverseWordsInAString;

public class Solution
{
    public static string ReverseWords(string sentence)
    {
        var reversed = new StringBuilder();
        int length = sentence.Length;

        for (int start = length - 1, end = length; start >= -1; start--)
        {
            if (start == -1 || sentence[start] == ' ')
            {
                // If the spaces are not consecutive, it's a word to be appended.
                if (end != start + 1)
                {
                    if (reversed.Length > 0) { reversed.Append(' '); }
                    reversed.Append(sentence[(start + 1)..end]);
                }

                end = start; // Last encountered index of space character.
            }
        }

        return reversed.ToString();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("Hello  World", "World Hello");
        Run("  Hello  World  ", "World Hello");
    }

    private static void Run(string sentence, string expectedResult)
    {
        string result = Solution.ReverseWords(sentence);
        Utilities.PrintSolution(sentence, result);
        Assert.AreEqual(expectedResult, result);
    }
}
