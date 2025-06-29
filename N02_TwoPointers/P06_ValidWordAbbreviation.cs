// Valid Word Abbreviation
// =======================
// 
// Given a string `word` and an abbreviation `abbr`, return TRUE if the abbreviation matches the given string.
// Otherwise, return FALSE.
// 
// A certain word `"calendar"` can be abbreviated as follows:
// - `"cal3ar"` (`"cal ``end`` ar"` skipping three characters `"end"` from the word `"calendar"` still matches the
//   provided abbreviation)
// - `"c6r"` (`"c ``alenda`` r"` skipping six characters `"alenda"` from the word `"calendar"` still matches the
//   provided abbreviation)
// 
// The word `"internationalization"` can also be abbreviated as `"i18n"` (the abbreviation comes from skipping 18
// characters in `"internationalization"`, leaving the first and last letters `"i"` and `"n"`).
// 
// The following are *not* valid abbreviations:
// - `"c06r"` (has leading zeroes)
// - `"cale0ndar"` (replaces an empty string)
// - `"c24r"` (`"c ``al``enda`` r"` the replaced substrings are adjacent)
// 
// Constraints:
// 
// - 1 ≤ `word.length` ≤ 20
// - `word` consists of only lowercase English letters.
// - 1 ≤ `abbr.length` ≤ 10
// - `abbr` consists of lowercase English letters and digits.
// - All the integers in `abbr` will fit in a 32-bit integer.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P06_ValidWordAbbreviation;

public class Solution
{
    public static bool ValidWordAbbreviation(string word, string abbr)
    {
        int abbrIndex = 0;
        int wordIndex = 0;

        while (abbrIndex < abbr.Length && wordIndex < word.Length)
        {
            if (abbr[abbrIndex] == '0')
            {
                return false;
            }
            else if (abbr[abbrIndex] >= 'a' && abbr[abbrIndex] <= 'z')
            {
                if (word[wordIndex] != abbr[abbrIndex])
                {
                    return false;
                }

                abbrIndex++;
                wordIndex++;
            }
            else
            {
                int length = 0;
                while (abbrIndex < abbr.Length && abbr[abbrIndex] >= '0' && abbr[abbrIndex] <= '9')
                {
                    length = length * 10 + (abbr[abbrIndex] - '0');
                    abbrIndex++;
                }

                wordIndex += length;
            }
        }

        return abbrIndex == abbr.Length && wordIndex == word.Length;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("calendar", "cal3ar", true);
        Run("calendar", "c6r", true);
        Run("calendar", "c06r", false);
        Run("calendar", "cale0ndar", false);
        Run("calendar", "c24r", false);
    }

    private static void Run(string word, string abbr, bool expectedResult)
    {
        bool result = Solution.ValidWordAbbreviation(word, abbr);
        Utilities.PrintSolution((word, abbr), result);
        Assert.AreEqual(expectedResult, result);
    }
}
