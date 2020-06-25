using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class GameFrom : Form
    {
        private Rectangle[] boardColumns;
        private int[,] board;
        private int idOfPlayer1 = 1;
        private int idOfPlayer2 = 2;
        private string player1Name;
        private string player2Name;
        Graphics graph;
        int counter = 0;
        Stopwatch stopwatch;
        bool hasStarted = false;
        public GameFrom()
        {
            InitializeComponent();
            timer.Start();
            stopwatch = new Stopwatch();                       
            boardColumns = new Rectangle[7];
            board = new int[6, 7];
            graph = this.CreateGraphics();
           


        }

        private void GameFrom_Paint(object sender, PaintEventArgs e)
        {

           
            if (hasStarted)
            {
                graph.FillRectangle(Brushes.Black, 200, 160, 450, 350);
                for (int columns = 0; columns < 6; columns++)
                {
                    for (int rows = 0; rows < 7; rows++)
                    {
                        if (board[columns, rows] > 0)
                        {
                            if (board[columns, rows] == 1)
                            {
                                graph.FillEllipse(Brushes.Red, 200 + 68 * rows, 160 + 61 * columns, 43, 43);
                            }
                            else if (board[columns, rows] == 2)
                            {
                                graph.FillEllipse(Brushes.Yellow, 200 + 68 * rows, 160 + 61 * columns, 43, 43);
                            }
                        }
                        else
                        {
                            graph.FillEllipse(Brushes.White, 200 + 68 * rows, 160 + 61 * columns, 43, 43);
                        }
                    }
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (hasStarted)
            {            
            counter++;
            Button button = (Button)sender;
            int row = int.Parse(button.Text) - 1;
            int? column = null;
            for (int i = 5; i >= 0; i--)
            {
                var k = board[i, row];
                if (k == 0)
                {
                    column = i;
                    if (counter % 2 == 0)
                    {
                        board[i, row] = idOfPlayer2;
                        labelHowIsMove.Text = string.IsNullOrEmpty(player1Name) ? "Player1 is on turn" : $"{player1Name} your Turn";
                        break;
                    }
                    else
                    {
                        board[i, row] = idOfPlayer1;
                        labelHowIsMove.Text = string.IsNullOrEmpty(player2Name) ? "Player2 is on turn" : $"{player2Name} your Turn";
                        break;
                    }
                }
            }
            OnPaint(null);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            hasStarted = true;
            player1Name = textBoxPlayer1.Text;
            player2Name = textBoxPlayer2.Text;
            labelPlayer1.Text = player1Name;
            labelPlayer2.Text = player2Name;
            textBoxPlayer1.Hide();
            textBoxPlayer2.Hide();
            labelHowIsMove.Text = string.IsNullOrEmpty(player1Name) ? "Player1 is on turn" : $"{player1Name} your Turn";
            OnPaint(null);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelStopWatch.Text = stopwatch.Elapsed.ToString("hh\\:mm\\:ss");
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
           
            stopwatch.Reset();
            board = new int[6, 7];
            hasStarted = false;
            Refresh();
        }
    }
}
