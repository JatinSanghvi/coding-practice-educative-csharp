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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P09_RankTeamsByVotes;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
