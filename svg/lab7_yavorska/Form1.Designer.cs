namespace lab7_yavorska
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.weight_label = new System.Windows.Forms.Label();
			this.height_label = new System.Windows.Forms.Label();
			this.weight = new System.Windows.Forms.NumericUpDown();
			this.height = new System.Windows.Forms.NumericUpDown();
			this.color_1 = new System.Windows.Forms.Button();
			this.color_2 = new System.Windows.Forms.Button();
			this.color1 = new System.Windows.Forms.TextBox();
			this.color2 = new System.Windows.Forms.TextBox();
			this.build_button = new System.Windows.Forms.Button();
			this.in_browser_button = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.colorDialog2 = new System.Windows.Forms.ColorDialog();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.save = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// weight_label
			// 
			this.weight_label.AutoSize = true;
			this.weight_label.Location = new System.Drawing.Point(62, 44);
			this.weight_label.Name = "weight_label";
			this.weight_label.Size = new System.Drawing.Size(38, 13);
			this.weight_label.TabIndex = 0;
			this.weight_label.Text = "weight";
			// 
			// height_label
			// 
			this.height_label.AutoSize = true;
			this.height_label.Location = new System.Drawing.Point(62, 70);
			this.height_label.Name = "height_label";
			this.height_label.Size = new System.Drawing.Size(36, 13);
			this.height_label.TabIndex = 1;
			this.height_label.Text = "height";
			this.height_label.Click += new System.EventHandler(this.label2_Click);
			// 
			// weight
			// 
			this.weight.Location = new System.Drawing.Point(121, 44);
			this.weight.Name = "weight";
			this.weight.Size = new System.Drawing.Size(120, 20);
			this.weight.TabIndex = 2;
			this.weight.ValueChanged += new System.EventHandler(this.weight_ValueChanged);
			// 
			// height
			// 
			this.height.Location = new System.Drawing.Point(121, 70);
			this.height.Name = "height";
			this.height.Size = new System.Drawing.Size(120, 20);
			this.height.TabIndex = 3;
			this.height.ValueChanged += new System.EventHandler(this.height_ValueChanged);
			// 
			// color_1
			// 
			this.color_1.Location = new System.Drawing.Point(65, 107);
			this.color_1.Name = "color_1";
			this.color_1.Size = new System.Drawing.Size(75, 23);
			this.color_1.TabIndex = 4;
			this.color_1.Text = "color 1 ";
			this.color_1.UseVisualStyleBackColor = true;
			this.color_1.Click += new System.EventHandler(this.color_1_Click);
			// 
			// color_2
			// 
			this.color_2.Location = new System.Drawing.Point(65, 149);
			this.color_2.Name = "color_2";
			this.color_2.Size = new System.Drawing.Size(75, 23);
			this.color_2.TabIndex = 5;
			this.color_2.Text = "color 2";
			this.color_2.UseVisualStyleBackColor = true;
			this.color_2.Click += new System.EventHandler(this.color_2_Click);
			// 
			// color1
			// 
			this.color1.Location = new System.Drawing.Point(146, 109);
			this.color1.Name = "color1";
			this.color1.ReadOnly = true;
			this.color1.Size = new System.Drawing.Size(95, 20);
			this.color1.TabIndex = 6;
			// 
			// color2
			// 
			this.color2.Location = new System.Drawing.Point(146, 149);
			this.color2.Name = "color2";
			this.color2.ReadOnly = true;
			this.color2.Size = new System.Drawing.Size(95, 20);
			this.color2.TabIndex = 7;
			// 
			// build_button
			// 
			this.build_button.Location = new System.Drawing.Point(449, 415);
			this.build_button.Name = "build_button";
			this.build_button.Size = new System.Drawing.Size(75, 23);
			this.build_button.TabIndex = 8;
			this.build_button.Text = "build";
			this.build_button.UseVisualStyleBackColor = true;
			this.build_button.Click += new System.EventHandler(this.build_button_Click);
			// 
			// in_browser_button
			// 
			this.in_browser_button.Location = new System.Drawing.Point(530, 415);
			this.in_browser_button.Name = "in_browser_button";
			this.in_browser_button.Size = new System.Drawing.Size(160, 23);
			this.in_browser_button.TabIndex = 9;
			this.in_browser_button.Text = "open in browser";
			this.in_browser_button.UseVisualStyleBackColor = true;
			this.in_browser_button.Click += new System.EventHandler(this.in_browser_button_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(3, 203);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(377, 235);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(497, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(291, 397);
			this.richTextBox1.TabIndex = 11;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(696, 415);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(92, 23);
			this.save.TabIndex = 12;
			this.save.Text = "save xml";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.save);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.in_browser_button);
			this.Controls.Add(this.build_button);
			this.Controls.Add(this.color2);
			this.Controls.Add(this.color1);
			this.Controls.Add(this.color_2);
			this.Controls.Add(this.color_1);
			this.Controls.Add(this.height);
			this.Controls.Add(this.weight);
			this.Controls.Add(this.height_label);
			this.Controls.Add(this.weight_label);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label weight_label;
		private System.Windows.Forms.Label height_label;
		private System.Windows.Forms.NumericUpDown weight;
		private System.Windows.Forms.NumericUpDown height;
		private System.Windows.Forms.Button color_1;
		private System.Windows.Forms.Button color_2;
		private System.Windows.Forms.TextBox color1;
		private System.Windows.Forms.TextBox color2;
		private System.Windows.Forms.Button build_button;
		private System.Windows.Forms.Button in_browser_button;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ColorDialog colorDialog2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

