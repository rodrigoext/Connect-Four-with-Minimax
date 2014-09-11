using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four.Model
{
    class Utils
    {

        public static int CalculateHeuristic(int[][] state)
        {
            int heuristic = 0;

            int rows = 6;
            int cols = 7;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - 3; j++)
                {
                    if (state[i][j] == state[i][j + 1])
                        if (state[i][j] == state[i][j + 2])
                            if (state[i][j] == state[i][j + 3])
                                if (state[i][j] != 0)
                                {
                                    if (state[i][j] == 1)
                                        heuristic += 1;
                                    else
                                        heuristic += 2;
                                }
                }
            }

            for (int i = 0; i < rows - 3; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (state[i][j] == state[i + 1][j])
                        if (state[i][j] == state[i + 2][j])
                            if (state[i][j] == state[i + 3][j])
                                if (state[i][j] != 0)
                                {
                                    if (state[i][j] == 1)
                                        heuristic = 1;
                                    else
                                        heuristic = 2;
                                }
                }
            }

            for (int i = 0; i < rows - 3; i++)
            {
                for (int j = 0; j < cols - 3; j++)
                {
                    if (state[i][j] == state[i + 1][j + 1])
                        if (state[i][j] == state[i + 2][j + 2])
                            if (state[i][j] == state[i + 3][j + 3])
                                if (state[i][j] != 0)
                                {
                                    if (state[i][j] == 1)
                                        heuristic = 1;
                                    else
                                        heuristic = 2;
                                }
                }
            }

            for (int i = 3; i < rows; i++)
            {
                for (int j = 0; j < cols - 3; j++)
                {
                    if (state[i][j] == state[i - 1][j + 1])
                        if (state[i][j] == state[i - 2][j + 2])
                            if (state[i][j] == state[i - 3][j + 3])
                                if (state[i][j] != 0)
                                {
                                    if (state[i][j] == 1)
                                        heuristic = 1;
                                    else
                                        heuristic = 2;
                                }
                }
            }
            return heuristic;
        }

        public static int CkeckIfWin(int[][] state)
        {
            int win = 0;

            int rows = 6;
            int cols = 7;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - 3; j++)
                {
                    if (state[i][j] == state[i][j + 1])
                        if (state[i][j] == state[i][j + 2])
                            if (state[i][j] == state[i][j + 3])
                                if (state[i][j] != 0)
                                {
                                    if (state[i][j] == 1)
                                        win = 1;
                                    else
                                        win = 2;
                                }
                }
            }

            for (int i = 0; i < rows - 3; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (state[i][j] == state[i + 1][j])
                        if (state[i][j] == state[i + 2][j])
                            if (state[i][j] == state[i + 3][j])
                                if (state[i][j] != 0)
                                {
                                    if (state[i][j] == 1)
                                        win = 1;
                                    else
                                        win = 2;
                                }
                }
            }

            for (int i = 0; i < rows - 3; i++)
            {
                for (int j = 0; j < cols - 3; j++)
                {
                    if (state[i][j] == state[i + 1][j + 1])
                        if (state[i][j] == state[i + 2][j + 2])
                            if (state[i][j] == state[i + 3][j + 3])
                                if (state[i][j] != 0)
                                {
                                    if (state[i][j] == 1)
                                        win = 1;
                                    else
                                        win = 2;
                                }
                }
            }

            for (int i = 3; i < rows; i++)
            {
                for (int j = 0; j < cols - 3; j++)
                {
                    if (state[i][j] == state[i - 1][j + 1])
                        if (state[i][j] == state[i - 2][j + 2])
                            if (state[i][j] == state[i - 3][j + 3])
                                if (state[i][j] != 0)
                                {
                                    if (state[i][j] == 1)
                                        win = 1;
                                    else
                                        win = 2;
                                }
                }
            }
            return win;
        }

        public static bool LegalMove(int[][] state, int row, int col)
        {
            int r = state.Length;
            int c = state[0].Length;

            if (row < r && col < c)
            {
                if (row >= 0 && col >= 0)
                {
                    if (state[row][col] == 0)
                    {
                        if (row == r - 1)
                            return true;
                        if (state[row + 1][col] != 0)
                            return true;
                    }
                }
            }
            return false;
        }


    }
}
