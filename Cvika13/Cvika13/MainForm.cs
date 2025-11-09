using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	char[,] castle = new char[12,20];
	const int SIZE = 20;
	Indy indy;
	void MainFormLoad(object sender, EventArgs e)
	{
		StreamReader r = new StreamReader("Hrad.txt"); 
		for (int i = 0; i < 12; i++){
            string line = r.ReadLine();

            for (int j = 0; j < 20; j++)
                castle[i, j] = line[j];
        }
		string indyPos = r.ReadLine();
		indy = new Indy(Convert.ToInt16(indyPos.Split(' ')[0]),Convert.ToInt16(indyPos.Split(' ')[1]));

		r.Close(); 	
	}
	void MainFormPaint(object sender, PaintEventArgs e)
	{
		Graphics g = e.Graphics;
		for (int i = 0; i < 12; i++){
	        for (int j = 0; j < 20; j++){
	            char tile = castle[i, j];
	            Image img = null;
	            switch (tile){
	                case ' ':
	                    img = Image.FromFile("Volne0.png");
	                    break;
	                case '_':
	                    img = Image.FromFile("Volne1.png");
	                    break;
	                case '@':
	                    img = Image.FromFile("Tehla.png");
	                    break;
	                case '#':
	                    img = Image.FromFile("Rebrik.png");
	                    break;
	                case 'A':
	                    img = Image.FromFile("StenaA.png");
	                    break;
	                case 'B':
	                    img = Image.FromFile("StenaB.png");
	                    break;
	                case 'C':
	                    img = Image.FromFile("StenaC.png");
	                    break;
	            }
	
	            g.DrawImage(img, j * SIZE, i * SIZE, SIZE, SIZE);
	        }
	    }
	   	indy.Kresli(g);
	}

}
abstract class Entity{

	public int X,Y;
	public Entity(int nx,int ny){
		X = nx;
		Y = ny;
	}
    public abstract void Pohni(char[,] hrad);
    public abstract void Kresli(Graphics g);
}

class Indy: Entity{
	 public Indy(int nx, int ny) : base(nx, ny)
    {

    }
	public override void Pohni(char[,] castle){}
	public override void Kresli(Graphics g){
		g.DrawImage(Image.FromFile("Vpravo//0.png"), X, Y, 20, 20);
	}
}
