// Design In-Memory File System
// ============================
//
// Design an in-memory file system. The skeleton for the class FileSystem is provided to you. Simulate the following
// functions:
//
// - ls(String path): If path is a file path, return a list that only contains the file's name. If it's a directory
//   path, return the list of files and directory names in this directory. Your function should return the output (file
//   and directory names together) in lexicographical order.
//
// - Void mkdir(String path): If the given path does not exist, make a new directory according to it. The function
//   should create all the middle directories in the path if they don't exist.
//
// - Void addContentToFile(String filePath, String content): If the file doesn't exist, create that file containing the
//   given content. If the file already exists, append the given content to the original content.
//
// - Void readContentFromFile(String filePath): Return given file's content in string format.
//
// > Note: You may assume that all directory names and file names only contain lowercase letters, and the same names
// > will not exist in the same directory. Additionally, you may assume that all operations will be passed valid
// > parameters, and an attempt to retrieve file content or list a directory or file that does not exist is not allowed.
//
// Constraints:
//
// - 1 ≤ `path.length`, `filePath.length` ≤ 100
//
// - `path` and `filePath` are absolute paths that begin with "/" and do not end with "/" except that the path is just
//   "/".
//
// - 1≤ `content.length` ≤50
//
// - At most 300 calls will be made to ls, mkdir, addContentToFile, and readContentFromFile.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P34_DesignInMemoryFileSystem;

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
