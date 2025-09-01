// Design Tic-Tac-Toe
// ==================
//
// Suppose that two players are playing a tic-tac-toe game on an n × n board. They're following specific rules to play
// and win the game:
//
// - A move is guaranteed to be valid if a mark is placed on an empty block.
// - No more moves are allowed once a winning condition is reached.
// - A player who succeeds in placing n of their marks in a horizontal, vertical, or diagonal row wins the game.
//
// Implement a TicTacToe class, which will be used by two players to play the game and win fairly.
//
// Keep in mind the following functionalities that need to be implemented:
//
// - Constructor, the constructor, which initializes an object of `TicTacToe`, allowing the players to play on a board
//   of size n × n.
// - Move(row, col, player) indicates that the player with the ID, `player`, places their mark on the cell (`row`,
//   `col`). The move is guaranteed to be a valid move. At each move, this function returns the player ID if the current
//   player wins and returns 0 if no one wins.
//
// Constraints:
//
// - 2 ≤ n ≤ 9
// - `player` should be either `1` or `2`.
// - 0 ≤ `row`, `col` < n
// - Every call to `Move()` will be with a unique `row`, `col` combination.
// - The `Move()` function will be called at most n^2 times.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P03_DesignTicTacToe;

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
