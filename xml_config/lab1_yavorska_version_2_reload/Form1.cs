using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace lab1_yavorska_version_2_reload
{
	public partial class Form1 : Form
	{
		private TextBox textBox = null;
		public Form1()
		{
			InitializeComponent();
			this.textBox1.GotFocus += new EventHandler(GetF);//делегати для встановлення фокусу на потрібному текстбоксі
			this.textBox2.GotFocus += new EventHandler(GetF);//(тому,який останній був активним)
			this.textBox3.GotFocus += new EventHandler(GetF);
			this.textBox4.GotFocus += new EventHandler(GetF);
			this.textBox5.GotFocus += new EventHandler(GetF);
			
		}

		

		private void Form1_Load(object sender, EventArgs e)
		{
			this.ActiveControl = textBox1;//при завантаженні форми фокус на першому тексбоксі
			List<Button> buttons = new List<Button>();//динамічний список кнопок від 1 до 9 ,щоб не прописувати всі окремо
			int tmp = 0;
			for (int i = 0; i < 9; i++)
			{
				Button newButton = new Button();
				newButton.Width = 80;
				newButton.Top = 80;
				buttons.Add(newButton);
				newButton.Left += newButton.Width * (i % 3);
				if (i % 3 == 0)
					tmp++;
				newButton.Top += newButton.Height * tmp;
				newButton.Text += (i + 1).ToString();
				newButton.Tag = i + 1;
				newButton.Click += new System.EventHandler(buttons_Click);
				this.Controls.Add(newButton);
			}
		}
		private void GetF(object sender, EventArgs e)
		{
			// Keeps you selecting textbox object reference.
			textBox = sender as TextBox;

		}
		private void buttons_Click(object sender, EventArgs e)//додає цифру з динамічного списку кнопок 1-9 в текстбокс
		{

			
			textBox.SelectedText += (sender as Button).Text;

		}

		private void button2_Click(object sender, EventArgs e)//очищає вибраний текстбокс
		{

			textBox.Clear();

		}

		private void button1_Click(object sender, EventArgs e)//додає 0  до текстбокста,який був активним останнім
			//при кліку на 0
		{
			textBox.SelectedText +=  0;
		}

		private void button3_Click(object sender, EventArgs e)//при кліку на "."
		{
			textBox1.Text = textBox1.Text + ",";
		}

		double result_square, result_perimeter;

		private void radioButton1_CheckedChanged(object sender, EventArgs e)// вибрано квадрат/прямокутник,достатньо двох сторін для обчислення
		{
			textBox1.Enabled = true;
			textBox2.Enabled = true;
			textBox3.Enabled = false;
			textBox4.Enabled = false;
			textBox5.Enabled = false;
		}
		//залежно від того ,потрібні нам текстбокси ,чи ні,можемо вимкнути можливість з ними працювати
		private void radioButton2_CheckedChanged(object sender, EventArgs e)// це паралелограм,достатньо двох сторін і висоти
		{
			textBox1.Enabled = true;
			textBox2.Enabled = true;
			textBox3.Enabled = false;
			textBox4.Enabled = false;
			textBox5.Enabled = true;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)//ромб,достатньо сторони і діагоналі до неї
		{
			textBox1.Enabled = true;
			textBox2.Enabled = false;
			textBox3.Enabled = false;
			textBox4.Enabled = false;
			textBox5.Enabled = true;
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)//трапеція,всі сторони потрібні для обчислень
		{
			textBox1.Enabled = true;
			textBox2.Enabled = true;
			textBox3.Enabled = true;
			textBox4.Enabled = true;
			textBox5.Enabled = false;
		}
		

		
		
		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		bool check;
		double aa;
		double height_trapeze;
		
			

		
		private void button4_Click(object sender, EventArgs e)
		{
			double side_1, height, side_2, side_3, side_4;
			
			if (radioButton1.Checked)// це квадрат/прямокутник
			{
				check = double.TryParse(textBox1.Text,out aa);//сторона  
				if(!check)
					//перевірка введених даних
				{
					MessageBox.Show("Please enter number");
					return;
				}
				if (textBox1.Text.Length > 0 && textBox2.Text.Length>0)
				{
					side_1 = Convert.ToDouble(textBox1.Text);//сторона 1
					side_3 = Convert.ToDouble(textBox2.Text);//інша,не протилежна,сторона
					result_square = side_1 * side_3;//достатньо двох сторін,щоб знайти площу і периметр
					result_perimeter = (side_1 + side_3) * 2;
				}
				else
				//перевіцрка,чи всі потрібні дані заповнені
				{
					MessageBox.Show("fill all textboxes");
					return;
				}
			}
			if (radioButton2.Checked)//якщо це паралелограм
			{
				if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox5.Text.Length > 0)
				{
					side_1 = Convert.ToDouble(textBox1.Text);//сторона 1 
					side_3 = Convert.ToDouble(textBox2.Text);//інша,не протилежна,сторона
					height = Convert.ToDouble(textBox5.Text);//ВИСОТА ДО СТОРОНИ
					result_square = side_1 * height;
					result_perimeter = (side_1 + side_3) * 2;
				}
				else
				//перевіцрка,чи всі потрібні дані заповнені
				{
					MessageBox.Show("fill all textboxes");
					return;
				}
			}

			if (radioButton3.Checked)//якщо це ромб
			{

				if (textBox1.Text.Length > 0 && textBox5.Text.Length > 0)
				{
					side_1 = Convert.ToDouble(textBox1.Text);//сторона  
				height = Convert.ToDouble(textBox5.Text);//ВИСОТА до сторони
				result_square = side_1 * height;//периметр ромба-сторона*висоту дои сторони
				result_perimeter = (side_1)*4;//у ромба всі сторони рівні
				}
				else
				{
					MessageBox.Show("fill all textboxes");//перевіцрка,чи всі потрібні дані заповнені
					return;
				}
			}
			if (radioButton4.Checked) //це трапеція
			{
				if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
				{
					side_1 = Convert.ToDouble(textBox1.Text);//сторона 1 
					side_2 = Convert.ToDouble(textBox4.Text);//сторона 2 
					side_3 = Convert.ToDouble(textBox2.Text);//сторона 3
					side_4 = Convert.ToDouble(textBox3.Text);//сторона 4 
					height_trapeze = Math.Sqrt(Math.Pow((side_1), 2) - Math.Pow((side_4 - side_2), 2));
					result_square = (side_2 + side_4) / (2 * height_trapeze);
					result_perimeter = side_1 + side_2 + side_3 + side_4;
				}
				else
				{
					MessageBox.Show("fill all textboxes");//перевіцрка,чи всі потрібні дані заповнені
					return;
				}
				}
			textBox6.Text = "Square = " + result_square +";"+ "perimeter = " + result_perimeter;
			if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
				//якщо жодна з фігур не обрана,не знатимем,як порахувати площу-помилка і сповіщення
			{
				MessageBox.Show("Please select type of figure");
				return;
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//не дозволяє ввід в текстбокс 
			//нічого іншого ,крім цифр,десяткової коми і backspace
		{
		//	char number = e.KeyChar;
		//	if (!Char.IsDigit(number) && number != 8 && number != 44) // цифри, клавиша BackSpace и кома
		//	{
		//		e.Handled = true;
		//	}

		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)//не дозволяє ввід в текстбокс 
																		  //нічого іншого ,крім цифр,десяткової коми і backspace
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8 && number != 44) // цифри, клавиша BackSpace и кома
			{
				e.Handled = true;
			}
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8 && number != 44) // цифри, клавиша BackSpace и кома,решта не введеться
			{
				e.Handled = true;
			}
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8 && number != 44) // цифри, клавиша BackSpace и кома,решта не введеться
			{
				e.Handled = true;
			}
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{

		}
		//ф-ія для запису даних в файл config_me.xml
		
		private void saveXML_Click(object sender, EventArgs e)
		{
				//using (XmlWriter writer = XmlWriter.Create(@"C:\Users\Olena\source\repos\lab5_yavorska_pm32\config_me.xml"))
			//якщо не прописувати явно шлях, просто назва файлу,то зберігається в Debug
			//можна і просто ,але мені було зручніше не шукати цей файл ,а бачити його там ,де я його створити
			using (XmlWriter writer = XmlWriter.Create("config_me.xml"))
			{
				XmlWriterSettings settings = new XmlWriterSettings();

				settings.NewLineOnAttributes = true;
				writer.WriteStartDocument();
					writer.WriteStartElement("root");

					writer.WriteElementString("textBox1", textBox1.Text);
				writer.WriteElementString("textBox2", textBox2.Text);
				writer.WriteElementString("textBox3", textBox3.Text);
				writer.WriteElementString("textBox4", textBox4.Text);
				writer.WriteElementString("textBox5", textBox5.Text);
				writer.WriteElementString("textBox6", textBox6.Text);
				if (radioButton1.Checked) { writer.WriteElementString("radioButton1", radioButton1.Text); }
				else if (radioButton2.Checked) { writer.WriteElementString("radioButton2", radioButton2.Text); }
				else if (radioButton3.Checked) { writer.WriteElementString("radioButton3", radioButton3.Text); }
				else if (radioButton4.Checked) { writer.WriteElementString("radioButton4", radioButton4.Text); }
				writer.WriteEndElement();

			
			
			    }
			
		}

		private void readXML_Click(object sender, EventArgs e)
		{
			//функція, що зчитує з XML-файлу дані в текст-бокси
			try
			{
				//using (XmlTextReader reader = new XmlTextReader(@"C:\Users\Olena\source\repos\lab5_yavorska_pm32\config_me.xml"))
				//якщо не прописувати явно шлях, просто назва файлу,то зберігається в Debug
				using (XmlTextReader reader = new XmlTextReader("config_me.xml"))
				{
					XmlWriterSettings settings = new XmlWriterSettings();

					settings.NewLineOnAttributes = true;
					XmlNodeType type;
					while (reader.Read())
					{
						type = reader.NodeType;
						if (type == XmlNodeType.Element)
						{
							foreach (Control element_to_read in Controls)
							{
								if (element_to_read is TextBox)
								//якщо це текстбокс,зчитує значення
								{
									if (reader.Name == element_to_read.Name)
									{
										reader.Read();
										element_to_read.Text = reader.Value;
									}
								}
								//якщо це радіобаттон, ставить фокус на нього
								//в контролах не можна поставити Checked
								if (element_to_read is RadioButton)
								{
									if (reader.Name == element_to_read.Name)
									{
										reader.Read();
										element_to_read.Focus();
									}
								}
							}

						}




					}
				}
			}
			//якщо файлу нема/не можна зчитати з файлу,виб'є меседжбок про помилку
			catch (IOException)
			{
				MessageBox.Show("some problems with your file, write data  first");

			}
		}
		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8 && number != 44) // цифри, клавиша BackSpace и кома -єдині дозволені на ввід
			{
				e.Handled = true;
			}
		}

	}
}
