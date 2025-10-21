using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	static readonly int hadaj = new Random().Next(100) + 1;
	void Button1Click(object sender, EventArgs e)
	{
		Graphics g = CreateGraphics();
		g.Clear(Color.White);
		Random rnd = new Random();
		int value = rnd.Next(6) + 1;
		if (value == 1){
			g.FillEllipse(Brushes.Red, 60, 60, 10, 10);
		}
		
		if (value == 2){
			g.FillEllipse(Brushes.Red, 25, 25, 10, 10);
			g.FillEllipse(Brushes.Red, 95, 95, 10, 10);
		}
		
		if (value == 3){
			g.FillEllipse(Brushes.Red, 60, 60, 10, 10);
			g.FillEllipse(Brushes.Red, 25, 25, 10, 10);
			g.FillEllipse(Brushes.Red, 95, 95, 10, 10);
		}
		
		if (value == 4){
			g.FillEllipse(Brushes.Red, 25, 25, 10, 10);
			g.FillEllipse(Brushes.Red, 95, 95, 10, 10);
			g.FillEllipse(Brushes.Red, 95, 25, 10, 10);
			g.FillEllipse(Brushes.Red, 25, 95, 10, 10);
		}
		
		if (value == 5){
			g.FillEllipse(Brushes.Red, 60, 60, 10, 10);
			g.FillEllipse(Brushes.Red, 25, 25, 10, 10);
			g.FillEllipse(Brushes.Red, 95, 95, 10, 10);
			g.FillEllipse(Brushes.Red, 95, 25, 10, 10);
			g.FillEllipse(Brushes.Red, 25, 95, 10, 10);
		}
		
		if (value == 6){
			g.FillEllipse(Brushes.Red, 25, 25, 10, 10);
			g.FillEllipse(Brushes.Red, 95, 95, 10, 10);
			g.FillEllipse(Brushes.Red, 95, 25, 10, 10);
			g.FillEllipse(Brushes.Red, 25, 95, 10, 10);
			g.FillEllipse(Brushes.Red, 25, 60, 10, 10);
			g.FillEllipse(Brushes.Red, 95, 60, 10, 10);			
		}
		
	}
	void TextBox1TextChanged(object sender, EventArgs e)
	{

		}
	void Button2Click(object sender, EventArgs e)
	{
		Graphics g = CreateGraphics();
		g.Clear(Color.White);
		Random rnd = new Random();
		int choice = rnd.Next(3);
		if(choice == 0){
			g.DrawString("kamen",new Font("Helvetica", 10),Brushes.Navy,120,25);
		}
		if(choice == 1){
			g.DrawString("papier",new Font("Helvetica", 10),Brushes.Navy,120,25);
		}
		if(choice == 2){
			g.DrawString("noznice",new Font("Helvetica", 10),Brushes.Navy,120,25);
		}
		string player = textBox1.Text;
		if (player == "k"){
			if (choice == 0){g.DrawString("Remiza",new Font("Helvetica", 20),Brushes.Navy,100,100);}
			if (choice == 1){g.DrawString("Prehral si",new Font("Helvetica", 20),Brushes.Navy,100,100);}
			if (choice == 2){g.DrawString("Vyhral si",new Font("Helvetica", 20),Brushes.Navy,100,100);}
			}
		if (player == "p"){
			if (choice == 0){g.DrawString("Vyhral si",new Font("Helvetica", 20),Brushes.Navy,100,100);}
			if (choice == 1){g.DrawString("Remiza",new Font("Helvetica", 20),Brushes.Navy,100,100);}
			if (choice == 2){g.DrawString("Prehral si",new Font("Helvetica", 20),Brushes.Navy,100,100);}
			}
		if (player == "n"){
			if (choice == 0){g.DrawString("Prehral si",new Font("Helvetica", 20),Brushes.Navy,100,100);}
			if (choice == 1){g.DrawString("Vyhral si",new Font("Helvetica", 20),Brushes.Navy,100,100);}
			if (choice == 2){g.DrawString("Remiza",new Font("Helvetica", 20),Brushes.Navy,100,100);}
			}
	}
	void TextBox2TextChanged(object sender, EventArgs e)
	{
		
	}
	void Button3Click(object sender, EventArgs e)
	{
		Graphics g = CreateGraphics();
		g.Clear(Color.White);
		int guess = Convert.ToInt16(textBox2.Text);
		if(guess == hadaj){
			g.DrawString("Gratulujem, uhádol si",new Font("Helvetica", 20),Brushes.Navy,100,100);
		}
		if(guess > hadaj){
			g.DrawString("Moje číslo je menšie",new Font("Helvetica", 20),Brushes.Navy,100,100);
		}
		if(guess < hadaj){
			g.DrawString("Moje číslo je väčšie",new Font("Helvetica", 20),Brushes.Navy,100,100);
		}
	}
	void TextBox3TextChanged(object sender, EventArgs e)
	{
		Graphics g = CreateGraphics();
		int hadam = 50;
		int min = 1;
		int max = 100;
		bool guessed = false;
		while (!guessed){
			label1.Text = Convert.ToString(hadam);
			if (textBox3.Text == "v"){
				min = hadam;
			}
			if (textBox3.Text == "m"){
				max = hadam;
			}
			if (textBox3.Text == "u"){
				guessed = true;
			}
			else{
				;}
			hadam = (min + max) / 2;
			textBox3.Clear();
		}
		g.DrawString("Vyhral PC",new Font("Helvetica", 20),Brushes.Navy,100,100);		
		
	}
	void Label1Click(object sender, EventArgs e)
	{
		
	}
}