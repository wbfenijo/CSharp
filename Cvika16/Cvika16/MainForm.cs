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
	dynamic[] vrcholy = {
		new {x = -1, y = +1, z = +1},
		new {x = +1, y = +1, z = +1},
		new {x = +1, y = -1, z = +1},
		new {x = -1, y = -1, z = +1},
		new {x = -1, y = +1, z = -1},
		new {x = +1, y = +1, z = -1},
		new {x = +1, y = -1, z = -1},
		new {x = -1, y = -1, z = -1}
	};

	dynamic[] steny = {
		new {indexy = new []{0, 1, 2, 3}, r = 1, g = 0, b = 0},
		new {indexy = new []{4, 5, 6, 7}, r = 1, g = 1, b = 0},
		new {indexy = new []{0, 1, 5, 4}, r = 0, g = 1, b = 0},
		new {indexy = new []{3, 2, 6, 7}, r = 0, g = 1, b = 1},
		new {indexy = new []{0, 3, 7, 4}, r = 0, g = 0, b = 1},
		new {indexy = new []{1, 2, 6, 5}, r = 1, g = 0, b = 1}
	};

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
		Invalidate();
	}
	void MainFormPaint(object sender, PaintEventArgs e)
	{
		gl.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
		gl.LoadIdentity();
		gl.Translated(0, 0, -5);
		gl.Rotated(uhol, 0, 1, 0);
		gl.Begin(GL.TRIANGLES);
		gl.Color3d(1, 0, 0);
		gl.Vertex3d(0, 0, 0);
		gl.Color3d(1, 0, 0);
		gl.Vertex3d(-1,+1,0);
		gl.Color3d(0, 0, 1);
		gl.Vertex3d(0,3,0);
	

		gl.End();
		rc.SwapBuffers();
		uhol = uhol + 10;
	}
}
