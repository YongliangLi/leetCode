using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    public class Solution1A
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var board = CreateBoard(n);
            var ret = new List<IList<string>>();
            BackTracking(board, ret, -1, n);
            return ret;
        }

        private bool BackTracking(char[,] board, List<IList<string>> ret, int row, int remaining)
        {
            if (remaining == 0)
            {
                ret.Add(CharArraryToStringList(board));
                return false;
            }

            for (int r = row + 1; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    if (IsValid(board, r, c))
                    {
                        board[r, c] = 'Q';
                        if (!BackTracking(board, ret, r, remaining - 1))
                        {
                            board[r, c] = '.';
                        }
                    }
                }
            }
            return false;
        }

        private char[,] CreateBoard(int n)
        {
            var board = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = '.';
                }
            }
            return board;
        }

        private List<string> CharArraryToStringList(char[,] chars)
        {
            var list = new List<string>();
            for (var i = 0; i < chars.GetLength(0); i++)
            {
                var sb = new StringBuilder();
                for (var j = 0; j < chars.GetLength(1); j++)
                {
                    sb.Append(chars[i, j]);
                }
                list.Add(sb.ToString());
            }
            return list;
        }

        private bool IsValid(char[,] board, int r, int c)
        {
            //row            
            for (int i = 0; i < c; i++)
            {
                if (board[r, i] == 'Q') return false;
            }

            //column
            for (int i = 0; i <= r; i++)
            {
                if (board[i, c] == 'Q') return false;
            }

            //diagonal
            var r1 = r - 1;
            var c1 = c + 1;
            while (r1 >= 0 && c1 < board.GetLength(1))
            {
                if (board[r1, c1] == 'Q') return false;
                r1--;
                c1++;
            }
            r1 = r - 1;
            c1 = c - 1;
            while (r1 >= 0 && c1 >= 0)
            {
                if (board[r1, c1] == 'Q') return false;
                r1--;
                c1--;
            }

            return true;

        }
    }
}
