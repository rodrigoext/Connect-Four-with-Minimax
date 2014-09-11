using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four.View
{
    public partial class MainForm : Form
    {

        Controller.Game _g;

        public MainForm()
        {
            InitializeComponent();
            _g = new Controller.Game();
            _g.Start();
            richTextBox1.Lines = _g.printNode();
            labelCountMoves.Text = _g._moves.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _g = new Controller.Game();

            _g.Start();
            richTextBox1.Lines =  _g.printNode();
            labelCountMoves.Text = _g._moves.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Lines = _g.printNode();
        }

        private void buttonCol_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int col = Convert.ToInt32(b.Text);
            col = col - 1;
            
            _g.HumanMove(col);
                      
            int win = _g.CheckWin();
            richTextBox1.Lines = _g.printNode();
            labelCountMoves.Text = _g._moves.ToString();
            labelScore.Text = _g.GetScore().ToString();

            if(win == 1)
            {
                MessageBox.Show("Human Win");
                button1_Click_1(this, e);
                return;
            }

            _g.ComputerMove();
            win = _g.CheckWin();
            richTextBox1.Lines = _g.printNode();
            labelCountMoves.Text = _g._moves.ToString();
            if (win == 2)
            {
                MessageBox.Show("Computer Win");
                button1_Click_1(this, e);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int depth = Convert.ToInt32(textBoxDepth.Text);
                if(depth < 1 || depth > 21)
                {
                    MessageBox.Show("Please 1 to 10");
                    return;
                }
                _g.SetDepth(depth);
            }
            catch(Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
            

        }
    }
}
