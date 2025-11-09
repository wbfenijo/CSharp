using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	double scale = 100.0;
	SolidBrush[] brushes = new SolidBrush[101]; 
	double centerX = -0.5;  
	double centerY = 0.0;
	int iter(int x, int y)
	{
	    double r0, i0, r, i, t;
	    double temp = 1.0 / scale;
//	    r0 = (x - 300) / 100.0;
//	    i0 = (y - 150) / 100.0;
	    r0 = (x - 250) * temp + centerX;
	    i0 = (y - 150) * temp + centerY;
	    r = r0;
	    i = i0;
	    int pocet = 0;
	    while (r * r + i * i <= 4 && pocet < 100)
	    {
	        t = r * r - i * i + r0;
	        i = 2 * r * i + i0;
	        r = t;
	        pocet += 1;
	    }
	    return pocet;
	}
	void MainFormLoad(object sender, EventArgs e)
	{
		Random rnd = new Random();

		
		for (int i = 0; i <= 100; i++)
		{
		    brushes[i] = new SolidBrush(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
		}

	}
	void MainFormPaint(object sender, PaintEventArgs e)
	{
		Graphics g = CreateGraphics();

		for (int x = 0; x < 500; x++){
			for(int y = 0; y < 300; y++){
				double hodnota = iter(x, y) * 2.55;
				int n = iter(x,y);
				g.FillRectangle(brushes[n], x, y, 1, 1);
//				g.FillRectangle(iter(x, y) == 100? Brushes.Black: Brushes.Red, x, y, 1, 1);
			}
		}
	}
	void MainFormMouseDown(object sender, MouseEventArgs e)
	{

	    double clickedRe = (e.X - 250.0) / scale + centerX;
	    double clickedIm = (e.Y - 150.0) / scale + centerY;
	
	
	    double factor = (e.Button == MouseButtons.Left) ? 2.0 : 0.5; 
	    scale *= factor;
	
	
	    centerX = clickedRe - (e.X - 250.0) / 100.0 / scale;
	    centerY = clickedIm - (e.Y - 150.0) / 100.0 / scale;
	
	    Invalidate();
	}

}
