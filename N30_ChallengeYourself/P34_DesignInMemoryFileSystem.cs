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
// - `path` and `filePath` are absolute paths that begin with "/" and do not end with "/" except that the path is just
//   "/".
// - 1 ≤ `content.length` ≤ 50
// - At most 300 calls will be made to ls, mkdir, addContentToFile, and readContentFromFile.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P34_DesignInMemoryFileSystem;

public class Item
{
    public SortedDictionary<string, Item> Children { get; } = new();
    public List<string> Contents { get; } = new();
}

public class FileSystem
{
    private readonly Item root = new();

    public List<string> ls(string path)
    {
        return GetItem(path).Children.Keys.ToList();
    }

    public void mkdir(string path)
    {
        GetItem(path);
    }

    public void addContentToFile(string filePath, string content)
    {
        GetItem(filePath).Contents.Add(content);
    }

    public string readContentFromFile(string filePath)
    {
        return string.Join("", GetItem(filePath).Contents);
    }

    private Item GetItem(string path)
    {
        string[] segments = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        Item item = root;
        foreach (string segment in segments)
        {
            if (!item.Children.TryGetValue(segment, out Item child))
            {
                child = item.Children[segment] = new Item();
            }

            item = child;
        }

        return item;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            ["ls /", "mkdir /a/b", "mkdir /a/c/c", "mkdir /a/b/c", "ls /a", "add /a/b/c/d d1", "read /a/b/c/d", "add /a/b/c/d d2", "read /a/b/c/d", "add /a/b/c/e e1", "read /a/b/c/e"],
            [Array.Empty<string>(), null, null, null, new string[] { "b", "c" }, null, "d1", null, "d1d2", null, "e1"]
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
                case "ls":
                    {
                        var expectedResult = (string[])expectedResults[i];
                        List<string> result = fileSystem.ls(operands[1]);
                        Utilities.PrintSolution(operation, result);
                        CollectionAssert.AreEqual(expectedResult, result);
                    }
                    break;
                case "mkdir":
                    {
                        object result = null;
                        fileSystem.mkdir(operands[1]);
                        Utilities.PrintSolution(operation, result);
                    }
                    fileSystem.mkdir(operands[1]);
                    break;
                case "add":
                    {
                        object result = null;
                        fileSystem.addContentToFile(operands[1], operands[2]);
                        Utilities.PrintSolution(operation, result);
                    }
                    break;
                case "read":
                    {
                        var expectedResult = (string)expectedResults[i];
                        string result = fileSystem.readContentFromFile(operands[1]);
                        Utilities.PrintSolution(operation, result);
                        Assert.AreEqual(expectedResult, result);
                    }

                    break;
            }
        }
    }
}
