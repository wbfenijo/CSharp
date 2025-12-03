using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form
{
	Vrchol hlava;
	void TextBox1TextChanged(object sender, EventArgs e)
	{
	
	}
	void Button1Click(object sender, EventArgs e)
	{
//		Prvok prvy = new Prvok("Norbert", new Prvok("Adam", new Prvok("David", null)));
//	    Prvok p;
//	    p = new Prvok("Norbert", new Prvok("Adam", new Prvok("David", null)));
//	    while (p != null )
//	    {
//	    	textBox1.AppendText(p.getValue());
//	        textBox1.AppendText(Environment.NewLine);
//	        p = p.getNext();
//	    }


		Graphics g = CreateGraphics();
		hlava.kresli(g);


	}
	void MainFormLoad(object sender, EventArgs e)
	{
		hlava = new Vrchol(null, 150, 10);
		Vrchol hrud = new Vrchol(hlava, 150, 30);
		Vrchol rukaL = new Vrchol(hrud, 125, 40);
		Vrchol rukaP = new Vrchol(hrud, 175, 40);
		Vrchol brucho = new Vrchol(hrud, 150, 100);
		Vrchol nohaL = new Vrchol(brucho, 125, 110);
		Vrchol nohaP = new Vrchol(brucho, 175, 110);
	}
	void MainFormMouseUp(object sender, MouseEventArgs e)
	{
		hlava.najdi(e.X, e.Y);
	}
}
class Prvok{
	string value;
	Prvok next;
	
	public Prvok(string ivalue, Prvok inext){
		value = ivalue;
		next = inext;
	}
	public string getValue(){
		return value;
	}
	
	public Prvok getNext(){
		return next;
	}

}

class Vrchol{
	Vrchol parent;
	List<Vrchol> children = new List<Vrchol>();
	int pX;
	int pY;
	public Vrchol(Vrchol iparent, int ipX, int ipY){
		parent = iparent;
		if (parent != null){
			parent.addChild(this);
		}
		pX = ipX;
		pY = ipY;
	}
	
	public Vrchol getParent(){
		return parent;
	}
	
	public void setParent(Vrchol iparent){
		parent = iparent;
	}
	
	public int getX(){
		return pX;
	}
	
	public void setX(int x){
		pX = x;
	}
	
	public void setY(int y){
		pY = y;
	}
	
	public int getY(){
		return pY;
	}
	
	public List<Vrchol> getChildren(){
		return children;
	}
	
	public void addChild(Vrchol child){
		children.Add(child);
	}
	
	public void kresli(Graphics g){
		g.FillEllipse(Brushes.Black, pX - 5, pY - 5, 10, 10);
		foreach (Vrchol child in children)
		{
			g.DrawLine(Pens.Black, pX, pY, child.getX(), child.getY());
			child.kresli(g);
		}
//		for (int i = 0; i < children.Count; i++){
//			g.DrawLine(Pens.Black, pX, pY, children[i].getX(), children[i].getY());
//			children[i].kresli(g);
//		}
	}
	
	public Vrchol najdi(int x, int y){
		if ((x > pX - 5 || x < pX + 5) && (y > pY - 5 || y < pY + 5)) return this;

		foreach (Vrchol child in children)
		{
			if (x < child.getX() - 5 || x > child.getX() + 5) return null;
			if (y < child.getY() - 5 || y > child.getY() + 5) return null;
			return child;
			
		}
		return null;
	}
}