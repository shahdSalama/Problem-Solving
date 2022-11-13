using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.HardChallenges
{
    class N_Queen
    {
            public static IList<IList<string>> SolveNQueens(int n)
            {
                IList<IList<string>> res = new List<IList<string>>();
                var posDiag = new HashSet<int>();
                var negDiag = new HashSet<int>();
                var cols = new HashSet<int>();
                List<List<string>> board = new List<List<string>>();
                for (int i = 0; i < n; i++)
                {
                    board.Add(new List<string>());
                    for (int j = 0; j < n; j++)
                    {
                        board[i].Add(".");
                    }
                }

                void backtrack(int rowNumber)
                {
                    // valid board
                    if (rowNumber == n)
                    {
                        var copy = new List<string>();
                        foreach (List<string> row in board)
                            copy.Add(string.Join("", row));
                        res.Add(copy);
                        return;
                    }
                    for (int col = 0; col < n; col++)
                    {
                        if (cols.Contains(col) || posDiag.Contains(rowNumber + col) || negDiag.Contains(rowNumber - col))
                            continue;

                        cols.Add(col);
                        posDiag.Add(rowNumber + col);
                        negDiag.Add(rowNumber - col);
                        board[rowNumber][col] = "Q";

                        backtrack(rowNumber + 1);

                        // clean up
                        cols.Remove(col);
                        posDiag.Remove(rowNumber + col);
                        negDiag.Remove(rowNumber - col);
                        board[rowNumber][col] = ".";

                    }
                }
                backtrack(0);
                return res;
            }
            
        }
    }
