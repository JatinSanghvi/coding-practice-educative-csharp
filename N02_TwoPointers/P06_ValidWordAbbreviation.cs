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
        int wordIndex = 0;
        int abbrIndex = 0;

        while (wordIndex < word.Length && abbrIndex < abbr.Length)
        {
            if (abbr[abbrIndex] == '0')
            {
                return false;
            }
            else if (char.IsLetter(abbr[abbrIndex]))
            {
                if (abbr[abbrIndex] != word[wordIndex])
                {
                    return false;
                }

                wordIndex += 1;
                abbrIndex += 1;
            }
            else
            {
                int distance = 0;
                while (abbrIndex < abbr.Length && char.IsDigit(abbr[abbrIndex]))
                {
                    distance = distance * 10 + (abbr[abbrIndex] - '0');
                    abbrIndex += 1;
                }

                wordIndex += distance;
            }
        }

        return wordIndex == word.Length && abbrIndex == abbr.Length;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Assert.IsTrue(Solution.ValidWordAbbreviation("calendar", "cal3ar"));
        Assert.IsTrue(Solution.ValidWordAbbreviation("calendar", "c6r"));
        Assert.IsFalse(Solution.ValidWordAbbreviation("calendar", "c06r"));
        Assert.IsFalse(Solution.ValidWordAbbreviation("calendar", "cale0ndar"));
        Assert.IsFalse(Solution.ValidWordAbbreviation("calendar", "c24r"));
    }
}
