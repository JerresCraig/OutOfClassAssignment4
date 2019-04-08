using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutOfClassAssignment4
{
    //Jerres Craig
    //This is my own my own work

    public partial class Form1 : Form
    {
        ttt_Button[,] grid = new ttt_Button[3, 3];
        bool xTurn = true;

        public Form1()
        {
            InitializeComponent();
            ttt_Button t_button = new ttt_Button();
            this.Controls.Add(t_button);
            t_button.Location = new Point(25, 25);

            //initialize the grid with buttons
            int x = 0, y = 0;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; r < 3; c++)
                {
                    grid[r, c] = new ttt_Button();
                    this.Controls.Add(grid[r, c]);
                    grid[r, c].Location = new Point(x, y);
                    grid[r, c].Click += new EventHandler(button_Click);
                    y += 100;
                }
                x += 100;
                y = 0;
            }
        }
        //win conditions
        private bool checkForWin()
        {
            if (grid[0, 0].Text == grid[0, 1].Text &&
                grid[0, 1].Text == grid[0, 2].Text &&
                grid[0, 0].Text != "*")
                return true;
            else if
                (grid[1, 0].Text == grid[1, 1].Text &&
                 grid[1, 1].Text == grid[1, 2].Text &&
                 grid[1, 0].Text != "*")
                return true;
            else if
                (grid[2, 0].Text == grid[2, 1].Text &&
                 grid[2, 1].Text == grid[2, 2].Text &&
                 grid[2, 0].Text != "*")
                return true;
            else if
                (grid[0, 0].Text == grid[1, 0].Text &&
                 grid[1, 0].Text == grid[2, 0].Text &&
                 grid[0, 0].Text != "*")
                return true;
            else if
                (grid[0, 1].Text == grid[1, 1].Text &&
                 grid[1, 1].Text == grid[2, 1].Text &&
                 grid[0, 1].Text != "*")
                return true;
            else if
                (grid[0, 2].Text == grid[1, 2].Text &&
                 grid[1, 2].Text == grid[2, 2].Text &&
                 grid[0, 2].Text != "*")
                return true;
            else if
                (grid[0, 0].Text == grid[1, 1].Text &&
                 grid[1, 1].Text == grid[2, 2].Text &&
                 grid[0, 0].Text != "*")
                return true;
            else if
                (grid[2, 0].Text == grid[1, 1].Text &&
                 grid[1, 1].Text == grid[0, 2].Text &&
                 grid[2, 0].Text != "*")
                return true;
            else
                return false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            //capture the sender
            ttt_Button t = (ttt_Button)sender;
            if (xTurn)
            {
                t.BackColor = Color.RoyalBlue;
                t.Text = "X";
            }
            else
            {
                t.BackColor = Color.Gold;
                t.Text = "O";
            }
            xTurn = !xTurn;

            if (checkForWin())
            {
                MessageBox.Show("You are a Winner!");
                //reset board
                int x = 0, y = 0;
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; r < 3; c++)
                    {
                        grid[r, c] = new ttt_Button();
                        this.Controls.Add(grid[r, c]);
                        grid[r, c].Location = new Point(x, y);
                        grid[r, c].Click += new EventHandler(button_Click);
                        y += 100;
                    }
                    x += 100;
                    y = 0;

                }
            }
        }
    }
}