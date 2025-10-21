using System;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	int[,] karty = new int[10,10];

    const int SIZE = 20;
    const int GAP = 2;
    const int START_X = 20;
    const int START_Y = 50;


    void MainFormMouseDown(object sender, MouseEventArgs e)
    {
        int r = (e.Y - START_Y) / (SIZE + GAP);
        int c = (e.X - START_X) / (SIZE + GAP);

        if (r >= 0 && r < 10 && c >= 0 && c < 10)
        {
            otoc(r, c);
            Invalidate();
        }
    }


//    void otoc(int r, int c)
//    {
//        for (int j = 0; j < 10; j++)
//        	karty[r, j] = karty[r,j] == 0 ? 1: 0;
//        for (int i = 0; i < 10; i++){
//            if (i != r) 
//                karty[i, c] = karty[i,c] == 0 ? 1: 0;
//        }
//        
//    }
 
	void otoc(int r, int c){
        for (int j = r - 1; j < r + 2; j++)
        	karty[r, j] = karty[r,j] == 0 ? 1: 0;
        for (int i = c - 1; i < c + 2; i++){
            if (i != r) 
                karty[i, c] = karty[i,c] == 0 ? 1: 0;
        }		
	}



    void MainFormPaint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        for (int i = 0; i < 10; i++)
        {
        	for (int j = 0; j < 10; j++)
            {
                Brush color = karty[i, j] == 1 ? Brushes.Red : Brushes.Gray;
                int x = START_X + j * (SIZE + GAP);
                int y = START_Y + i * (SIZE + GAP);
                g.FillRectangle(color, x, y, SIZE, SIZE);
            }
        }
    }
}
