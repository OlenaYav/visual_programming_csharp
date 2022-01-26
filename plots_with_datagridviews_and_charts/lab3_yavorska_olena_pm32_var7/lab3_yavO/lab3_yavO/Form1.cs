using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;//бібліотека для читання-запису в файл



namespace lab3_yavO
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{//дефолтні значення при загрузці,їх можна змінити ,але лише на цифри,далі буде обмеження вводу 
		 //у відповідні текстбокси
			number.Text = "100";
			from.Text = "-10";
			to.Text = "10";

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void chart1_Click(object sender, EventArgs e)
		{

		}

		private void to_TextChanged(object sender, EventArgs e)
		{

		}

		private void button_build_Click(object sender, EventArgs e)
		{
			//dataGridView1.Refresh();
			//очищаємо dataGridView,щоб при повторному натисканні на button_build будувалася заново таблиця значень
			//якщо робити лише dataGridView1.Refresh(),то нові значення додаватимуться після старих
			//якщо нічого не робити dataGridView не зміниться при зміні меж і графіків
			dataGridView1.Rows.Clear();
			dataGridView2.Rows.Clear();
			dataGridView3.Rows.Clear();
			dataGridView4.Rows.Clear();
			dataGridView5.Rows.Clear();
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
			//підписуємо осі
			//в кожного графіка на кожній вкладці підписуємо осі x i f(x)
			string ax = "x";
			string ay = "f(x)";
			chart1.ChartAreas[0].AxisX.Title = ax;
			chart1.ChartAreas[0].AxisY.Title = ay;
			chart2.ChartAreas[0].AxisX.Title = ax;
			chart2.ChartAreas[0].AxisY.Title = ay;
			chart3.ChartAreas[0].AxisX.Title = ax;
			chart3.ChartAreas[0].AxisY.Title = ay;
			chart4.ChartAreas[0].AxisX.Title = ax;
			chart4.ChartAreas[0].AxisY.Title = ay;
			chart5.ChartAreas[0].AxisX.Title = ax;
			chart5.ChartAreas[0].AxisY.Title = ay;
			//  Масиви Y – по одному для кожного графіка

			double[] y1 = new double[count];
			double[] y2 = new double[count];
			double[] y3 = new double[count];
			double[] y4 = new double[count];
			double[] y5 = new double[count];
			double[] y_x = new double[count];
			double[] x_y = new double[count];
			double[] one = new double[count];
			double[] one_minus_y = new double[count];
			double[] one_minus_y_1 = new double[count];
			// рахуєм точки для графіків функцій в циклі
			for (int i = 0; i < count; i++)

			{// вичисляємо Х на кожному кроці

				x[i] = Xmin + Step * i;
				// вичисляємо значення функцій в точках X
				//x(t)=t^1/3---->sign(t)*(abs(t))^1/3
				//ПЕРЕРОБИЛО ЗГ ЛЕКЦІЇ 21.04
				//дороблено t=x^3;t=1-y^3
				//t-x, x(t)-y2,y(t)-y3,x(y)-y4,y(x)-y5
				y1[i] = Math.Exp(-2 * x[i]) * Math.Pow(Math.Sin(x[i]), 2);//графік явно заданої функції
				y2[i] = Math.Sign(x[i]) * Math.Pow(Math.Abs(x[i]), 1.0 / 3.0);//x(t) для параметрично заданої функції
				y3[i] = Math.Sign(1 - x[i]) * Math.Pow(Math.Abs(1 - x[i]), 1.0 / 3.0);//y(t)
				y5[i] = Math.Sign(y3[i]) * Math.Pow(Math.Abs(y3[i]), 1.0 / 3.0);//x(y) для параметрично заданої функції
				y4[i] = Math.Sign(1 - y2[i]) * Math.Pow(Math.Abs(1 - y2[i]), 1.0 / 3.0);//y(x)




				//додаємо виведення іксів і значень функцій в них з кожного графіка у відповфдну dataGridView
				dataGridView1.Rows.Add(x[i], y1[i]);
				dataGridView2.Rows.Add(x[i], y2[i]);
				dataGridView3.Rows.Add(x[i], y3[i]);
				dataGridView4.Rows.Add(y2[i], y4[i]);
				dataGridView5.Rows.Add(y3[i], y5[i]);
				//dataGridView5.Rows.Add(x_y[i], y3[i]);
				//dataGridView1.Rows[0].Cells[i].Value = x[i];
				// Настроюєм осі графіка, для кожного графіка на кожній  вкладці додаємо підписи осей :x i f(x)
				chart1.ChartAreas[0].AxisX.Minimum = Xmin;
				chart1.ChartAreas[0].AxisX.Maximum = Xmax;
				chart2.ChartAreas[0].AxisX.Minimum = Xmin;
				chart2.ChartAreas[0].AxisX.Maximum = Xmax;
				chart3.ChartAreas[0].AxisX.Minimum = Xmin;
				chart3.ChartAreas[0].AxisX.Maximum = Xmax;
				chart4.ChartAreas[0].AxisX.Minimum = Xmin;
				chart4.ChartAreas[0].AxisX.Maximum = Xmax;
				chart5.ChartAreas[0].AxisX.Minimum = Xmin;
				chart5.ChartAreas[0].AxisX.Maximum = Xmax;

				//визначаємо крок сітки ,закоментовано-необов'язковщ
				//при малих відрізках і великому числі розбиттів сітка незручна
				//chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
				// Додаємо вичислені значення в графіки
				chart1.Series[0].Points.DataBindXY(x, y1);
				chart2.Series[0].Points.DataBindXY(x, y2);
				chart3.Series[0].Points.DataBindXY(x, y3);
				chart4.Series[0].Points.DataBindXY(y2, y4);
				chart5.Series[0].Points.DataBindXY(y3, y5);
			
			}
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


		}
		//функція для визнач min f(x)
		private double func_min(double[] y, double count)
		{
			double y_min = y[0];


			for (int i = 0; i <count-1; i++)
			{
				if (y[i] < y_min)
				{
					y_min = y[i];
				
				}
			}
			return y_min;
		}
		//ф-ія для сортування!
		private double[] sort(double[] y, int count)
		{
			for (int і = 1; і < count; і++)
			{
				double stk;
				for (int j = 0; j < count - і; j++)
				{     // цикл порівняння
					if (y[j] > y[j + 1])
					{
						stk = y[j];          // stk — для переставл елем
						y[j] = y[j + 1];
						y[j + 1] = stk;
					}
				}
			}
			return y;
		}

		//функція для визнач максимуму f(x)
		private double func_max(double[] y, double count)
		{
			double y_max = y[0];


			for (int i = 0; i < count - 1; i++)
			{
				if (y[i ] > y_max)
				{
					y_max = y[i];
					
				}
			}
			return y_max;
		}
		
		
		private void from_TextChanged(object sender, EventArgs e)
		{ }
			

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void chart3_Click(object sender, EventArgs e)
		{

		}

		private void tabPage1_Click_1(object sender, EventArgs e)
		{

		}
		// всі KeyPress призн,щоб не дати ввести в текстбокси щось,крім цифр
		private void from_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8 && number != 44 && e.KeyChar != '-') // цифри, клавиша BackSpace и кома
				//189-мінус
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
			if (!Char.IsDigit(number) && number != 8 && number != 44) // цифри, клавиша BackSpace и кома
			{
				e.Handled = true;
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
		//кнопка save data to file, збереження данмх з dataGridView1 в файл
		private void button1_Click(object sender, EventArgs e)
		{
        
		}

		private void button1_Click_1(object sender, EventArgs e)
		//записуємо дані з кожного "datagridview в окремий файл
		{
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			StreamWriter sw1 = new StreamWriter(Path.Combine(docPath, "datagridview1.txt"));
			StreamWriter sw2 = new StreamWriter(Path.Combine(docPath, "datagridview2.txt"));
			StreamWriter sw3 = new StreamWriter(Path.Combine(docPath, "datagridview3.txt"));
			StreamWriter sw4 = new StreamWriter(Path.Combine(docPath, "datagridview4.txt"));
			StreamWriter sw5 = new StreamWriter(Path.Combine(docPath, "datagridview5.txt"));
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
			for (int i = 1; i < dataGridView3.RowCount; i++)
			{
				for (int j = 0; j < dataGridView3.ColumnCount; j++)
				{
					sw3.Write(Convert.ToString(dataGridView3[j, i].Value + point));
				}
			
			}
			for (int i = 1; i < dataGridView4.RowCount; i++)
			{
				for (int j = 0; j < dataGridView4.ColumnCount; j++)
				{
					sw4.Write(Convert.ToString(dataGridView4[j, i].Value + point));
				}
				
			}
			for (int i = 1; i < dataGridView5.RowCount; i++)
			{
				for (int j = 0; j < dataGridView5.ColumnCount; j++)
				{
					sw5.Write(Convert.ToString(dataGridView5[j, i].Value + point));
				}
				
			}
			//закриваємо файли,куди записували
			sw1.Close();
			sw2.Close();
			sw3.Close();
			sw4.Close();
			sw5.Close();
		}
		//можливість отримати дані про відрізок та к-ість проміжків розбиття з файлу
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
		//збереження графіків у файли
		private void button2_Click(object sender, EventArgs e)
		{
			this.chart1.SaveImage(@"F:\chart1.png", ChartImageFormat.Png);
			this.chart2.SaveImage(@"F:\chart2.png", ChartImageFormat.Png);
			this.chart3.SaveImage(@"F:\chart3.png", ChartImageFormat.Png);
			this.chart4.SaveImage(@"F:\chart4.png", ChartImageFormat.Png);
			this.chart5.SaveImage(@"F:\chart5.png", ChartImageFormat.Png);
			
		}
	}
}
