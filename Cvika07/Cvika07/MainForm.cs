using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
 	Bod a = new Bod(100, 50);
 	Trojuholnik t;
    Kocka k1 = new Kocka(400, 100);
    Kocka k2 = new Kocka(500, 100);
    Kocka k3 = new Kocka(600, 100);

    void MainFormMouseMove(object sender, MouseEventArgs e){
        if (t == null) return; 
        t.A.X = e.X;
        t.A.Y = e.Y;
        Invalidate();
    }


    void MainFormPaint(object sender, PaintEventArgs e){
        if (t == null)
        return; 
        Graphics g = e.Graphics;

        t.Kresli(g);
        t.Tazisko().Kresli(g);

        k1.Kresli(g);
        k2.Kresli(g);
        k3.Kresli(g);
    }
    void Button1Click(object sender, EventArgs e){
        Graphics g = CreateGraphics();
        a.Kresli(g);
        Bod b = new Bod(100, 100);
        b.Kresli(g);
	}
	void Button2Click(object sender, EventArgs e)
	{
		t = new Trojuholnik(new Bod(100, 50), new Bod(30, 200), new Bod(250, 200));
	}
	void Button3Click(object sender, EventArgs e)
	{}
	void Timer1Tick(object sender, EventArgs e)
	{
		
	}
}


class Bod
{
    public double X;
    public double Y;

    public Bod(double nX, double nY)
    {
        X = nX;
        Y = nY;
    }

    public void Kresli(Graphics g)
    {
        int r = 5;
        g.FillEllipse(Brushes.Blue, (float)(X - r), (float)(Y - r),r * 2, r * 2);
    }
    public Bod stred(Bod a, Bod b){
    	return new Bod((a.X + b.X) / 2,(a.Y + b.Y) / 2);
    }
}


class Trojuholnik
{
    public Bod A, B, C;

    public Trojuholnik(Bod nA, Bod nB, Bod nC)
    {
        A = nA;
        B = nB;
        C = nC;
    }

    public void Kresli(Graphics g)
    {
        Pen p = new Pen(Color.Black, 2);
        g.DrawLine(p, (float)A.X, (float)A.Y, (float)B.X, (float)B.Y);
        g.DrawLine(p, (float)B.X, (float)B.Y, (float)C.X, (float)C.Y);
        g.DrawLine(p, (float)C.X, (float)C.Y, (float)A.X, (float)A.Y);
    }

    public Bod Tazisko()
    {
        double tx = (A.X + B.X + C.X) / 3;
        double ty = (A.Y + B.Y + C.Y) / 3;
        return new Bod(tx, ty);
    }
}


class Kocka
{
    public int X, Y;
    public int Cislo;
    Random rnd = new Random();

    public Kocka(int x, int y)
    {
        X = x;
        Y = y;
        Cislo = rnd.Next(1, 7);
    }

    public void NahodneCislo()
    {
        Cislo = rnd.Next(1, 7);
    }

    public void Kresli(Graphics g)
    {
        int velkost = 60;
        g.FillRectangle(Brushes.Red, X, Y, velkost, velkost);
        g.DrawRectangle(Pens.Black, X, Y, velkost, velkost);
        g.DrawString(Cislo.ToString(), new Font("Helvetica", 20), Brushes.Black, X + 18, Y + 15);        
    }
}
