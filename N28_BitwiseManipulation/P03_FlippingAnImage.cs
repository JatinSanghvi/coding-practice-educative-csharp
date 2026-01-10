// Flipping an Image
// =================
//
// Given that an image is represented by an (n × n) matrix containing 0s and 1s, flip and invert the image, and return
// the resultant image.
//
// Horizontally flipping an image means that the mirror image of the matrix should be returned. Flipping [1,0,0]
// horizontally results in [0,0,1].
//
// Inverting an image means that every 0 is replaced by 1, and every 1 is replaced by 0. Inverting [0,1,1] results in
// [1,0,0].
//
// Constraints:
//
// - Image should be a square matrix.
// - 1 ≤ n ≤ 20
// - `images[i][j]` is either 0 or 1.

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P03_FlippingAnImage;

public class Solution
{
    // Time complexity: O(n^2), Space complexity: O(1).
    public static int[][] FlipAndInvertImage(int[][] image)
    {
        foreach (int[] row in image)
        {
            for (int i1 = 0, i2 = row.Length - 1; i1 <= i2; i1++, i2--)
            {
                (row[i1], row[i2]) = (1 - row[i2], 1 - row[i1]);
            }
        }

        return image;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[0, 0, 0], [0, 0, 1]], [[1, 1, 1], [0, 1, 1]]);
    }

    private static void Run(int[][] image, int[][] expectedResult)
    {
        int[][] imageCopy = image.Select(row => row.ToArray()).ToArray();
        int[][] result = Solution.FlipAndInvertImage(image);
        Utilities.PrintSolution(imageCopy, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
