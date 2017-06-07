using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    public class Solution2
    {

        private List<string> SerializeBoard(int n, bool[,] board)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                StringBuilder builder = new StringBuilder();
                for (int j = 0; j < n; j++)
                {
                    builder.Append(board[i, j] ? 'Q' : '.');
                }

                list.Add(builder.ToString());
            }

            return list;
        }

        private bool CanPlaceQueen(int n, bool[,] board, int row, int col)
        {
            for (int i = 0; i < n; i++)
            {
                if (board[i, col])
                {
                    return false;
                }
            }

            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j])
                {
                    return false;
                }
            }

            for (int i = row, j = col; i >= 0 && j < n; i--, j++)
            {
                if (board[i, j])
                {
                    return false;
                }
            }

            for (int i = row, j = col; i < n && j >= 0; i++, j--)
            {
                if (board[i, j])
                {
                    return false;
                }
            }

            for (int i = row, j = col; i < n && j < n; i++, j++)
            {
                if (board[i, j])
                {
                    return false;
                }
            }
            return true;
        }

        private void SolveQueens(int n, int queens, bool[,] board, List<IList<string>> solvedBoards)
        {
            if (queens == n)
            {
                solvedBoards.Add(SerializeBoard(n, board));
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!CanPlaceQueen(n, board, queens, i))
                    {
                        continue;
                    }

                    board[queens, i] = true;
                    SolveQueens(n, queens + 1, board, solvedBoards);
                    board[queens, i] = false;
                }
            }
        }
        public IList<IList<string>> SolveNQueens(int n)
        {
            List<IList<string>> solvedBoards = new List<IList<string>>();
            SolveQueens(n, 0, new bool[n, n], solvedBoards);

            return solvedBoards;
        }
    }
}
