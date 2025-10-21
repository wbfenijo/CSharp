using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	void Button1Click(object sender, EventArgs e)
	{
		textBox5.Text = Convert.ToString(Convert.ToInt16(textBox3.Text) + Convert.ToInt16(textBox4.Text));
	}
	void TextBox1TextChanged(object sender, EventArgs e)
	{
		textBox2.Text = "Ahoj " + textBox1.Text;
	}
	void Label1Click(object sender, EventArgs e)
	{

	}
	void TextBox5TextChanged(object sender, EventArgs e)
	{

	}
	void Button2Click(object sender, EventArgs e)
	{
		label8.Text = Convert.ToString((4 * Convert.ToInt16(textBox6.Text) + 4 * Convert.ToInt16(textBox7.Text) + Convert.ToInt16(textBox9.Text)) * Convert.ToInt16(textBox8.Text));
	}
	void TextBox8TextChanged(object sender, EventArgs e)
	{

	}
	void TextBox9TextChanged(object sender, EventArgs e)
	{

	}
}
