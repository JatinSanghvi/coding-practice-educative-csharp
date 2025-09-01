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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P06_EncodeAndDecodeStrings;

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
