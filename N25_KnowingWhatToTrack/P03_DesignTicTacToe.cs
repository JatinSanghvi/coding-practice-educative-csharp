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

// Space complexity: O(n).
public class TicTacToe
{
    private readonly int _n;
    private readonly int[] _rows;
    private readonly int[] _cols;
    private readonly int[] _diags;

    // Time complexity: O(n).
    public TicTacToe(int n)
    {
        _n = n;
        _rows = new int[n];
        _cols = new int[n];
        _diags = new int[2];
    }

    // Time complexity: O(1).
    public int Move(int row, int col, int player)
    {
        int sign = player == 1 ? 1 : -1;

        _rows[row] += sign;
        _cols[col] += sign;
        if (row == col) { _diags[0] += sign; }
        if (row == _n - 1 - col) { _diags[1] += sign; }

        if (_rows[row] == sign * _n || _cols[col] == sign * _n || _diags[0] == sign * _n || _diags[1] == sign * _n)
        {
            return player;
        }

        return 0;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(3, [(0, 0), (0, 1), (0, 2), (1, 0), (1, 1), (1, 2), (2, 0)]);
    }

    private static void Run(int n, (int, int)[] operations)
    {
        var ticTacToe = new TicTacToe(n);

        int row, col, player = 1;
        int result;
        for (int i = 0; i != operations.Length - 1; i++)
        {
            (row, col) = operations[i];
            result = ticTacToe.Move(row, col, player);
            Utilities.PrintSolution((row, col, player), result);
            Assert.AreEqual(0, result);
            player = 3 - player;
        }

        (row, col) = operations[^1];
        result = ticTacToe.Move(row, col, player);
        Utilities.PrintSolution((row, col, player), result);
        Assert.AreEqual(player, result);
    }
}
