
partial class MainForm
{
	private System.ComponentModel.IContainer components = null;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.TextBox textBox1;
	private System.Windows.Forms.Button button2;
	private System.Windows.Forms.TextBox textBox2;
	private System.Windows.Forms.Button button3;
	private System.Windows.Forms.TextBox textBox3;
	private System.Windows.Forms.Label label1;

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
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.button2 = new System.Windows.Forms.Button();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.button3 = new System.Windows.Forms.Button();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.SuspendLayout();
		// 
		// button1
		// 
		this.button1.Location = new System.Drawing.Point(0, 0);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(136, 23);
		this.button1.TabIndex = 0;
		this.button1.Text = "Hod kockou";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(this.Button1Click);
		// 
		// textBox1
		// 
		this.textBox1.Location = new System.Drawing.Point(144, 0);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(100, 22);
		this.textBox1.TabIndex = 1;
		this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
		// 
		// button2
		// 
		this.button2.Location = new System.Drawing.Point(256, 0);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(75, 23);
		this.button2.TabIndex = 2;
		this.button2.Text = "Hraj";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(this.Button2Click);
		// 
		// textBox2
		// 
		this.textBox2.Location = new System.Drawing.Point(0, 24);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new System.Drawing.Size(100, 22);
		this.textBox2.TabIndex = 3;
		this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
		// 
		// button3
		// 
		this.button3.Location = new System.Drawing.Point(104, 24);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(75, 23);
		this.button3.TabIndex = 4;
		this.button3.Text = "Hadaj";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(this.Button3Click);
		// 
		// textBox3
		// 
		this.textBox3.Location = new System.Drawing.Point(232, 24);
		this.textBox3.Name = "textBox3";
		this.textBox3.Size = new System.Drawing.Size(100, 22);
		this.textBox3.TabIndex = 5;
		this.textBox3.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
		// 
		// label1
		// 
		this.label1.Location = new System.Drawing.Point(336, 24);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(100, 23);
		this.label1.TabIndex = 6;
		this.label1.Text = "50";
		this.label1.Click += new System.EventHandler(this.Label1Click);
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(486, 453);
		this.Controls.Add(this.label1);
		this.Controls.Add(this.textBox3);
		this.Controls.Add(this.button3);
		this.Controls.Add(this.textBox2);
		this.Controls.Add(this.button2);
		this.Controls.Add(this.textBox1);
		this.Controls.Add(this.button1);
		this.Name = "MainForm";
		this.Text = "Cvika03";
		this.ResumeLayout(false);
		this.PerformLayout();

	}

	public MainForm()
	{
		InitializeComponent();
	}
}
