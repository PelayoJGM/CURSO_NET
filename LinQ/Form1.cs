using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public Form1()
        {

            InitializeComponent();
            this.listarclientes();
        }

        void listarclientes()
        {
            dataGridView1.DataSource = ClienteLinq.listarTodos();
        }
        private void Form1_Load(object sender,EventArgs e)
        {
            this.listarclientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            ClienteLinq.insertarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.listarclientes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClienteLinq.Eliminarcliente(TxtNombre.Text);
            this.listarclientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteLinq.Modificarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.listarclientes();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
