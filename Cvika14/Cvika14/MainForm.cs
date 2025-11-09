using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	Vektor[] vektory = new Vektor[100]; 
    int index; 
    Vektor aktualny;

    int[,] a = new int[100, 100];

    
    
	void MainFormPaint(object sender, PaintEventArgs e)
	{
	    Graphics g = e.Graphics;
//
//        for (int i = 0; i < index; i++)
//            vektory[i].Kresli(g, Pens.Black);
//		if (aktualny != null)
//            aktualny.Kresli(g, Pens.Green);
//        if (index > 0)
//        {
//            Vektor sum = new Vektor(0, 0);
//            for (int i = 0; i < index; i++)
//                sum += vektory[i];
//                if (aktualny != null) sum += aktualny;
//            sum.Kresli(g, Pens.Red);
//        }

        for (int r = 1; r < 100; r++){
            for (int s = 1; s < 100; s++)
            {
    		Point[] body = {Priemet(r - 1, s - 1), Priemet(r - 1, s), Priemet(r, s), Priemet(r, s - 1)};

			    g.FillPolygon(Brushes.Yellow, body);
			    g.DrawPolygon(Pens.Black, body);
            }
        }
	}
	void Button1Click(object sender, EventArgs e)
	{
		vektory[index++] = new Vektor(100,0);
		vektory[index++] = new Vektor(0,-100);
		Invalidate();
	}
	void MainFormMouseDown(object sender, MouseEventArgs e)
	{
        aktualny = new Vektor(e.X - 250, -(e.Y - 150));
        vektory[index] = aktualny;
        Invalidate();
	}
	void MainFormMouseUp(object sender, MouseEventArgs e)
	{
        if (aktualny != null && index < vektory.Length)
        {
            vektory[index++] = aktualny;
            aktualny = null;
            Invalidate();
        }
	}
	void MainFormMouseMove(object sender, MouseEventArgs e)
	{
	    if (aktualny != null)
        {
            aktualny.x = e.X - 250;
            aktualny.y = -(e.Y - 150);
			vektory[index] = aktualny;            
            Invalidate(); 
        }
	}
	void MainFormLoad(object sender, EventArgs e)
	{
		for (int r = 0; r < 100; r++){
			for (int s = 0; s < 100; s++){
				a[r, s] = Convert.ToInt32(200 * f(s / 50.0 - 1, r / 50.0 - 1));
			}
		}
	}
	//cos(x · π / 2) · cos(y · π / 2)
	//1 / (1 + 10 · x2 + 10 · y2)
    double f(double x, double y){
		return 1 / (1 + 10 * x * x + 10 * y * y);
	}
	
    Point Priemet(int r, int s){
		int x = 500 + 5 * (s - 50) - 2 * r;
		int y = 300 + 3 * (r - 50) - a[r, s];
        return new Point(x, y);
    }
}

class Vektor
    {
        public float x, y;

        public Vektor(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Kresli(Graphics g, Pen farba)
        {
            int stredX = 250;
            int stredY = 150;
            g.DrawLine(farba, stredX, stredY, stredX + x, stredY - y);
        }

        public static Vektor operator +(Vektor a, Vektor b)
        {
            return new Vektor(a.x + b.x, a.y + b.y);
        }
}
