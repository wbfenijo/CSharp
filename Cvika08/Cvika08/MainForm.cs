using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	Bitmap bmp = new Bitmap("C:\\Users\\adamy\\OneDrive\\Plocha\\Untitled.bmp");
	Bitmap[] anim = new Bitmap[8];
	int x = 20;
	int f = 0;
	int pocet = 0;
	Postava[] postavy = new Postava[4096];
	void MainFormLoad(object sender, EventArgs e){
//		for (int i = 0; i < 8; i++){
//			Bitmap zaj = new Bitmap("C:\\Users\\adamy\\OneDrive\\Plocha\\zajo\\" +  Convert.ToString(i) + ".png");
//			anim[i] = zaj;
//		}

	}
	void MainFormPaint(object sender, PaintEventArgs e)
	{
		Graphics g = CreateGraphics();
//		g.DrawImage(bmp, 0, 0);
//		g.DrawImage(anim[f], x, 100);
		foreach (Postava p in postavy)
		{
			if (p != null) p.kresli(g);
		}


	}
	void MainFormMouseMove(object sender, MouseEventArgs e)
	{
//		Graphics g = CreateGraphics();
//		Random rnd = new Random();
//		Bitmap obr = new Bitmap("C:\\Users\\adamy\\OneDrive\\Plocha\\hmiz\\" +  Convert.ToString(rnd.Next(16) + 1) + ".png");
//		g.DrawImage(obr, e.X - obr.Width / 2, e.Y - obr.Height / 2);
	}
	void Timer1Tick(object sender, EventArgs e)
	{
//		x += 10;
//		if (x > 522) x = 0 - anim[f].Width;
//		f += 1;
//		if (f == 8) f = 0;
		Invalidate();
	}
	void MainFormMouseUp(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left){
			Postava p = new Postava("pes", e.X, e.Y, 10);
			postavy[pocet] = p;
			pocet++;
		}
		else{
			Postava p = new Postava("kohut", e.X, e.Y, 10);
			postavy[pocet] = p;	
			pocet++;
		}
	}

	
}

class Postava{
	Bitmap[] animacia = new Bitmap[8];
	string dir;
	int posX;
	int posY;
	int speed;
	int f = 0;
	public Postava(string adir, int aposX, int aposY, int aspeed){
		dir = adir;
		posX = aposX;
		posY = aposY;
		speed = aspeed;
		for (int i = 0; i < 8; i++){
			animacia[i] = new Bitmap("C:\\Users\\adamy\\OneDrive\\Plocha\\pk\\"+ dir + " \\"+  Convert.ToString(i) + ".png");
		}
	}
	public void kresli(Graphics g){
		pohyb();
		g.DrawImage(animacia[f], posX, posY);
	}
	public void pohyb(){
		if (dir == "pes") posX += speed;
		else posX -= speed;
		f += 1;
		if (f == 8) f = 0;
	    if (speed > 0 && posX > 1024)
	        posX = -animacia[f].Width;
	    else if ( posX + animacia[f].Width < 0)
	        posX = 1024;
	}
}
