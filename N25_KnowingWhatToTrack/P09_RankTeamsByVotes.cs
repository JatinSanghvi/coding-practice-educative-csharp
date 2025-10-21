// Rank Teams by Votes
// ===================
//
// Assume a ranking system where each gives a rank to all competing teams from highest to lowest. The final ranking is
// decided on the basis of the number of first-place votes they receive. If there's a tie for first place, the
// second-place votes are used to break the tie; if there's still a tie, the third-place votes are considered, and this
// continues until all positions have been evaluated. If teams remain tied after all positions have been reviewed, they
// are ranked alphabetically by their team names.
//
// Given an array of strings `votes` that represents the rankings given by all voters, sort the teams according to the
// specified ranking system and return a string that lists all the teams in the ranked order.
//
// Constraints:
//
// - 1 ≤ `votes.length` ≤ 1000
// - 1 ≤ `votes[i].length` ≤ 26
// - `votes[i].length` == `votes[j].length` for 0 ≤ `i, j` < `votes.length`
// - `votes[i][j]` is an uppercase English letter.
// - All characters of `votes[i]` are unique.
// - All characters present in `votes[0]` are also found in `votes[i]` where 1 ≤ `i` < `votes.length`.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P09_RankTeamsByVotes;

public class Solution
{
    // Time complexity: O(t*v+t^2*logt), Space complexity: O(t^2).
    public static string RankTeams(string[] votes)
    {
        int teamCount = votes[0].Length;
        var ranks = new Dictionary<char, int[]>();

        foreach (char team in votes[0])
        {
            ranks[team] = new int[teamCount];
        }

        foreach (string vote in votes)
        {
            for (int i = 0; i != vote.Length; i++)
            {
                char team = vote[i];
                ranks[team][i]++;
            }
        }

        char[] teams = ranks
            .Order(new RankCountComparer())
            .Select(pair => pair.Key)
            .ToArray();

        return new string(teams);
    }
}

internal class RankCountComparer : IComparer<KeyValuePair<char, int[]>>
{
    public int Compare(KeyValuePair<char, int[]> team1, KeyValuePair<char, int[]> team2)
    {
        for (int i = 0; i != team1.Value.Length; i++)
        {
            int count1 = team1.Value[i], count2 = team2.Value[i];
            if (count1 != count2) { return count2 - count1; }
        }

        return team1.Key - team2.Key;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["XYZ", "XZY", "YXZ"], "XYZ");
        Run(["XYZ", "YZX", "ZXY"], "XYZ");
        Run(["ABCDEFGH", "HGFEDCBA"], "AHBGCFDE");
    }

    private static void Run(string[] votes, string expectedResult)
    {
        string result = Solution.RankTeams(votes);
        Utilities.PrintSolution(votes, result);
        Assert.AreEqual(expectedResult, result);
    }
}
