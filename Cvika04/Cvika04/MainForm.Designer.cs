
partial class MainForm
{
	private System.ComponentModel.IContainer components = null;
	private System.Windows.Forms.Button button1;

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
		this.button1 = new System.Windows.Forms.Button();
		this.SuspendLayout();
		// 
		// button1
		// 
		this.button1.Location = new System.Drawing.Point(8, 8);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(75, 23);
		this.button1.TabIndex = 0;
		this.button1.Text = "button1";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(this.Button1Click);
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(899, 469);
		this.Controls.Add(this.button1);
		this.Name = "MainForm";
		this.Text = "Cvika04";
		this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
		this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
		this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseMove);
		this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseUp);
		this.ResumeLayout(false);

	}

	public MainForm()
	{
		InitializeComponent();
	}
}
