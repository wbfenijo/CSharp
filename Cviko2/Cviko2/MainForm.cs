using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	
	void MainFormLoad(object sender, EventArgs e)
	{
		
	}
	void Button1Click(object sender, EventArgs e)
	{
		Graphics g = CreateGraphics();
		g.FillRectangle(Brushes.Red, 0, 0, 100, 50);
		g.DrawEllipse(Pens.Blue, 10, 10, 100, 100);
	}
	void Button2Click(object sender, EventArgs e)
	{
		Graphics g = CreateGraphics();
		g.FillRectangle(Brushes.LightGray,200,20,50,50);
		
		g.FillRectangle(Brushes.Gray,175,70,100,100);
		
		g.FillRectangle(Brushes.LightGray,155,70,20,100);
		g.FillRectangle(Brushes.LightGray,275,70,20,100);
		g.FillRectangle(Brushes.LightGray,235,170,30,100);
		g.FillRectangle(Brushes.LightGray,185,170,30,100);
	}
	void Button3Click(object sender, EventArgs e)
	{
		Graphics g = CreateGraphics();
		g.DrawString("Text s tienom", new Font("písmo", 20), Brushes.LightGray, 205, 305);
		g.DrawString("Text s tienom", new Font("písmo", 20), Brushes.Black, 200, 300);
	}
	void Button4Click(object sender, EventArgs e)
	{
		Graphics g = CreateGraphics();		
		for (int i = 0; i < 10; i++){
			g.FillEllipse(Brushes.Black, 10 + i * 10, 340, 10, 10);
		}
		
	}
	void Button5Click(object sender, EventArgs e)
	{
		Graphics g = CreateGraphics();
		float stredX = 300;
		float stredY = 300;
		for (int i = 0; i < 7; i++){
			double angle = 2 * i * Math.PI / 7;
			g.FillEllipse(Brushes.Red,stredX + (float)Math.Cos(angle) * 100, stredY + (float)Math.Sin(angle) * 100, 10,10);
		}		
	}
	void Button6Click(object sender, EventArgs e)
	{
		Random rnd = new Random();
		Graphics g = CreateGraphics();
		for (int i = 0; i < 1000; i++){
			int x1 = rnd.Next(400);
			int y1 = rnd.Next(400);
			int x2 = rnd.Next(400);
			int y2 = rnd.Next(400);
			g.DrawLine(Pens.Red, x1, y1, x2, y2);
		}
	}
	void Button7Click(object sender, EventArgs e)
	{		
		Graphics g = CreateGraphics();
		for (int i = 0; i < 1000; i++){
			Random rnd = new Random();
			int x1 = rnd.Next(400);
			int y1 = rnd.Next(400);
			int x2 = rnd.Next(400);
			int y2 = rnd.Next(400);
			g.DrawLine(Pens.Red, x1, y1, x2, y2);
		}
	}
	void Button8Click(object sender, EventArgs e)
	{
		Random rnd = new Random();
		Graphics g = CreateGraphics();		
		for (int i = 0; i < 10; i++){
			int a = rnd.Next(256);
			int r = rnd.Next(256);
			int gr = rnd.Next(256);
			int b = rnd.Next(256);
			g.FillEllipse(new SolidBrush(Color.FromArgb(a, r, gr, b)), 10 + i * 10, 340, 10, 10);
		}
	}
	void Button9Click(object sender, EventArgs e)
	{
		Random rnd = new Random();
		Graphics g = CreateGraphics();
		g.Clear(Color.DarkBlue);
		for (int i = 0; i < 100; i++){
			float x = rnd.Next(401);
			float y = rnd.Next(401);
			int size = rnd.Next(21);
			for (int j = 0; j < 5; j++){
				double angle = 2 * j * Math.PI / 5;
				g.DrawLine(Pens.White,x,y, x + (float)Math.Cos(angle) * size, y + (float)Math.Sin(angle) * size);
			}
			
		}
	}
	void Button10Click(object sender, EventArgs e)
	{
		Graphics g = CreateGraphics();
		g.DrawLine(Pens.Black,10, 260, 510, 260);
		g.DrawLine(Pens.Black,260, 10, 260, 510);
		for (int i = 0; i < 51; i++){
			g.DrawLine(Pens.Black,10 + i * 10,255,10 + i * 10,265);
			g.DrawLine(Pens.Black,255,10 + i * 10,265,10 + i * 10);
		}
		for(double x = -500; x < 501; x++){
			double y1 = -1 * (x*x) / 300 - 100;
			double y2 =  -1 * ((x + 1)*(x + 1)) / 300 - 100;
			g.DrawLine(Pens.Black,(float)x + 260, (float)y1 + 460, (float)x + 260, (float)y2 + 460);
			
		}
		
	}
}
