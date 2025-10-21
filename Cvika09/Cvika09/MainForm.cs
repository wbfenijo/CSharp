using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{

	
	void MainFormLoad(object sender, EventArgs e)
	{
//		StreamWriter w = new StreamWriter("kamarati.txt");
//		w.WriteLine("Samuel Hebort");                           
//		w.WriteLine("Tomas Hronsky");
//		w.WriteLine("Norbert Benko");
//		w.Close(); 
		
//		StreamWriter w1 = new StreamWriter("tabulka.txt");
//		double x = 0;
//		while (x <= 2 * Math.PI){
//			w1.WriteLine("{0} {1} {2}", x, Math.Sin(x), Math.Cos(x) );
//			x += 0.1;
//		}
//		w1.Close();
//		
//		
//		StreamReader r = new StreamReader("kamarati.txt");         
//		while (!r.EndOfStream)                                  
//		{
//		    textBox1.AppendText(r.ReadLine());                  
//		    textBox1.AppendText(Environment.NewLine);           
//		}
//		r.Close(); 
//		
//		StreamReader r1 = new StreamReader("cisla.txt"); 
//		int pocet = 0;
//		int sucet = 0;
//		while (!r1.EndOfStream)                                  
//		{
//			sucet += Convert.ToInt16(r1.ReadLine());
//			pocet += 1 ;	            
//		}
//		textBox1.AppendText(Convert.ToString(sucet/pocet));
//		textBox1.AppendText(Environment.NewLine);   
//		r1.Close(); 
		

	}
	void MainFormPaint(object sender, PaintEventArgs e)
	{
//		StreamReader r2 = new StreamReader("obrazok.txt"); 
//		while (!r2.EndOfStream)                                  
//		{
//			
//			string [] kok = r2.ReadLine().Split(' ');
//			if (kok.Length != 4) continue;
//			int x1 = Convert.ToInt16(kok[0]);
//			int y1 = Convert.ToInt16(kok[1]);
//			int x2 = Convert.ToInt16(kok[2]);
//			int y2 = Convert.ToInt16(kok[3]);
//			e.Graphics.DrawLine(Pens.Red, x1, y1, x2, y2);
//		}  
//		r2.Close(); 
		
		StreamReader r2 = new StreamReader("mozaika.txt"); 
		for (int i = 0; i < 10; i++)
		{
			char [] riadok = new char[10];
			int k = 0;
			int SIZE = 20;
			foreach (char znak in r2.ReadLine())
			{
				riadok[k] = znak;
				k += 1;
			}
			for (int j = 0; j < 10; j++){
				e.Graphics.FillRectangle(riadok[j] == '.'? Brushes.White: riadok[j] == 'c'? Brushes.Red: Brushes.Yellow, j * SIZE, i * SIZE, SIZE, SIZE);
				e.Graphics.DrawRectangle(Pens.Black, j * SIZE, i * SIZE, SIZE, SIZE);
			}
		}  
		r2.Close(); 
	}       

}
