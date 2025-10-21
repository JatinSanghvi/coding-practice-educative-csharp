// Count Anagrams
// ==============
//
// You are given a string, `s`, containing one or more words separated by a single space. Your task is to count and
// return the number of distinct anagrams of the entire string `s`. As the answer may be very large, return it modulo
// 10^9 + 7, i.e., return the remainder when the answer is divided by 10^9 + 7.
//
// > Note: An anagram is a word formed by rearranging the letters of another word, using all the original letters
// > exactly once. For example, "listen" is an anagram of "silent". Similarly, a string `t` is an anagram of string `s`
// > if the `i``th` word of `t` is a permutation of the `i``th` word of `s`. For example, "silent era" is an anagram of
// > "listen ear", but "sline tear" is not.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^3
// - `s` consists of lowercase English letters and spaces `' '`.
// - There is only a single space between consecutive words.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P13_CountAnagrams;

public class Solution
{
    private const int Mod = 1_000_000_007;
    private const int MaxLength = 1000;

    private static readonly long[] factorials = new long[MaxLength + 1];
    private static readonly long[] invFactorials = new long[MaxLength + 1];

    // Time complexity: O(max-len), Space complexity: O(max-len).
    static Solution()
    {
        factorials[0] = 1;
        for (long i = 1; i != factorials.Length; i++)
        {
            factorials[i] = (i * factorials[i - 1]) % Mod;
        }

        invFactorials[^1] = ModularReciprocal(factorials[^1]);
        for (long i = invFactorials.Length - 2; i != -1; i--)
        {
            invFactorials[i] = ((i + 1) * invFactorials[i + 1]) % Mod;
        }
    }

    public static long ModularReciprocal(long num)
    {
        long result = 1;
        long multiplier = num;

        // Fermats little theorem: a^(p-1) % p == 1 if p is prime. Therefore, a^(p-2) % p = a^(-1).
        for (int power = Mod - 2; power != 0; power /= 2)
        {
            // Computing modular exponentiation by squaring technique.
            if (power % 2 != 0)
            {
                result = (result * multiplier) % Mod;
            }

            multiplier = (multiplier * multiplier) % Mod;
        }

        return result;
    }

    // Time complexity: O(n), Space complexity: O(1).
    public static int CountAnagrams(string s)
    {
        long allAnagrams = 1;
        foreach (string word in s.Split())
        {
            var counts = new int[26];
            foreach (char letter in word)
            {
                counts[letter - 'a']++;
            }

            long anagrams = factorials[word.Length];
            foreach (int count in counts)
            {
                anagrams = (anagrams * invFactorials[count]) % Mod;
            }

            allAnagrams = (allAnagrams * anagrams) % Mod;
        }

        return (int)allAnagrams;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abcd aabc aabb aaab aaaa", 6912); // 24 * 12 * 6 * 4 * 1
    }

    private static void Run(string s, int expectedResult)
    {
        int result = Solution.CountAnagrams(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
