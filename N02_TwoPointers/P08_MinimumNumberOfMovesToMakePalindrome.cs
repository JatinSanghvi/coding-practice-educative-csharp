// Minimum Number of Moves to Make Palindrome
// ==========================================
//
// Given a string `s`, return the minimum number of moves required to transform `s` into a palindrome. In each move, you
// can swap any two adjacent characters in `s`.
//
// > Note: The input string is guaranteed to be convertible into a palindrome.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 2000
// - `s` consists of only lowercase English letters.
// - `s` is guaranteed to be converted into a palindrome in a finite number of moves.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P08_MinimumNumberOfMovesToMakePalindrome;

public class Solution
{
    // Time complexity: O(n^2), Space complexity: O(n).
    public int MinMovesToMakePalindrome(string s)
    {
        int moves = 0;
        char[] chars = s.ToCharArray();

        for (int left = 0, right = s.Length - 1; left < right; right--)
        {
            int match;
            for (match = left; chars[match] != chars[right]; match++) ;

            if (match == right)
            {
                // Number of moves required to shift the unmatched character to middle.
                moves += right - (chars.Length / 2);
            }
            else
            {
                moves += match - left;

                // Move characters from left to (match-1) one position to the right.
                for (; match > left; match--)
                {
                    chars[match] = chars[match - 1];
                }

                left++;
            }
        }

        return moves;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("mmmaaabbbba", 16);
    }

    private static void Run(string s, int expectedMoves)
    {
        int moves = new Solution().MinMovesToMakePalindrome(s);
        Utilities.PrintSolution(s, moves);
        Assert.AreEqual(expectedMoves, moves);
    }
}
