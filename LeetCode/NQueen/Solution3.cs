using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    public class Solution3
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            int[,] board = new int[n, n];
            IList<IList<string>> solutions = new List<IList<string>>();

            int j = 0;
            int i = 0;

            // Begin outer loop
            while (i <= n - 1 && i >= 0)
            {
                bool isPlaced = false;

                // Begin inner loop
                for (; j <= n - 1 && j >= 0; j++)
                {
                    if (!isAttacked(i, j, board, n))
                    {
                        board[i, j] = 1;
                        isPlaced = true;
                        break;
                    }
                }
                // end inner loop

                // backtrack
                if (!isPlaced)
                {
                    i = i - 1;

                    while (i >= 0)
                    {
                        j = FindNextColumnIdx(i, board, n);

                        if (j > n - 1)
                        {
                            i--;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (i < 0)
                    {
                        return solutions;
                    }
                }


                else if (isPlaced && i == n - 1)
                {
                    SaveCurrentSln(j, board, n, solutions);
                    j++;
                }

                // placed on this row..so go to next row.
                else
                {
                    i++;
                    j = 0;
                }
            } // end outer loop

            return solutions;
        }



        private static bool isAttacked(int row, int column, int[,] board, int n)
        {

            // check current column
            for (int i = 0; i <= n - 1; i++)
            {
                if (board[i, column] == 1)
                {
                    return true;
                }
            }
            // check upper left diagonal
            int ii = row - 1;
            int jj = column - 1;
            while (ii <= n - 1 && jj <= n - 1 && ii >= 0 && jj >= 0)
            {
                if (board[ii, jj] == 1)
                {
                    return true;
                }
                ii--; jj--;
            }
            // check upper right diagonal
            ii = row - 1;
            jj = column + 1;
            while (ii <= n - 1 && jj <= n - 1 && ii >= 0 && jj >= 0)
            {
                if (board[ii, jj] == 1)
                {
                    return true;
                }
                ii--; jj++;
            }

            // check lower right diagonal
            ii = row + 1;
            jj = column + 1;
            while (ii <= n - 1 && jj <= n - 1 && ii >= 0 && jj >= 0)
            {
                if (board[ii, jj] == 1)
                {
                    return true;
                }
                ii++; jj++;
            }

            // check lower left diagonal
            ii = row + 1;
            jj = column - 1;
            while (ii <= n - 1 && jj <= n - 1 && ii >= 0 && jj >= 0)
            {
                if (board[ii, jj] == 1)
                {
                    return true;
                }
                ii++; jj--;
            }

            return false;
        }

        private static int FindNextColumnIdx(int row, int[,] board, int n)
        {
            // remove queen from current column
            for (int j = 0; j <= n - 1; j++)
            {
                if (board[row, j] == 1)
                {
                    board[row, j] = 0;
                    /*if (j < n-1)
                    {
                        board[row, j++] = 1;
                    }*/

                    return j + 1;
                }
            }

            return n;

            // place queen in next colum
        }

        private static void SaveCurrentSln(int column, int[,] board, int n, IList<IList<string>> solutions)
        {
            IList<string> sln = new List<string>();
            for (int i = 0; i <= n - 1; i++)
            {
                StringBuilder slnRow = new StringBuilder();
                for (int j = 0; j <= n - 1; j++)
                {
                    if (board[i, j] == 1)
                    {
                        slnRow.Append("Q");
                    }
                    else
                    {
                        slnRow.Append(".");
                    }
                }

                sln.Add(slnRow.ToString());
            }

            solutions.Add(sln);
            board[n - 1, column] = 0;
        }

    }
}
