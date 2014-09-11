using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four.Model
{
    sealed class Node
    {
        private bool _terminal = false;
        public int _heuristic = 0;
        public bool _human;
        public int _score;
        private List<Node> _children = new List<Node>();
        private int[][] _state;
        public int RecursiveScore
        {
            get;
            private set;
        }
        public bool GameOver
        {
            get;
            private set;
        }

        public Node(int[][] state, bool human)
        {
            _human = human;
            _state = state;
            _score = Utility();
        }

        public bool IsHuman()
        {
            return _human;
        }

        public int Minimax(out Node node, int alpha, int beta, int depth, bool needMax)
        {
            node = null;
            System.Diagnostics.Debug.Assert(_human == needMax);
            if (depth == 0 || _terminal)
            {
                RecursiveScore = _score;
                return _score;
            }

            foreach (Node child in getChildren())
            {
                Node chil = null;

                int score = child.Minimax(out chil, alpha, beta, depth-1, !needMax);

                if (!needMax)
                {
                    if (beta > score)
                    {
                        beta = score;
                        node = child;
                        if (alpha >= beta)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    if (alpha < score)
                    {
                        alpha = score;
                        node = child;
                        if (alpha >= beta)
                        {
                            break;
                        }
                    }
                }
            }

            RecursiveScore = needMax ? alpha : beta;
            return RecursiveScore;
        }

        public Node FindNextMove(int depth)
        {
            Node node = null;
            Minimax(out node, int.MinValue + 1, int.MaxValue - 1, depth, _human);

            return node;
        }

        public IEnumerable<Node> getChildren()
        {
            for (int i = 0; i < _state.Length; i++)
            {
                for (int j = 0; j < _state[0].Length; j++)
                {
                    if (Utils.LegalMove(_state, i, j) == true)
                    {
                        int[][] newstate = new int[_state.Length][];

                        for (int a = 0; a < newstate.Length; a++)
                        {
                            newstate[a] = new int[7];
                            for (int b = 0; b < newstate[a].Length; b++)
                            {
                                newstate[a][b] = _state[a][b];
                            }
                        }
                        newstate[i][j] = _human ? 1 : 2;
                        yield return new Node(newstate, !_human);
                    }
                }
            }
        }
        
        public void setTerminal(bool isTerminal)
        {
            _terminal = isTerminal;
        }

        public int[][] GetState()
        {
            return _state;
        }

        public void setState(int[][] state)
        {
            _state = state;
        }

        public void setMove(int row, int col)
        {
            _state[row][col] = 1;
        }

        public int Utility()
        {
            int rows = _state.Length;
            int cols = _state[0].Length;
            int countHuman = 0;
            int countComputer = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (_state[i][j] == 1)
                        countComputer++;
                    if (_state[i][j] == 2)
                        countHuman++;
                }
            }

            int win = Utils.CkeckIfWin(_state);

            if (countHuman == 21 || countComputer == 21)
            {
                _terminal = true;
                return 0;
            }
            else if (win == 1 || win == 2)
            {
                _terminal = true;
                int total = countComputer + countHuman;
                if (_human)
                    return -107 + total;
                return 107 - total;
            }

            return _human ? -50 : 50;
        }
    }
}
