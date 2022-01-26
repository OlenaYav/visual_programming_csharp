namespace lab4_yavorskaO
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.plot1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.max = new System.Windows.Forms.TextBox();
			this.min = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.plot2 = new System.Windows.Forms.PictureBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.min_5 = new System.Windows.Forms.TextBox();
			this.max_4 = new System.Windows.Forms.TextBox();
			this.min_4 = new System.Windows.Forms.TextBox();
			this.max_3 = new System.Windows.Forms.TextBox();
			this.min_3 = new System.Windows.Forms.TextBox();
			this.max_5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.max_2 = new System.Windows.Forms.TextBox();
			this.min_2 = new System.Windows.Forms.TextBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.from = new System.Windows.Forms.TextBox();
			this.to = new System.Windows.Forms.TextBox();
			this.number = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button_build = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.plot1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.plot2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(621, 426);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.plot1);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.max);
			this.tabPage1.Controls.Add(this.min);
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(613, 400);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "function";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// plot1
			// 
			this.plot1.Location = new System.Drawing.Point(6, 11);
			this.plot1.Name = "plot1";
			this.plot1.Size = new System.Drawing.Size(285, 383);
			this.plot1.TabIndex = 7;
			this.plot1.TabStop = false;
			this.plot1.Paint += new System.Windows.Forms.PaintEventHandler(this.plot1_Paint);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(485, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "max";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(343, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "min";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// max
			// 
			this.max.Location = new System.Drawing.Point(488, 198);
			this.max.Name = "max";
			this.max.Size = new System.Drawing.Size(48, 20);
			this.max.TabIndex = 2;
			// 
			// min
			// 
			this.min.Location = new System.Drawing.Point(346, 198);
			this.min.Name = "min";
			this.min.Size = new System.Drawing.Size(48, 20);
			this.min.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.dataGridView1.Location = new System.Drawing.Point(346, 224);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "x";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "f(x)";
			this.Column2.Name = "Column2";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.plot2);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.min_5);
			this.tabPage2.Controls.Add(this.max_4);
			this.tabPage2.Controls.Add(this.min_4);
			this.tabPage2.Controls.Add(this.max_3);
			this.tabPage2.Controls.Add(this.min_3);
			this.tabPage2.Controls.Add(this.max_5);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.max_2);
			this.tabPage2.Controls.Add(this.min_2);
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(613, 400);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "parametric_function";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// plot2
			// 
			this.plot2.Location = new System.Drawing.Point(3, 6);
			this.plot2.Name = "plot2";
			this.plot2.Size = new System.Drawing.Size(264, 388);
			this.plot2.TabIndex = 21;
			this.plot2.TabStop = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(441, 73);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(46, 13);
			this.label13.TabIndex = 20;
			this.label13.Text = "max_y(t)";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(441, 138);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 13);
			this.label12.TabIndex = 19;
			this.label12.Text = "max_y(x)";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(441, 199);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 13);
			this.label11.TabIndex = 18;
			this.label11.Text = "max_x(y)";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(364, 70);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(43, 13);
			this.label10.TabIndex = 17;
			this.label10.Text = "min_y(t)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(364, 133);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "min_y(x)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(366, 199);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "min_x(y)";
			// 
			// min_5
			// 
			this.min_5.Location = new System.Drawing.Point(367, 215);
			this.min_5.Name = "min_5";
			this.min_5.Size = new System.Drawing.Size(44, 20);
			this.min_5.TabIndex = 14;
			// 
			// max_4
			// 
			this.max_4.Location = new System.Drawing.Point(444, 154);
			this.max_4.Name = "max_4";
			this.max_4.Size = new System.Drawing.Size(44, 20);
			this.max_4.TabIndex = 13;
			// 
			// min_4
			// 
			this.min_4.Location = new System.Drawing.Point(367, 154);
			this.min_4.Name = "min_4";
			this.min_4.Size = new System.Drawing.Size(44, 20);
			this.min_4.TabIndex = 12;
			// 
			// max_3
			// 
			this.max_3.Location = new System.Drawing.Point(444, 86);
			this.max_3.Name = "max_3";
			this.max_3.Size = new System.Drawing.Size(44, 20);
			this.max_3.TabIndex = 11;
			// 
			// min_3
			// 
			this.min_3.Location = new System.Drawing.Point(363, 86);
			this.min_3.Name = "min_3";
			this.min_3.Size = new System.Drawing.Size(44, 20);
			this.min_3.TabIndex = 10;
			// 
			// max_5
			// 
			this.max_5.Location = new System.Drawing.Point(445, 215);
			this.max_5.Name = "max_5";
			this.max_5.Size = new System.Drawing.Size(44, 20);
			this.max_5.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(441, 11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "max_x(t)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(358, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "min_x(t)";
			// 
			// max_2
			// 
			this.max_2.Location = new System.Drawing.Point(444, 27);
			this.max_2.Name = "max_2";
			this.max_2.Size = new System.Drawing.Size(44, 20);
			this.max_2.TabIndex = 4;
			// 
			// min_2
			// 
			this.min_2.Location = new System.Drawing.Point(361, 27);
			this.min_2.Name = "min_2";
			this.min_2.Size = new System.Drawing.Size(46, 20);
			this.min_2.TabIndex = 3;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView2.Location = new System.Drawing.Point(306, 277);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(301, 114);
			this.dataGridView2.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "x";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "x(t)";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "y(t)";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "y(x)";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "x(y)";
			this.Column5.Name = "Column5";
			// 
			// from
			// 
			this.from.Location = new System.Drawing.Point(693, 61);
			this.from.Name = "from";
			this.from.Size = new System.Drawing.Size(62, 20);
			this.from.TabIndex = 1;
			this.from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.from_KeyPress);
			// 
			// to
			// 
			this.to.Location = new System.Drawing.Point(694, 100);
			this.to.Name = "to";
			this.to.Size = new System.Drawing.Size(62, 20);
			this.to.TabIndex = 2;
			this.to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.to_KeyPress);
			// 
			// number
			// 
			this.number.Location = new System.Drawing.Point(693, 139);
			this.number.Name = "number";
			this.number.Size = new System.Drawing.Size(62, 20);
			this.number.TabIndex = 3;
			this.number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(691, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "from";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(691, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "to";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(691, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "number";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(693, 165);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(61, 17);
			this.radioButton1.TabIndex = 7;
			this.radioButton1.Text = "from file";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(693, 188);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 90);
			this.button1.TabIndex = 8;
			this.button1.Text = "save data from datagrids to files";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(693, 311);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 32);
			this.button2.TabIndex = 9;
			this.button2.Text = "save photos";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button_build
			// 
			this.button_build.Location = new System.Drawing.Point(693, 376);
			this.button_build.Name = "button_build";
			this.button_build.Size = new System.Drawing.Size(75, 32);
			this.button_build.TabIndex = 10;
			this.button_build.Text = "build";
			this.button_build.UseVisualStyleBackColor = true;
			this.button_build.Click += new System.EventHandler(this.button_build_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button_build);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.number);
			this.Controls.Add(this.to);
			this.Controls.Add(this.from);
			this.Controls.Add(this.tabControl1);
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.plot1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.plot2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox max;
		private System.Windows.Forms.TextBox min;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox from;
		private System.Windows.Forms.TextBox to;
		private System.Windows.Forms.TextBox number;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button_build;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox max_2;
		private System.Windows.Forms.TextBox min_2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.PictureBox plot1;
		private System.Windows.Forms.TextBox min_5;
		private System.Windows.Forms.TextBox max_4;
		private System.Windows.Forms.TextBox min_4;
		private System.Windows.Forms.TextBox max_3;
		private System.Windows.Forms.TextBox min_3;
		private System.Windows.Forms.TextBox max_5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox plot2;
	}
}

