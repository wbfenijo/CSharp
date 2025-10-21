using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	public static int firstX = -1;
	public static int firstY = -1;
	int[,] kamene = {
		{2, 0, 0, 0, 0, 0, 0, 2},
		{0, 0, 0, 0, 0, 0, 0, 0},
		{0, 0, 0, 1, 1, 0, 0, 0},
		{0, 0, 1, 2, 2, 1, 0, 0},
		{0, 0, 1, 2, 2, 1, 0, 0},
		{0, 0, 0, 1, 1, 0, 0, 0},
		{0, 0, 0, 0, 0, 0, 0, 0},
		{2, 0, 0, 0, 0, 0, 0, 2}};
	void MainFormPaint(object sender, PaintEventArgs e)
	{
		Graphics g = e.Graphics;
		for (int i = 0; i < 8; i++){
			for (int j = 0; j < 8; j++){
				g.FillRectangle(kamene[i, j] <= 1 ? Brushes.White:Brushes.Red, j * 50, i * 50, 50, 50);
				g.DrawRectangle(Pens.Black, j * 50, i * 50, 50, 50);
				if (kamene[i,j] % 2 == 1){
					g.FillEllipse(Brushes.Yellow, j * 50 + 5, i * 50 + 5, 40, 40);
					g.DrawEllipse(Pens.Black, j * 50 + 5, i * 50 + 5, 40, 40);
				}
			}
		}
	}
	void MainFormMouseUp(object sender, MouseEventArgs e)
	{
		int x = e.X;
		int y = e.Y;
		int row = y / 50;
		int col = x / 50;
		
		if (row > 7 || col > 7) return;
		if (kamene[row, col] % 2 == 0 && firstX == -1) return;
		if (firstY == -1){
			if (kamene[row,col] == 1){
				firstX = row;
				firstY = col;
			}
		}
		else if ((row != firstX) && (col != firstY)) return;
		else if (kamene[row, col] % 2 == 0 && checkColision(firstX, firstY, row, col)){
			kamene[row, col] += 1;
			kamene[firstX, firstY] -= 1;
			firstX = -1;
			firstY = -1;
		}
		Invalidate();
	}
	bool checkColision(int x, int y, int dx, int dy){
		if (x == dx){
	        int start = Math.Min(y, dy) + 1;
	        int end = Math.Max(y, dy);
	        for (int i = start; i < end; i++)
	        {
	            if (kamene[x, i] % 2 != 0) return false; 
	        }
	    }
	    
		if (y == dy){
	        int start = Math.Min(x, dx) + 1;
	        int end = Math.Max(x, dx);
	        for (int i = start; i < end; i++)
	        {
	            if (kamene[i, y] % 2 != 0) return false; 
	        }
	    }
	
	    return true;
	}
		
		
		
}
