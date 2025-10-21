using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	int x;
	int y;
	int[] Lekno = { 7, 4, 1, 5, 2, 8, 9, 3, 6, 0 };
    const int sirka = 50;
    const int medzera = 5;
	
	void MainFormMouseMove(object sender, MouseEventArgs e)
	{
		Text = string.Format("X: {0}, Y: {1}, T: {2}", e.X, e.Y, e.Button);
		Graphics g = CreateGraphics();
		if (e.Button == MouseButtons.Left){			
			g.DrawLine(Pens.Red,e.X, e.Y, x,y);
		}
		if (e.Button == MouseButtons.Right){
			g.DrawLine(Pens.Blue,e.X, e.Y, x,y);
			}
		x = e.X;
		y = e.Y;
		}

	void MainFormMouseDown(object sender, MouseEventArgs e)
	{
		Graphics g = CreateGraphics();
//		if(e.Button == MouseButtons.Left){
//			g.FillRectangle(Brushes.Red,e.X, e.Y, 15,15);
//		}
//		if(e.Button == MouseButtons.Right){
//			g.FillRectangle(Brushes.Blue,e.X, e.Y, 15,15);
//		}
		int mx = e.X;
        int my = e.Y;
		for (int i = 0; i < 10; i++){
		            int posX = 10 + i * (sirka + medzera);
		            if (mx >= posX && mx <= posX + sirka && my >= 50  && my <= 100){
		            	if (Lekno[i] != 0){		             
		                    int empty = Array.IndexOf(Lekno, 0);
		                    Lekno[empty] = Lekno[i];
		                    Lekno[i] = 0;		                    
		                    Invalidate();

		                }

		            }
		        }
		    }
	void MainFormMouseUp(object sender, MouseEventArgs e)
	{

//		Graphics g = CreateGraphics();
//		if(e.Button == MouseButtons.Left){
//			g.FillEllipse(Brushes.Red,e.X, e.Y, 15,15);
//		}
//		if(e.Button == MouseButtons.Right){
//			g.FillEllipse(Brushes.Blue,e.X, e.Y, 15,15);
//		}
		
	}
	void MainFormPaint(object sender, PaintEventArgs e)
	{
		Graphics g = e.Graphics;
		for (int i = 0; i < 10; i++){
			if (Lekno[i] != 0){
				g.DrawString(Lekno[i].ToString(), new Font("Helvetica", 20), Brushes.Green, 25 + i * (sirka + medzera),70);
			}
			g.FillRectangle(Brushes.Green, 10 + i * (sirka + medzera), 100,sirka,5);
    	for (int j = 0; j < 10; j++){
    		if (Lekno[i] != i + 1){
    			;
    		}
    		}
    		g.DrawString("Vyhral si",new Font("Helvetica",40) ,Brushes.Red,200, 200);
		}
		
		
		
		
		
		
		
		

	}
	void Button1Click(object sender, EventArgs e)
	{
		Invalidate();
	}

}
