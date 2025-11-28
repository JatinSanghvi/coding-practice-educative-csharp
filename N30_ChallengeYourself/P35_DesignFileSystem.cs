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
// - 2 ≤ `path.length` ≤ 100
// - 1 ≤ value ≤ 10^9

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P35_DesignFileSystem;

public class FileSystem
{
    private readonly Dictionary<string, int> pathValues = new()
    {
        [""] = -1,
    };

    public bool CreatePath(string path, int value)
    {
        if (pathValues.ContainsKey(path)) { return false; }

        int index = path.LastIndexOf('/');
        string parent = path[..index];
        if (!pathValues.ContainsKey(parent)) { return false; }

        pathValues[path] = value;
        return true;
    }

    public int Get(string path)
    {
        return pathValues.GetValueOrDefault(path, -1);
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["create /x 1", "get /x"], [true, 1]);

        Run(
            ["create /a/b 2", "create /a 1", "create /a/b 2", "create /a/b 2", "get /a", "get /a/b", "get /b"],
            [false, true, true, false, 1, 2, -1]
        );
    }

    private static void Run(string[] operations, object[] expectedResults)
    {
        var fileSystem = new FileSystem();
        for (int i = 0; i != operations.Length; i++)
        {
            string operation = operations[i];
            string[] operands = operation.Split();

            switch (operands[0])
            {
                case "create":
                    {
                        var expectedResult = (bool)expectedResults[i];
                        bool result = fileSystem.CreatePath(operands[1], int.Parse(operands[2]));
                        Utilities.PrintSolution(operation, result);
                        Assert.AreEqual(expectedResult, result);
                    }
                    break;
                case "get":
                    {
                        var expectedResult = (int)expectedResults[i];
                        int result = fileSystem.Get(operands[1]);
                        Utilities.PrintSolution(operation, result);
                        Assert.AreEqual(expectedResult, result);
                    }
                    break;
            }
        }
    }
}
