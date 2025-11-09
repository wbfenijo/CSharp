using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	Tvar[] zoznam = new Tvar[4096];
	int pocet = 0;
	void MainFormPaint(object sender, PaintEventArgs e)
	{
		Graphics g = CreateGraphics();
//		Tvar t;
//		Stvorec s;
//		t = new Tvar(100, 50);
//		t.Kresli(g);
//		s = new Stvorec(200, 50, 20);
//		s.Kresli(g);
//		t = new Stvorec(300, 50, 20);
//		t.Kresli(g);
//        Tvar k, p;
//        p = new Stvorec(200, 50, 20);
//        p.Kresli(g);
//        k = new Kruh(300, 50, 10);
//        k.Kresli(g);	
//		Zakladna z = new Zakladna();
//		Odvodena o = new Odvodena();
//		Zakladna x = new Odvodena();
//		z.pozdrav(); //ahoj zak
//		o.pozdrav(); //pozd odv
//		x.pozdrav(); //pozd zakl   
		for (int i = 0; i < pocet; i++)
		{
			zoznam[i].Kresli(g);
		}
	}
	void MainFormMouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left){
			zoznam[pocet++] = new Stvorec(e.X, e.Y, 20);
		}
		else if (e.Button == MouseButtons.Right){
			zoznam[pocet++] = new Kruh(e.X, e.Y, 10);
	}
	

}
	void Timer1Tick(object sender, EventArgs e)
	{
		for (int i = 0; i < pocet; i++)
		{
			zoznam[i].Pohni(CreateGraphics());
		}
		Invalidate();
	}
}
class Tvar
{
    public int X, Y;
    public Tvar(int nX, int nY)
    {
        X = nX;
        Y = nY;
    }
    public virtual void Kresli(Graphics g)
    {
    }
    public virtual void Pohni(Graphics g){
    }
}

class Stvorec : Tvar
{
    public int A;
    public int speedX = 1;
    public int speedY = 1;
    public Stvorec(int nX, int nY, int nA) : base(nX, nY)
    {
        A = nA;
    }
    public override void Kresli(Graphics g)
    {
        g.FillRectangle(Brushes.Black, X - A / 2, Y - A / 2, A, A);
    }
    public override void Pohni(Graphics g){
    	if (X + A / 2 > 400 || X - A / 2 <= 0) speedX *= -1;
    	if (Y + A / 2 > 400 || Y - A / 2 <= 0) speedY *= -1;
    	X += speedX;
    	Y += speedY;
    	    
    }   
}

class Kruh : Tvar
{
    public int A;
    Random rnd;
    public Kruh(int nX, int nY, int nA) : base(nX, nY)
    {
        A = nA;
        rnd = new Random();
    }
    public override void Kresli(Graphics g)
    {
        g.FillEllipse(Brushes.Black, X - A, Y - A, 2 * A, 2 * A);
    }
    public override void Pohni(Graphics g){
    	X += rnd.Next(-10, 10);
    	Y += rnd.Next(-10, 10);
    	    
    } 
}

class Zakladna
{
    public virtual string ktosom()
    {
        return "základná trieda";
    }
    public void pozdrav()
    {
        MessageBox.Show("Ahoj, som " + ktosom());
    }
}

class Odvodena : Zakladna
{
    public override string ktosom()
    {
        return "odvodená trieda";
    }
    public new void pozdrav()
    {
        MessageBox.Show("Pozdravuje " + ktosom());
    }
}


