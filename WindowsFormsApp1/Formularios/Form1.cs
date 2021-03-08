using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataClasses2DataContext EnfermoLinq = new DataClasses2DataContext();
        public Form1()
        {
            InitializeComponent();
            this.listarEnfermos();
        }

        void listarEnfermos() 
        {
            EnfermoLinq.SP_listarEnfermos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listarEnfermos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnfermoLinq.SP_ModificarEnfermo(textBox1.Text);
            this.listarEnfermos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnfermoLinq.SP_EliminarEnfermo(textBox1.Text);
            this.listarEnfermos();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = EnfermoLinq.SP_listarEnfermos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnfermoLinq.SP_InsertarEnfermo(textBox1.Text, textBox2.Text, radioButton1.Text, radioButton2.Text, textBox4.Text, textBox5.Text);
            this.listarEnfermos();
        }
    }
}
