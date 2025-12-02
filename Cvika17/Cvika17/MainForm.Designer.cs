
partial class MainForm
{
	private System.ComponentModel.IContainer components = null;
	private System.Windows.Forms.Timer timer1;

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
		this.components = new System.ComponentModel.Container();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.SuspendLayout();
		// 
		// timer1
		// 
		this.timer1.Enabled = true;
		this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(972, 524);
		this.Name = "MainForm";
		this.Text = "Cvika17";
		this.Load += new System.EventHandler(this.MainFormLoad);
		this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
		this.ResumeLayout(false);

	}

	public MainForm()
	{
		InitializeComponent();
	}
}
