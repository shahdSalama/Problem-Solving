using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Easy
{
    class TicTakToe
    {
        public static string Tictactoe(int[][] moves)
        {
            char c = 'X';
            var board = new char[3, 3];
            foreach (var move in moves)
            {
                int row = move[0]; int col = move[1];
                board[row, col] = c;
                // check if player is winner
                bool rwinner = true;
                bool cwinner = true;
                bool dlwinner = true;
                bool drwinner = true;

                for (int i = 0; i < 3; i++)
                {
                    if (board[row, i] != c) rwinner = false;
                    if (board[i, col] != c) cwinner = false;
                    if (board[i, i] != c) dlwinner = false;
                    if (board[i, 3 - 1 - i] != c) drwinner = false;
                }
                if (rwinner || cwinner || dlwinner || drwinner) return GetWinner(c);
                if (c == 'X') c = 'O';
                if (c == 'O') c = 'X';
            }
            if (moves.Length == 9) return "Draw";
            else return "Pending";

        }
        static string GetWinner(char c)
        {
            if (c == 'X') return "A";
            return "B";
        }
       

    }
}
