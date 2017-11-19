using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    /*
     The n-queens puzzle is the problem of placing n queens on an n×n chessboard such that no two queens attack each other.


    Given an integer n, return all distinct solutions to the n-queens puzzle.

    Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space respectively.

    For example,
    There exist two distinct solutions to the 4-queens puzzle:

    [
        [".Q..",  // Solution 1
        "...Q",
        "Q...",
        "..Q."],

        ["..Q.",  // Solution 2
        "Q...",
        "...Q",
        ".Q.."]
    ]
         */
    public class Solution1
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var board = CreateBoard(n);
            var ret = new List<IList<string>>();
            BackTracking(board, ret, -1,  n, n);
            return ret;
        }      

        private bool BackTracking(char[][] board, List<IList<string>> ret, int row, int remaining, int n)
        {
            if (remaining == 0)
            {
                ret.Add(CharArraryToString(board));
                return false;
            }

            for (int r = row+1; r < board.Length; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (IsValid(board, r, c, n))
                    {
                        board[r][c] = 'Q';
                        if (!BackTracking(board, ret, r, remaining - 1, n))
                        {
                            board[r][c] = '.';                            
                        }
                    }
                }
            }
            return false;
        }

        private char[][] CreateBoard(int n)
        {
            var board = new char[n][];
            for (int i = 0; i < n; i++)
            {
                var line = new char[n];
                for (int j = 0; j < n; j++)
                {
                    line[j] = '.';
                }
                board[i] = line;
            }
            return board;
        }

        private List<string> CharArraryToString(char[][] chars) {
            var list = new List<string>();
            foreach (var row in chars)
            {
                var s = new string(row);
                list.Add(s);
            }
            return list;
        }

        private bool IsValid(char[][] board, int r, int c, int n)
        {
            //row            
            for (int i = 0; i < c; i++) {
                if (board[r][i] == 'Q') return false;
            }

            //column
            for (int i = 0; i <= r; i++)
            {
                if (board[i][c] == 'Q') return false;
            }

            //diagonal
            var r1 = r - 1;
            var c1 = c + 1;
            while (r1 >= 0 && c1 < n)
            {
                if (board[r1][c1] == 'Q') return false;
                r1--;
                c1++;
            }
            r1 = r - 1;
            c1 = c - 1;
            while (r1 >= 0 && c1 >= 0)
            {
                if (board[r1][c1] == 'Q') return false;
                r1--;
                c1--;
            }

            return true;
        }
    }
}
