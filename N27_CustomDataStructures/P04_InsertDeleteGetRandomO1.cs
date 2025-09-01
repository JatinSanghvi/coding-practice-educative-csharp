// Insert Delete GetRandom O(1)
// ============================
//
// Implement a Random Set data structure that can perform the following operations:
//
// - Constructor(): This initializes the Random Set object.
//
// - Insert(): This function takes an integer, data, as its parameter and, if it does not already exist in the set, add
//   it to the set, returning TRUE. If the integer already exists in the set, the function returns FALSE.
//
// - Delete(): This function takes an integer, data, as its parameter and, if it exists in the set, removes it,
//   returning TRUE. If the integer does not exist in the set, the function returns FALSE.
//
// - GetRandom(): This function takes no parameters. It returns an integer chosen at random from the set.
//
// > Note: Your implementation should aim to have a running time of O(1) (on average) for each operation.
//
// Constraints:
//
// - -2^31 ≤ data ≤ 2^31
// - No more than 2 × 10^5 calls will be made to the Insert(), Delete() and GetRandom() functions.
// - There will be at least one element in the data structure when the GetRandom() function is called.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P04_InsertDeleteGetRandomO1;

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
