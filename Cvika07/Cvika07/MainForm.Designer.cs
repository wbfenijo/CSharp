
partial class MainForm
{
	private System.ComponentModel.IContainer components = null;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.Button button2;
	private System.Windows.Forms.Button button3;
	private System.Windows.Forms.Timer timer1;
	private System.Windows.Forms.Timer timer2;
	private System.Windows.Forms.Timer timer3;

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
		this.button1 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.timer2 = new System.Windows.Forms.Timer(this.components);
		this.timer3 = new System.Windows.Forms.Timer(this.components);
		this.SuspendLayout();
		// 
		// button1
		// 
		this.button1.Location = new System.Drawing.Point(16, 16);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(75, 23);
		this.button1.TabIndex = 0;
		this.button1.Text = "button1";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(this.Button1Click);
		// 
		// button2
		// 
		this.button2.Location = new System.Drawing.Point(96, 16);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(75, 23);
		this.button2.TabIndex = 1;
		this.button2.Text = "button2";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(this.Button2Click);
		// 
		// button3
		// 
		this.button3.Location = new System.Drawing.Point(176, 16);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(75, 23);
		this.button3.TabIndex = 2;
		this.button3.Text = "button3";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(this.Button3Click);
		// 
		// timer1
		// 
		this.timer1.Enabled = true;
		this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
		// 
		// timer2
		// 
		this.timer2.Enabled = true;
		this.timer2.Interval = 150;
		// 
		// timer3
		// 
		this.timer3.Enabled = true;
		this.timer3.Interval = 200;
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(500, 300);
		this.Controls.Add(this.button3);
		this.Controls.Add(this.button2);
		this.Controls.Add(this.button1);
		this.Name = "MainForm";
		this.Text = "Cvika07";
		this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
		this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseMove);
		this.ResumeLayout(false);

	}

	public MainForm()
	{
		InitializeComponent();
	}
}
