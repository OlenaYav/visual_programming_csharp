using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;
using System.IO;//бібліотека для читання-запису в файл




namespace lab4_yavorskaO
{

	public partial class Form1 : Form
	{
		public Form1()
		{

			InitializeComponent();
			//дефолтні значення при загрузці,їх можна змінити ,але лише на цифри,далі буде обмеження вводу 
			//у відповідні текстбокси
			number.Text = "100";
			from.Text = "0";
			to.Text = "10";
			//gr = plot1.CreateGraphics();
			//gr2 = plot2.CreateGraphics();
			//створюємо об'єкти , де будемо малювати
			bmp = new Bitmap(plot1.Width, plot1.Height);
			gr = Graphics.FromImage(bmp);
			bmp2 = new Bitmap(plot1.Width, plot1.Height);
			gr2 = Graphics.FromImage(bmp2);


		}
		Bitmap bmp;
		Bitmap bmp2;
		Graphics gr;
		Graphics gr2;
		Font drawFont = new Font("Arial", 8);
		Font drawFont1 = new Font("Arial", 12);
		SolidBrush drawBrush = new SolidBrush(Color.Black);
		SolidBrush drawBrush1 = new SolidBrush(Color.Blue);
		SolidBrush drawBrush2 = new SolidBrush(Color.Red);
		SolidBrush drawBrush3 = new SolidBrush(Color.Green);
		StringFormat drawFormat = new StringFormat();
		Pen myPen = new Pen(Color.Black, 1.5f);
		Pen myPen1 = new Pen(Color.Blue, 1.5f);
		Pen myPen2 = new Pen(Color.Red, 1.5f);
		Pen myPen3 = new Pen(Color.Green, 1.5f);

		private void label4_Click(object sender, EventArgs e)
		{

		}


		private void button1_Click(object sender, EventArgs e)
		{//кнопка save data from datagrids to files
		 //записуємо дані з кожного "datagridview в окремий файл
			{
				string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
				StreamWriter sw1 = new StreamWriter(Path.Combine(docPath, "datagridview1.txt"));
				StreamWriter sw2 = new StreamWriter(Path.Combine(docPath, "datagridview2.txt"));
				string point = ";";//розділювач
				for (int i = 1; i < dataGridView1.RowCount; i++)
				{
					for (int j = 0; j < dataGridView1.ColumnCount; j++)
					{
						sw1.Write(Convert.ToString(dataGridView1[j, i].Value + point));
					}

				}
				for (int i = 1; i < dataGridView2.RowCount; i++)
				{
					for (int j = 0; j < dataGridView2.ColumnCount; j++)
					{
						sw2.Write(Convert.ToString(dataGridView2[j, i].Value + point));
					}
				}
			}
		}

		private void button_build_Click(object sender, EventArgs e)
		{
			
			//dataGridView1.Refresh();
			//очищаємо dataGridView,щоб при повторному натисканні на button_build будувалася заново таблиця значень
			//якщо робити лише dataGridView1.Refresh(),то нові значення додаватимуться після старих
			//якщо нічого не робити dataGridView не зміниться при зміні меж і графіків
			dataGridView1.Rows.Clear();
			dataGridView2.Rows.Clear();
			//очищаємо пікчербокси
			gr.Clear(Color.White);
			gr2.Clear(Color.White);
			double Xmin = double.Parse(from.Text);

			double Xmax = double.Parse(to.Text);
			
			//якщо введуть початок відрізка,більший за кінець
			if (Xmin > Xmax)
			{
				double temp;
				temp = Xmin;
				Xmin = Xmax;
				Xmax = temp;
			}

			int count = int.Parse(number.Text);//к-ість відрізків розбиття
											   //int count = 0;
											   //if (int.TryParse(number.Text, out count)) ;
			double Step;//крок,з яким рахуємо значення ф-ії в точках
			Step = (Math.Abs(Xmax - Xmin)) / count;//модуль,щоб не вибивало помилки,коли введуть поч відр ,більший за кінець
												   // Массив значень X – спільний для обох графіківв

			double[] x = new double[count];

			//  Масиви Y – по одному для кожного графіка

			double[] y1 = new double[count];
			double[] y2 = new double[count];
			double[] y3 = new double[count];
			double[] y4 = new double[count];
			double[] y5 = new double[count];
			// рахуєм точки для графіків функцій в циклі
			for (int i = 0; i < count; i++)

			{// вичисляємо Х на кожному кроці

				x[i] = Xmin + Step * i;
				// вичисляємо значення функцій в точках X
				//x(t)=t^1/3---->sign(t)*(abs(t))^1/3
				y1[i] = Math.Exp(-2 * x[i]) * Math.Pow(Math.Sin(x[i]), 2);//графік явно заданої функції
				y2[i] = Math.Sign(x[i]) * Math.Pow(Math.Abs(x[i]), 1.0 / 3.0);//x(t) для параметрично заданої функції
				y3[i] = Math.Sign(1 - x[i]) * Math.Pow(Math.Abs(1 - x[i]), 1.0 / 3.0);//y(t)
				y5[i] = Math.Sign(y3[i]) * Math.Pow(Math.Abs(y3[i]), 1.0 / 3.0);//x(y) для параметрично заданої функції
				y4[i] = Math.Sign(1 - y2[i]) * Math.Pow(Math.Abs(1 - y2[i]), 1.0 / 3.0);//y(x)

				//додаємо виведення іксів і значень функцій в них з кожного графіка у відповфдну dataGridView
				dataGridView1.Rows.Add(x[i], y1[i]);
				dataGridView2.Rows.Add(x[i], y2[i], y3[i], y4[i], y5[i]);

			}
			int scale = Convert.ToInt32(250 * 2 / (Xmax - Xmin));
			//int scale1 = Convert.ToInt32(50 * 2 / (Xmax - Xmin));
			int scale1 = Convert.ToInt32(50 * 2 / (Xmax - Xmin));
			
			//	МАЛЮВАННЯ ОСЕЙ
			
			if (Xmin < 0)
			{
				gr.DrawLine(myPen, new Point(Convert.ToInt32(-Xmin * scale), 100), new Point(Convert.ToInt32(-Xmin * scale), 300));//вісь у
				gr.DrawLine(myPen, new Point(0, 300), new Point(500, 300));//вісь х
				gr2.DrawLine(myPen, new Point(Convert.ToInt32(-Xmin * scale), 100), new Point(Convert.ToInt32(-Xmin * scale), 300));//вісь у
				gr2.DrawLine(myPen, new Point(0, 300), new Point(500, 300));//вісь х

			}
			else
			{
				gr.DrawLine(myPen, new Point(0, 0), new Point(0, 300));//вісь у
				gr.DrawLine(myPen, new Point(0, 300), new Point(500, 300));//вісь х
				gr2.DrawLine(myPen, new Point(0, 0), new Point(0, 300));//вісь у
				gr2.DrawLine(myPen, new Point(0, 300), new Point(500, 300));//вісь х
			}

			//ВЛАСНЕ МАЛЮВАННЯ ГРАФІКІВ
			for (int i = 0; i < x.Length - 1; i++)
			{
				gr.DrawLine(myPen, new Point(Convert.ToInt32((x[i] - Xmin) * scale), (-1) * Convert.ToInt32(y1[i] * scale) + 300), new Point(Convert.ToInt32((x[i + 1] - Xmin) * scale), (-1) * Convert.ToInt32(y1[i + 1] * scale) + 300));
				gr2.DrawLine(myPen, new Point(Convert.ToInt32((x[i] - Xmin) * scale1), (-1) * Convert.ToInt32(y2[i] * scale1) + 300), new Point(Convert.ToInt32((x[i + 1] - Xmin) * scale1), (-1) * Convert.ToInt32(y2[i + 1] * scale1) + 300));
				gr2.DrawLine(myPen1, new Point(Convert.ToInt32((x[i] - Xmin) * scale1), (-1) * Convert.ToInt32(y3[i] * scale1) + 300), new Point(Convert.ToInt32((x[i + 1] - Xmin) * scale1), (-1) * Convert.ToInt32(y3[i + 1] * scale1) + 300));
				gr2.DrawLine(myPen2, new Point(Convert.ToInt32((x[i] - Xmin) * scale1), (-1) * Convert.ToInt32(y4[i] * scale1) + 300), new Point(Convert.ToInt32((x[i + 1] - Xmin) * scale1), (-1) * Convert.ToInt32(y4[i + 1] * scale1) + 300));
				gr2.DrawLine(myPen3, new Point(Convert.ToInt32((x[i] - Xmin) * scale1), (-1) * Convert.ToInt32(y5[i] * scale1) + 300), new Point(Convert.ToInt32((x[i + 1] - Xmin) * scale1), (-1) * Convert.ToInt32(y5[i + 1] * scale1) + 300));

			}
			//ЛЕГЕНДА ДЛЯ ГРАФІКА 2 (БО ТАМ НЕЧІТКО)
			String drawString_1 = "x(t)";
			String drawString_2 = "y(t)";
			String drawString_3 = "x(y)";
			String drawString_4 = "y(x)";
			gr2.DrawLine(myPen, new Point(200, 130), new Point(220, 130));
			gr2.DrawLine(myPen1, new Point(200, 150), new Point(220, 150));
			gr2.DrawLine(myPen2, new Point(200, 170), new Point(220, 170));
			gr2.DrawLine(myPen3, new Point(200, 190), new Point(220, 190));
			gr2.DrawString(drawString_1, drawFont1, drawBrush, 220.0F, 120.0F, drawFormat);
			gr2.DrawString(drawString_2, drawFont1, drawBrush1, 220.0F, 140.0F, drawFormat);
			gr2.DrawString(drawString_3, drawFont1, drawBrush2, 220.0F, 160.0F, drawFormat);
			gr2.DrawString(drawString_4, drawFont1, drawBrush3, 220.0F, 180.0F, drawFormat);
			//gr2.DrawString(drawString_2, drawFont, drawBrush, 20.0F, 0.0F, drawFormat);
			//підписуємо осі
			pidpys(x, y1, gr);
			pidpys(x, y1, gr2);
			
			//заповняємо min i max для графіка 1 
			double y1_min = func_min(y1, count);
			min.Text = y1_min.ToString();
			double y1_max = func_max(y1, count);
			max.Text = y1_max.ToString();
			//заповняємо min i max для графіка 2
			double y2_min = func_min(y2, count);
			min_2.Text = y2_min.ToString();
			double y2_max = func_max(y2, count);
			max_2.Text = y2_max.ToString();
			//заповняємо min i max для графіка 3 
			double y3_min = func_min(y3, count);
			min_3.Text = y3_min.ToString();
			double y3_max = func_max(y3, count);
			max_3.Text = y3_max.ToString();
			//заповняємо min i max для графіка 4
			double y4_min = func_min(y4, count);
			min_4.Text = y4_min.ToString();
			double y4_max = func_max(y4, count);
			max_4.Text = y4_max.ToString();
			//заповняємо min i max для графіка 5 
			double y5_min = func_min(y5, count);
			min_5.Text = y5_min.ToString();
			double y5_max = func_max(y5, count);
			max_5.Text = y5_max.ToString();
			//вивільняємо
			//gr.Dispose();
			//gr2.Dispose();
			//відображає наші об'єкти бітмап на формі(якщо цього не зробити, в файл
			//зберігатимуться правильні рисунки, натомість на формі буде пустий пікчербокс
			plot1.Image = bmp;
			plot2.Image = bmp2;
		}
		
		private void pidpys(double []x, double[] y,Graphics graphics)
		{
			// Create point for upper-left corner of drawing.
              float point_y = 300.0F;
			float point_x = 0.0F;

			for (float i = 0; i <= (x.Length) ; i++)
			{
				// Draw string to screen.
				graphics.DrawString((i).ToString(), drawFont, drawBrush, i * 15.0F,  point_y, drawFormat);
				//int wX = plot1.Width;
				//int hX = plot1.Height;
			}
			for (float i = 0; i <= (y.Length); i++)
			{
				graphics.DrawString((i).ToString(), drawFont, drawBrush,  point_x, 300.0F-(i * 15.0F), drawFormat);
				
			}
			String drawString_x = "x";
			String drawString_y= "F";
			graphics.DrawString(drawString_x, drawFont, drawBrush, 250.0F,320.0F, drawFormat);
			graphics.DrawString(drawString_y, drawFont, drawBrush, 20.0F, 0.0F, drawFormat);
		}
		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
				
			FileInfo f = new FileInfo(@"C:\Users\Olena\source\repos\lab3_yavO\lab3_yavO\data.txt");//розташування моєї лр

			using (FileStream fs = f.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))//зчитує файл з даними
				{
					from.Text = sr.ReadLine();//перший рядок з файлу
					to.Text = sr.ReadLine();//другий,де я записала кінець відрізку
					number.Text = sr.ReadLine();//відповідно,третій рядок мого файлу


				}
			}
		}
		// всі KeyPress призн,щоб не дати ввести в текстбокси щось,крім цифр
		private void from_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8 && number != 44 && e.KeyChar != '-') // цифри, клавиша BackSpace и кома
			{
				e.Handled = true;
			}
		}

		private void to_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8 && number != 44 && e.KeyChar != '-') // цифри, клавиша BackSpace и кома
			{
				e.Handled = true;
			}
		}

		private void number_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8 && number != 44 && e.KeyChar != '-') // цифри, клавиша BackSpace и кома
			{
				e.Handled = true;
			}
		}

		private void plot2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//radioButton1.Checked = false;
			//початково нема читання з ф
		}

		private void plot2_Click_1(object sender, EventArgs e)
		{

		}

		private void plot1_Paint(object sender, PaintEventArgs e)
		{

		}
		//функція для збереження графіків у файл
		private void button2_Click(object sender, EventArgs e)
		{
			//plot1.Image.Save(@"F:\chart1.png", System.Drawing.Imaging.ImageFormat.Jpeg);
			bmp.Save(@"plot1.PNG", System.Drawing.Imaging.ImageFormat.Png);
			bmp2.Save(@"plot2.PNG", System.Drawing.Imaging.ImageFormat.Png);
			//plot1.Image.Save(@"plot1.PNG", System.Drawing.Imaging.ImageFormat.Png);
			//plot2.Image.Save(@"plot2.PNG", System.Drawing.Imaging.ImageFormat.Png);
		}

		//функція для визнач min f(x)
		private double func_min(double[] y, double count)
		{
			double y_min = y[0];
			for (int i = 0; i < count - 1; i++)
			{
				if (y[i] < y_min)
				{
					y_min = y[i];

				}
			}
			return y_min;
		}
		//функція для визнач максимуму f(x)
		private double func_max(double[] y, double count)
		{
			double y_max = y[0];
            for (int i = 0; i < count - 1; i++)
			{
				if (y[i] > y_max)
				{
					y_max = y[i];
				}
			}
			return y_max;
		}
		
	}
}
