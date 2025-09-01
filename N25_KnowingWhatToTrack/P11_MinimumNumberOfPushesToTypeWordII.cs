// Minimum Number of Pushes to Type Word II
// ========================================
//
// The keys (numbered 2 to 9) on a telephone keypad are associated with specific groups of lowercase English letters.
// Below is an example of how letters can be mapped to keys on a telephone keypad.
//
// Press+to interact
//
// ![](data:image/svg+xml,%3csvg%20xmlns=%27http://www.w3.org/2000/svg%27%20version=%271.1%27%20width=%27200%27%20height=%27353%27/%3e)![](https://www.educative.io/api/collection/10370001/6349081334775808/page/6458122556538880/image/6095110578503680?page_type=collection_lesson&get_optimised=true&collection_token=xTuSSiuwTp0dI8ow69aP99)
//
// > Note: The keys 1, ∗, 0, and # do not map to any letters.
//
// In the above mapping, the key 2 is mapped with letters ["a", "b", "c"]; pressing it once types "a", pressing it twice
// types "b", and pressing it three times types "c".
//
// Any mapping is possible as long as each letter is assigned to exactly one key, and keys can be mapped to any number
// of distinct letters.
//
// Given a string, `word`, consisting of lowercase English letters, return the minimum number of pushes needed to type
// it after remapping the keys.
//
// > Note: No mapping is provided in the input. You can devise any mapping if needed.
//
// Constraints:
//
// - 1 ≤ `word.length` ≤ 10^3
// - `word` consists of only lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P11_MinimumNumberOfPushesToTypeWordII;

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
