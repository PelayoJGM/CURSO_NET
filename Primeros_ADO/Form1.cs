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

namespace Primeros_ADO
{
    public partial class Form1 : Form
    {

        private SqlConnection conexion = new SqlConnection("server=CADAVILES10\\SQLEXPRESS; Initial Catalog=prueba_ado; Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prueba_adoDataSet.Tabla_ado' Puede moverla o quitarla según sea necesario.
            this.tabla_adoTableAdapter.Fill(this.prueba_adoDataSet.Tabla_ado);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cargar()
        {

            
                DataTable dt = new DataTable();
                string query = "SELECT id,nombre,edad FROM Tabla_ado";
                SqlCommand cmd = new SqlCommand(query,conexion);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
            

         }




        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string iden = textBox1.Text;
            string Nombre = textBox2.Text;
            string edad = textBox3.Text;
            string cadena = "insert into Tabla_ado (id, nombre, edad) values (" + iden + ",'" +Nombre+"',"+ edad + ")";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron corerctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            dataGridView1.Refresh();
            conexion.Close();
            Cargar();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string id = textBox6.Text;
            string cadena = "select id, Nombre, edad from Tabla_ado where id=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                label1.Text = registro["nombre"].ToString();
                label2.Text = registro["edad"].ToString();
                button2.Enabled = true;
            }
            else
                MessageBox.Show("No existe un articulo con el codigo ingresado");
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string iden = textBox6.Text;
            string cadena = "delete from Tabla_ado where id=" + iden;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant==1)
            {
                label1.Text = "";
                label2.Text = "";
                MessageBox.Show("Se borro el articulo");
               
            }
            else
                MessageBox.Show("No existe un articulo con el codigo ingresado");
            conexion.Close();
            button4.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cod = textBox9.Text;
            string cadena = "select id, nombre,edad from Tabla_ado where id=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["Nombre"].ToString();
                textBox3.Text = registro["edad"].ToString();
                button1.Enabled = true;
            }
            else
                MessageBox.Show("No existe un articulo con el codigo ingresado");
            conexion.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string id = textBox9.Text;
            string Nombre = textBox2.Text;
            string edad = textBox3.Text;
            string cadena = "update Tabla_ado set Nombre='" + Nombre + "',edad=" + edad + "where id=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del articulo");
                textBox7.Text = "";
                textBox7.Text = "";
                textBox7.Text = "";
            }
            else
                MessageBox.Show("no existe un articulo con el codigo ingresado");
            conexion.Close();
            button5.Enabled = false;


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
