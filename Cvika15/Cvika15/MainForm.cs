using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using OpenGL4NET;

partial class MainForm : Form
{
    RenderingContext rc;
    Random rnd;
    void MainFormLoad(object sender, EventArgs e)
    {
    	rnd = new Random();
        double d = Math.Tan(60 * Math.PI / 360);
        double r = 1.0 * ClientSize.Width / ClientSize.Height;
        rc = RenderingContext.CreateContext(this);
        gl.Viewport(0, 0, ClientSize.Width, ClientSize.Height);
        gl.MatrixMode(GL.PROJECTION);
        gl.Frustum(-d * r, d * r, -d, +d, 1, 1000);
        gl.MatrixMode(GL.MODELVIEW);
        gl.ClearDepth(1);
        gl.Enable(GL.DEPTH_TEST);
    }
    double uhol = 0;
   
    void Button1Click(object sender, EventArgs e)
    {
        gl.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
        gl.LoadIdentity();
        gl.Translated(0, 0, -5);
        gl.Rotated(uhol, 0, 1, 0);
        gl.Begin(GL.TRIANGLES);
        for (int i = 0; i < 10; i++){
        	gl.Color3d(rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2));
	        gl.Vertex3d(0, 0, 0);
	        gl.Color3d(rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2));
	        gl.Vertex3d(rnd.Next(-4, 5), rnd.Next(-4,5), rnd.Next(5));
	        gl.Color3d(rnd.Next(0,2), rnd.Next(0,2), rnd.Next(0,2));
	        gl.Vertex3d(rnd.Next(-4, 5), rnd.Next(-4,5), rnd.Next(5));       	
        }

        gl.End();
        rc.SwapBuffers();
        uhol = uhol + 10;
    }
	void Timer1Tick(object sender, EventArgs e)
	{
		Button1Click(sender, e);
	}
}
