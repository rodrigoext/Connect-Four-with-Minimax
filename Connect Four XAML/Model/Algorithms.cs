using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four_XAML.Model
{
    static class Algorithms
    {
        public static int Minimax(Node node, int depth, bool maximizing)
        {
            int heuristic = 0;

            //Se profundidade = 0 ou o nodo for terminal, retorna um valor para a heurística
            if (depth == 0 || node.isTerminal())
            {
                return heuristic;
            }

            return heuristic;
        }
    }
}
