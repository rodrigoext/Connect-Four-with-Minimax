using Connect_Four.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four.Controller
{
    class Game
    {
        public int _moves = 0;
        private int[][] _actualstate;
        private Node _node;
        private int _depth = 7;
        private int _score = 0;

        public Game()
        { }

        public void SetDepth(int depth)
        {
            _depth = depth;
            MessageBox.Show("Depth: " + depth);
        }

        public int GetScore()
        {
            return _node.Utility();
        }

        public void Start()
        {
            _moves = 0;
            int[][] state = new int[6][];

            for (int i = 0; i < state.Length; i++)
            {
                state[i] = new int[7];
                for (int j = 0; j < state[i].Length; j++)
                {
                    state[i][j] = 0;
                }
            }

            _node = new Node(state, true);
        }

        public int CheckWin()
        {
           int win = Utils.CkeckIfWin(_node.GetState());
           
           return win;
        }

        public void ComputerMove()
        {
            Node next = _node.FindNextMove(_depth);
            
            if(next != null)
            {
                next._human = true;
                _node = next;
                _node._score = _node.Utility();
            }
            _moves++;
            
        }

        public string[] printNode()
        {
            _actualstate = _node.GetState();
            string[] lines = new string[6];
            string line = "";

            for (int i = 0; i < _actualstate.Length; i++)
            {
                for (int j = 0; j < _actualstate[i].Length; j++)
                {
                    line += _actualstate[i][j] + "   ";
                }
                lines[i] = line;
                line = "";
            }

            return lines;
        }
        
        public void HumanMove(int col)
        {
            for (int row = 0; row < 6; row++)
            {
                if (Utils.LegalMove(_node.GetState(), row, col))
                {
                    _node.setMove(row, col);
                    _node._human = false;
                    _moves++;
                    break;
                }
            }
        }
    }
}
