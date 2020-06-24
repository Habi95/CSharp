using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Color player1 = Color.Red;
        Color player2 = Color.Yellow;
        private int idOfPlayer = 1;
        Graphics graph;
        Rectangle rec;
        public GameFrom()
        {
            InitializeComponent();
            boardColumns = new Rectangle[7];
            board = new int[6, 7];
            graph = this.CreateGraphics();
            //PrintBoard(null,null);


        }

       private void GameFrom_Paint(object sender, PaintEventArgs e)
        {

           PrintBoard(null, null);
            /*e.Graphics.FillRectangle(Brushes.Black,200,160,450,350);
            for (int columns = 0; columns < 6; columns++)
            {
                for (int rows = 0; rows < 7; rows++)
                {
                    if (columns == 0)
                    {
                        boardColumns[rows] = new Rectangle(32 + 48 * rows, 200, 160, 350);
                    }
                    e.Graphics.FillEllipse(Brushes.White, 200 + 68 * rows, 160 + 61 * columns, 43, 43);
                    
                }
            }*/
        }
        private void PrintBoard(int? column, int? row)
        {

           


            graph.FillRectangle(Brushes.Black, 200, 160, 450, 350);
            for (int columns = 0; columns < 6; columns++)
            {
                for (int rows = 0; rows < 7; rows++)
                {
                    if (columns == 0)
                    {
                      rec =  boardColumns[rows] = new Rectangle(32 + 48 * rows, 200, 160, 350);
                    }

                    if (column.HasValue && row.HasValue)
                    {
                        if (column.Value == columns && row.Value == rows)
                        {
                             graph.FillEllipse(Brushes.Red, 200 + (68 * rows), 160 + (61 * columns), 43, 43);
                        }
                        else
                        {
                            graph.FillEllipse(Brushes.White, 200 + 68 * rows, 160 + 61 * columns, 43, 43);
                        }
                    }
                    else
                    {
                        graph.FillEllipse(Brushes.White, 200 + 68 * rows, 160 + 61 * columns, 43, 43);
                    }



                }
            }
            
                
        }

        

       


        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int row = int.Parse(button.Text) - 1;
            int? column = null;
            for (int i = 5; i > 0; i--)
            {
                var k = board[i, row];
                if (k == 0)
                {
                    column = i;
                    board[i, row] = idOfPlayer;
                    break;
                }
            }
            PrintBoard(column, row);

        }



    }
}
