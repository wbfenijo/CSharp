using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	char[,] kamene = {
		{'B', 'B', 'A', 'W', 'H', 'T', 'W', 'M', 'G', 'H'},
		{'D', ' ', ' ', ' ', 'C', 'K', ' ', ' ', ' ', 'C'},
		{'D', ' ', 'E', 'M', 'O', 'I', 'X', 'M', ' ', 'M'},
		{'E', ' ', 'E', 'O', 'X', 'A', 'B', 'O', ' ', 'U'},
		{'E', 'A', 'K', 'S', 'B', 'G', 'H', 'S', 'L', 'R'},
		{'F', 'W', 'L', 'Z', 'M', 'A', 'G', 'L', 'W', 'F'},
		{'G', ' ', 'U', 'O', 'I', 'J', 'H', 'R', ' ', 'H'},
		{'H', ' ', 'H', 'L', 'Z', 'Z', 'J', 'Y', ' ', 'H'},
		{'J', ' ', ' ', ' ', 'J', 'Z', ' ', ' ', ' ', 'J'},
		{'X', 'X', 'Z', 'X', 'M', 'T', 'Y', 'X', 'Z', 'J'}};
	public static char first = ' ';
	public static int firstX = -1;
	public static int firstY = -1;
	void MainFormPaint(object sender, PaintEventArgs e)
	{
		Graphics g = e.Graphics;
		string text = string.Format("First:{0}, FirstX:{1}, FirstY:{2}", first, firstX, firstY);
		g.DrawString(text, new Font("Helvetica", 25), Brushes.Black, 100, 500);
		for (int y = 0; y < 10; y ++){
			for (int x = 0; x < 10; x++){
				if(kamene[y,x] != ' '){
					g.FillRectangle(Brushes.Orange,x * 50, y * 50, 50, 50);
					g.DrawRectangle(Pens.Black,x * 50, y * 50, 50, 50);
				}
				g.DrawString(Convert.ToString(kamene[y,x]), new Font("Helvetica", 25), Brushes.Black, 50 * x + 8, 50 * y + 5);
			}
		}
		if (vyhra()){
				g.DrawString("HURAAAAAAAAAAA", new Font("Helvetica", 25), Brushes.Black, 100, 525);
			}

		
	}
	bool vyhra(){
		for (int a = 0; a < 10; a++){
			for (int b = 0; b < 10; b++){
				if (kamene[a,b] != ' ') {
					return false;
				}
			}
		}
		return true;
	}
	void MainFormMouseUp(object sender, MouseEventArgs e)
	{
		Graphics g = CreateGraphics();
		int r = e.Y / 50;
		int c = e.X / 50;
		if (r > 9 || c > 9) return;
		if (r == firstX && c == firstY) return;
		if (c > 0 && c < 9){
			if (kamene[r,c - 1] != ' ' && kamene[r, c + 1] != ' '){
				return;
				}
		}
		if (first == ' '){
			first = kamene[r,c];
			firstX = r;
			firstY = c;
		}
		else if(first == kamene[r,c]){
			kamene[r,c] = ' ';
			kamene[firstX,firstY] = ' ';
			first = ' ';
			firstX = -1;
			firstY = -1;
		}
		else{
			first = ' ';
			firstX = -1;
			firstY = -1;
		}
		Invalidate();
	}

}
