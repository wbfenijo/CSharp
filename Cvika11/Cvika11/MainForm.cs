using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{

	int[] a = new int[500];
	Random rnd = new Random();
	void MainFormLoad(object sender, EventArgs e)
	{
		
		a[0] = 10;
		a[499] = 100;
		hodnota(0,499, 100);
	}
	void hodnota(int l, int p, int d){
		if  (p - l <= 1) return;
		
		int posun = rnd.Next(-d,d + 1);
		int s = (l + p) / 2;
		a[s] = (a[l] + a[p]) / 2 + posun;
		hodnota(l,s,d/2);
		hodnota(s,p,d/2);
		return;
	}
	void MainFormPaint(object sender, PaintEventArgs e)
	{
		Graphics g = e.Graphics;
		for (int i = 0; i < 500; i++){
			g.DrawLine(Pens.Black,5 + i, 150, 5 + i, 150 - a[i]);
		}
	}
	
}
