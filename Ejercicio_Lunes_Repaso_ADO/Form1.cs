using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio_Lunes_Repaso_ADO
{
    public partial class Form1 : Form
    {

     private SqlConnection conexion = new SqlConnection("server=CADAVILES10\\SQLEXPRESS; Initial Catalog=Ejercicio_Repaso_Lunes_ADO; Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicio_Repaso_Lunes_ADODataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.ejercicio_Repaso_Lunes_ADODataSet.CLIENTE);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string ID = textBox1.Text;
            string NOMBRE = textBox2.Text;
            string APELLIDOS = textBox3.Text;
            string cadena = "insert into CLIENTE (IDCLIENTE, NOMBRE, APELLIDOS) values ('" + ID + "','" + NOMBRE + "','" + APELLIDOS + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se agregaron correctamente");
            //cargar();
            //cargarCombo();
            textBox1.Text = "";
            textBox2.Text = "";   
            conexion.Close();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
