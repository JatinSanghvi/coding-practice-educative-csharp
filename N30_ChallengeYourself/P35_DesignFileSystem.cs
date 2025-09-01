// Design File System
// ==================
//
// Design a file system that allows us to create new paths and associate them with different values. A path has one or
// more concatenated strings of the form `/` followed by one or more lowercase English letters. For example, valid paths
// include `"/educative"` and `"/educative/problems"`, while an empty string `""` and `"/"` are not valid paths.
//
// Implement the FileSystem class with the following functions:
//
// - bool createPath(string path, int value): This function creates a new path and associates a value to it if possible
//   and returns TRUE. It returns FALSE if the path already exists or if its parent path doesn't exist.
//
// - int get(string path): This function returns the value associated with the path or returns -1 if the path doesn't
//   exist.
//
// Constraints:
//
// - The total number of calls to the two functions are ≤ 104.
// - 2≤ `path.length` ≤100
// - 1≤ value ≤109

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P35_DesignFileSystem;

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
