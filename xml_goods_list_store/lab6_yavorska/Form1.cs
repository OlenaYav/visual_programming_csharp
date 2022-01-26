using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace lab6_yavorska
{
	public partial class Form1 : Form
	{
		string fileName = "../../goods_1.xml";

		private DataGridView DataGridView_shop = new DataGridView();
		public Form1()
		{
			InitializeComponent();
			SetupDataGridView();
			FromFile();
		}
        private void FromFile()
        {
            XDocument docX = XDocument.Load(fileName);

            int id = 0;
            int row = 0, column = 0;

            int count = docX.Root.Elements("goods").Count();
            DataGridView_shop.Rows.Add(count);

            foreach (XElement el in docX.Root.Elements("goods"))
            {
                XAttribute attr_id = el.Attribute("id");
                XElement category = el.Element("category");
                XElement name = el.Element("name");
                XElement ID = el.Element("ID");
                XElement price = el.Element("price");
                XElement about = el.Element("about");


                if (attr_id != null && category != null && name != null && about != null)
                {
                    DataGridView_shop.Rows[row].Cells[column++].Value = category.Value;
                    DataGridView_shop.Rows[row].Cells[column++].Value = name.Value;
                    DataGridView_shop.Rows[row].Cells[column++].Value = ID.Value;
                    DataGridView_shop.Rows[row].Cells[column++].Value = price.Value;
                    DataGridView_shop.Rows[row].Cells[column++].Value = about.Value;
                }
                column = 0;
                row++;
            }

        }

        private void ToFile()
        {
            int id = 0;
            int row = 0, column = 0;
            XDocument docX = XDocument.Load(fileName);

            docX.Root.RemoveAll();
            //docX.Save(fileName);

            foreach (DataGridViewRow Row in DataGridView_shop.Rows)
            {
                try
                {
                    XElement track = new XElement("goods",
                        new XAttribute("id", id++),
                        new XElement("category", DataGridView_shop.Rows[row].Cells[column++].Value.ToString()),
                        new XElement("name", DataGridView_shop.Rows[row].Cells[column++].Value.ToString()),
                        new XElement("ID", DataGridView_shop.Rows[row].Cells[column++].Value.ToString()),
                        new XElement("price", DataGridView_shop.Rows[row].Cells[column++].Value.ToString()),
                        new XElement("about", DataGridView_shop.Rows[row].Cells[column++].Value.ToString())
                    );

                    docX.Root.Add(track);
                    column = 0;
                    row++;
                }
                catch (Exception)
                {

                    break;
                }
            }

            docX.Save(fileName);
        }
        
       
        private void SetupDataGridView()
        {
            this.Controls.Add(DataGridView_shop);
            
            DataGridView_shop.ColumnCount = 5;

            DataGridView_shop.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DataGridView_shop.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridView_shop.ColumnHeadersDefaultCellStyle.Font =
                new Font(DataGridView_shop.Font, FontStyle.Bold);

            DataGridView_shop.Name = "DataGridView_shop";
            DataGridView_shop.Location = new Point(8, 8);
            DataGridView_shop.Size = new Size(500, 250);
            DataGridView_shop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_shop.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DataGridView_shop.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            DataGridView_shop.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataGridView_shop.GridColor = Color.Black;
            DataGridView_shop.RowHeadersVisible = false;

            DataGridView_shop.Columns[0].Name = "Category";
            DataGridView_shop.Columns[1].Name = "name";
            DataGridView_shop.Columns[2].Name = "ID";
            DataGridView_shop.Columns[3].Name = "price";
            DataGridView_shop.Columns[4].Name = "about";

            DataGridView_shop.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            DataGridView_shop.MultiSelect = false;
            DataGridView_shop.Dock = DockStyle.Fill;

            DataGridView_shop.Rows[0].Height = DataGridView_shop.Height - DataGridView_shop.ColumnHeadersHeight;


        }


        

        private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void add_Click(object sender, EventArgs e)
        {
            this.DataGridView_shop.Rows.Add();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (this.DataGridView_shop.SelectedRows.Count > 0 &&
               this.DataGridView_shop.SelectedRows[0].Index !=
               this.DataGridView_shop.Rows.Count - 1)
            {
                this.DataGridView_shop.Rows.RemoveAt(
                    this.DataGridView_shop.SelectedRows[0].Index);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ToFile();
        }
    }
}
