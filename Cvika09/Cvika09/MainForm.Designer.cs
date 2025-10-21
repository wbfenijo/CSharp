
partial class MainForm
{
	private System.ComponentModel.IContainer components = null;
	private System.Windows.Forms.TextBox textBox1;

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
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.SuspendLayout();
		// 
		// textBox1
		// 
		this.textBox1.Location = new System.Drawing.Point(336, 24);
		this.textBox1.Multiline = true;
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(128, 16);
		this.textBox1.TabIndex = 0;
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(500, 300);
		this.Controls.Add(this.textBox1);
		this.Name = "MainForm";
		this.Text = "Cvika09";
		this.Load += new System.EventHandler(this.MainFormLoad);
		this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
		this.ResumeLayout(false);
		this.PerformLayout();

	}

	public MainForm()
	{
		InitializeComponent();
	}
}
