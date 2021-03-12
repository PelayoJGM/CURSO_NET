using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext Northwind = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrid();
        }

        void cargarCombo() 
        {
            var cargaCombo = from p in Northwind.Products
                             select p.ProductName;
            comboBox1.DataSource = cargaCombo;
        
        }

        void cargarGrid()
        {
            var cargaGrid = from p in Northwind.Products select p;
            dataGridView1.DataSource = cargaGrid;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products MyProduct = new Products();
            MyProduct.ProductName = textBox1.Text;
            MyProduct.UnitPrice = int.Parse(textBox2.Text);
            MyProduct.UnitsInStock = short.Parse(textBox3.Text);
            MyProduct.CategoryID = int.Parse(textBox4.Text);
            Northwind.Products.InsertOnSubmit(MyProduct);
            Northwind.SubmitChanges();
            cargarCombo();
            cargarGrid();







        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            Products MyProducto = Northwind.Products.Single(predicate => predicate.ProductName == comboBox1.SelectedItem.ToString());
            MyProducto.ProductName = comboBox1.SelectedItem.ToString();
            MyProducto.UnitPrice = int.Parse(textBox2.Text);
            MyProducto.UnitsInStock = short.Parse(textBox3.Text);
            MyProducto.CategoryID = int.Parse(textBox4.Text);
            Northwind.SubmitChanges();
            cargarCombo();
            cargarGrid();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products MyProduct = Northwind.Products.Single(predicate => predicate.ProductName == comboBox1.SelectedItem.ToString());
            Northwind.Products.DeleteOnSubmit(MyProduct);
            Northwind.SubmitChanges();
            cargarCombo();
            cargarGrid();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
