using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using OpenGL4NET;

partial class MainForm : Form
{
	RenderingContext rc;
	Random rnd;
	int uhol = 0;

	void MainFormLoad(object sender, EventArgs e)
	{
        double d = Math.Tan(60 * Math.PI / 360);
        double r = 1.0 * ClientSize.Width / ClientSize.Height;
        rc = RenderingContext.CreateContext(this);
        gl.Viewport(0, 0, ClientSize.Width, ClientSize.Height);
        gl.MatrixMode(GL.PROJECTION);
        gl.Frustum(-d * r, d * r, -d, +d, 1, 1000);
        gl.MatrixMode(GL.MODELVIEW);
        gl.ClearDepth(1);
        gl.Enable(GL.DEPTH_TEST);
		rnd = new Random();
	}
	void Timer1Tick(object sender, EventArgs e)
	{
		gl.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
		gl.LoadIdentity();
		gl.PushMatrix(); 
		gl.Translated(2, 2, -10);
		gl.Rotated(uhol, 1, 0, 0);

		gl.Begin(GL.TRIANGLES);
		
		//pravy horny

		gl.Color3d(1, 0, 0);
		gl.Vertex3d(0, 1, -10);
		gl.Color3d(1, 0, -0);
		gl.Vertex3d(-1,0,-10);
		gl.Color3d(1, 0, 0);
		gl.Vertex3d(1,0,-10);
		
//		//lavy dolny
//		gl.Rotated(uhol, 0, 1, 0);
//		gl.Color3d(1, 0, 0);
//		gl.Vertex3d(-2, -2, -5);
//		gl.Color3d(1, 0, -5);
//		gl.Vertex3d(-1,-1,0);
//		gl.Color3d(1, 0, -5);
//		gl.Vertex3d(-2,-3,0);
//		
//		//pravy dolny
//		gl.Rotated(uhol, 1, 0, 0);
//		gl.Color3d(1, 0, 0);
//		gl.Vertex3d(2, -2, -5);
//		gl.Color3d(1, 0, -5);
//		gl.Vertex3d(1,-3,0);
//		gl.Color3d(1, 0, -5);
//		gl.Vertex3d(3,-3,0);
//		
//		//lavy horny
//		gl.Rotated(uhol, 1, 0, 0);
//		gl.Color3d(1, 0, 0);
//		gl.Vertex3d(-2, +2, -5);
//		gl.Color3d(1, 0, -5);
//		gl.Vertex3d(-3,+1,0);
//		gl.Color3d(1, 0, -5);
//		gl.Vertex3d(-1,+1,0);
//		
//		//stredny trojuholnik
//		gl.Rotated(uhol, 0, 0, 1);
//		gl.Color3d(1, 0, 0);
//		gl.Vertex3d(-1, 0, -5);
//		gl.Color3d(1, 0, -5);
//		gl.Vertex3d(0,+1,0);
//		gl.Color3d(0, 1, -5);
//		gl.Vertex3d(0,3,0);
	

		gl.End();
		gl.PopMatrix();
		rc.SwapBuffers();
		uhol = uhol + 10;
	}
	void MainFormPaint(object sender, PaintEventArgs e)
	{

	}
}
