// Find Duplicate File in System
// =============================
//
// Given a list of directory information named `paths`, where each directory contains file paths and their respective
// contents, identify all the duplicate files in the system based on their contents. Each duplicate group should contain
// at least two files with identical content, and the output should list these groups with the full paths of the
// duplicate files. Each entry in the input list is formatted as :
//
// `"root_directory/dir_1/dir_2/.../dir_m file_1.txt(file_1_content) file_2.txt(file_2_content) ...
// file_n.txt(file_n_content)"`
//
// The path above indicates that there are `n` files (file_1.txt, file_2.txt, ..., file_n.txt) with respective contents
// (file_1_content, file_2_content, ..., file_n_content) in the directory "root_directory/dir_1/dir_2/.../dir_m". The
// output should be a list of groups containing the paths of files sharing the same content. Each file path should
// follow the format given below:
//
// `"directory_path/file_name.txt".`
//
// The order of the groups or the paths within them does *not* matter.
//
// Constraints:
//
// - 1 ≤ `paths.length` ≤ 2 × 10^4
// - 1 ≤ `paths[i].length` ≤ 3000
// - 1 ≤ `sum(paths[i].length)` ≤ 5 × 10^5
// - `paths[i]` consist of English letters, digits, `'/'`, `'.'`, `'('`, `')'`, and `' '`.
// - You may assume that no files or directories share the same name in the same directory.
// - You may assume that each given directory info represents a unique directory. A single blank space separates the
//   directory path and file info.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P06_FindDuplicateFileInSystem;

public class Solution
{
    // Time complexity: O(n*(l+c)), Space complexity: O(n*(l+c)), where n = total files, l = path length, c = content length.
    public static IList<IList<string>> FindDuplicate(string[] paths)
    {
        var contentPaths = new Dictionary<string, List<string>>();

        foreach (string path in paths)
        {
            string[] segments = path.Split();
            for (int i = 1; i != segments.Length; i++)
            {
                int index = segments[i].IndexOf('(');
                string filePath = $"{segments[0]}/{segments[i][..index]}";
                string content = segments[i][(index + 1)..^1];
                Console.WriteLine($"{filePath}, {content}");
                contentPaths.TryAdd(content, new List<string>());
                contentPaths[content].Add(filePath);
            }
        }

        var duplicates = new List<IList<string>>();
        foreach (List<string> filePaths in contentPaths.Values)
        {
            if (filePaths.Count > 1)
            {
                duplicates.Add(filePaths);
            }
        }

        return duplicates;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            ["A/A 1.py(c1) 2.py(c2)", "A/B/A 3.py(c1)", "A/B 4.py(c2) 5.py(c3)"],
            [
                ["A/A/1.py", "A/B/A/3.py"],
                ["A/A/2.py", "A/B/4.py"]
            ]);
    }

    private static void Run(string[] paths, string[][] expectedResult)
    {
        string[][] result = Solution.FindDuplicate(paths).Select(group => group.ToArray()).ToArray();
        Utilities.PrintSolution(paths, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
