
partial class MainForm
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null) 
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.SuspendLayout();
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(961, 589);
		this.Name = "MainForm";
		this.Text = "Cvika06b";
		this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
		this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseUp);
		this.ResumeLayout(false);

	}

	public MainForm()
	{
		InitializeComponent();
	}
}
