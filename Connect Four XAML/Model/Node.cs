using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four_XAML.Model
{
    class Node
    {
        private bool _terminal;
        private List<Node> _children;

        public Node()
        {
            _children = new List<Node>();
            _terminal = false;
        }

        public void setTerminal(bool isTerminal)
        {
            _terminal = isTerminal;
        }

        public bool isTerminal()
        {
            return _terminal;
        }
    }
}
