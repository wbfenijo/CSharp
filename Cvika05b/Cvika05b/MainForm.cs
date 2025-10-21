using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
    int[,] obr = {
        {0, 2, 2, 2, 2, 2, 2, 0, 0, 0},
        {2, 2, 2, 2, 2, 2, 2, 2, 2, 0},
        {0, 0, 2, 2, 2, 2, 2, 2, 0, 0},
        {0, 0, 0, 0, 1, 0, 0, 0, 1, 1},
        {0, 1, 1, 0, 1, 0, 0, 1, 1, 1},
        {0, 0, 1, 1, 1, 0, 1, 1, 1, 0},
        {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
        {0, 0, 0, 0, 1, 1, 0, 0, 0, 0},
        {0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
        {0, 0, 0, 1, 1, 1, 1, 0, 0, 0}
    };
	int[,] otoceny = new int[10, 10];
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;

        int size = 20; 
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++)
            {
                otoceny[j, 9 - i] = obr[i, j];
            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Color color = Color.White;
                if (obr[i, j] == 1) color = Color.Green;
                else if (obr[i, j] == 2) color = Color.Red;
                g.FillRectangle(new SolidBrush(color), j * size, i * size, size, size);

                color = Color.White;
                if (otoceny[i, j] == 1) color = Color.Green;
                else if (otoceny[i, j] == 2) color = Color.Red;
                 g.FillRectangle(new SolidBrush(color), 400 +  j * size, i * size, size, size);
            }
        }
    }
}
