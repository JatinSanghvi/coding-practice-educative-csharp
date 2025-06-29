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
        StringBuilder stringBuilder = new();

        int start = 0; // Probable start index of next word.

        for (int end = 0; end < sentence.Length + 1; end++)
        {
            if (end == sentence.Length || sentence[end] == ' ')
            {
                if (start != end)
                {
                    if (stringBuilder.Length != 0)
                    {
                        stringBuilder.Insert(0, ' ');
                    }

                    stringBuilder.Insert(0, sentence[start..end]);
                }

                start = end + 1;
            }
        }

        return stringBuilder.ToString();
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
