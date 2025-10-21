using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	
	int[] kamene = new int[10];
	Random rnd = new Random();
	
	protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        int pocet = rnd.Next(10);   
        for (int k = 0; k < pocet; k++)
        {
            int ran = rnd.Next(10);
            otoc(ran);
        }
    }
    void otoc(int i)
    {
    	if (i > 0){
    		kamene[i - 1] = kamene[i - 1] == 0 ? 1: 0;
    	}
    	kamene[i] = kamene[i] == 0 ? 1: 0;
       	if (i < 9){
    		kamene[i + 1] = kamene[i + 1] == 0 ? 1: 0;
    	}
    	Invalidate();
    }
	void MainFormMouseDown(object sender, MouseEventArgs e)
	{
		if(e.Y > 50 && e.Y < 100){
			int i = (e.X - 20) / (50 + 5);
			int start = 20 + i * (50 + 5);
		if (e.X >= start && e.X <= start + 50 && i >= 0 && i < 10)
		{
		    otoc(i);
		}
		}
	}
	void MainFormPaint(object sender, PaintEventArgs e)
	{
        Graphics g = e.Graphics;

        int SIZE = 50;
        int GAP = 5;
        for (int i = 0; i < 10; i++)
        {
            Brush farba = kamene[i] == 1 ? Brushes.Red : Brushes.Gray;
            g.FillRectangle(farba, 20 + i * (SIZE + GAP), 50, SIZE, SIZE);
        }
	}

}

