using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Svg;
using System.Xml.Linq;
namespace lab7_yavorska
{
	public partial class Form1 : Form
	{
		private Settings settings;
		private readonly svg svg = new svg();
		//де зберігаємо
		string filepath = System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".svg";

		public Form1()
		{
			InitializeComponent();
			settings = Settings.Empty(pictureBox1.Bounds.Size);
			//максимальна/мінімальна висота/ширина, яку ми можемо задати
			//якщо задати більші/менші значення, ширина/висота буде максимом/мінімумом відповідно
			//тобто помилки не буде, буде значення в межах допустимого , найближче до введеного
			weight.Maximum = pictureBox1.Width;
			weight.Value = settings.Dimensions.Width;
			height.Maximum = pictureBox1.Height;
			height.Value = settings.Dimensions.Height;
			//візуалізація кольорів градієнту
			color1.BackColor = settings.ColorFrom;
			color2.BackColor = settings.ColorTo;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
		//ввід ширини нашого прямокутника
		private void weight_ValueChanged(object sender, EventArgs e)
		{
			settings.Dimensions.Width = Convert.ToInt32(weight.Value);
		}
		//ввід висоти нашого прямокутника
		private void height_ValueChanged(object sender, EventArgs e)
		{
			settings.Dimensions.Width = Convert.ToInt32(height.Value);
		}
		//зміна першого кольору градієнту
		private void color_1_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
			{
				color1.BackColor = colorDialog1.Color;
				settings.ColorFrom = colorDialog1.Color;
			}

		}
		//зміна 2 кольору градієнту
		private void color_2_Click(object sender, EventArgs e)
		{
			if (colorDialog2.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
			{ 
				color2.BackColor = colorDialog2.Color;
				settings.ColorTo = colorDialog2.Color;
			}
		}
		//власне побудова прямокутника і виведення xml
		private void build_button_Click(object sender, EventArgs e)
		{
			//pictureBox1.BackColor
			if (pictureBox1.Image != null)
			{
				//щоразу очищаємо пікчербокс перед побудовою прямок
				pictureBox1.Image.Dispose();
				pictureBox1.Image = null;
			}
			using (Graphics gr = pictureBox1.CreateGraphics())
			{//функції з файлу/класу xml, власне будують на основі наших параметрів 
				var rectangleSvg = svg.RectangleToSVG(settings, pictureBox1.Width, pictureBox1.Height, filepath);
				//richTextBox1.Text = rectangleSvg
                svg.RenderRectangle(gr, rectangleSvg);
				try
				{
					var xmlDoc = new XmlDocument
					{
						XmlResolver = null
					};
					xmlDoc.Load(filepath);
					//виводимо xml код для перегляду/редагування
					richTextBox1.Text = xmlDoc.InnerXml;
				}
				finally
				{
					richTextBox1.TextChanged += richTextBox1_TextChanged;
				}
			}

			
		}
		//перегляд в браузері
		private void in_browser_button_Click(object sender, EventArgs e)
		{
			if (File.Exists(filepath))
			{
				System.Diagnostics.Process.Start(filepath);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
		//при зміні xml на формі будується новий прямокутник
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			using (Graphics gr = pictureBox1.CreateGraphics())
			{
				var svgDoc = SvgDocument.FromSvg<SvgDocument>(richTextBox1.Text);
				svg.RenderRectangle(gr, svgDoc);
			}
		}
		//збереження xml з форми 
		private void button1_Click(object sender, EventArgs e)
		{
			var svgDoc = SvgDocument.FromSvg<SvgDocument>(richTextBox1.Text);
			//задання формату для збереження, без цього у файлу формату не буде, просто назва
			saveFileDialog1.Filter = "XML-File | *.xml";
			//з допомогою saveFileDialog зберігаємо,куди треба
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//svgDoc.Write(saveFileDialog1.FileName);
				svgDoc.Write(saveFileDialog1.FileName);

			}
		}
	}
}
