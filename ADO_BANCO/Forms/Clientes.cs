using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Meterle Using
using System.Data.SqlClient;

namespace ADO_BANCO
{
    public partial class Clientes : Form
    {
       //Definimos cadena de conexion
        
        private SqlConnection conexion = new SqlConnection("Data Source = CADAVILES10\\SQLEXPRESS; Initial Catalog = Ejercicio_Repaso_Lunes_ADO; Integrated Security = True");
        public Clientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aDODataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
            cargarCombo();
            cargar();

        }


        //REFRESCAR CONTROLES GRID Y COMBO
        //cargar para el grid

        public void cargar()
        {
          
            //Objeto para almacenar datos de tabla virtual
            DataTable dt = new DataTable();
            string cadena = "select * from CLIENTE";
            
            SqlCommand cmd = new SqlCommand(cadena, conexion);
            
            //Definimos un adaptador de dontrol
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            
            //LLENAMOS EL GRID a traves del adaptador
            adap.Fill(dt);
            dataGridView1.DataSource = dt;

        }



        public void cargarCombo()
        {
            //código para llenar el comboBox
            //DATASET --> conjunto de datos
            //DATATABLE --> ES UN TABLA VIRTUAL
            DataSet ds = new DataSet();

            //indicamos la consulta en SQL y conexion sql
            string cadena = "select * from CLIENTE";

            //definir adaptador
            SqlDataAdapter da = new SqlDataAdapter(cadena, conexion);

            //se indica el nombre de la tabla
            da.Fill(ds, "CLIENTE");

            //se especifica el campo de la tabla
            comboBoxID.DataSource = ds.Tables[0].DefaultView;
            comboBoxID.ValueMember = "IDCLIENTE";

        }




       
        private void btAgregar_Click(object sender, EventArgs e)
        {
            //Abre conexion
            conexion.Open();
            
            //definir variables de cadena
            string id = textBoxID.Text;
            string nombre = textBoxNOMBRE.Text;
            string apellidos = textBoxAPELLIDOS.Text;
            string cadena = "insert into CLIENTE(IDCLIENTE, APELLIDOS, NOMBRES) values (" + id + ",'" + apellidos + "','" +  nombre + "')";
            
            //Comando SQL que lanzamos desde VS
            SqlCommand comando = new SqlCommand(cadena, conexion);

            //Ejecutamos la consulta SQL 

            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ha habido algún error.");
            }
            finally
            {
                MessageBox.Show("Los datos se guardaron correctamente");
            }

            
          

            //vacia los controles
            textBoxID.Text = "";
            textBoxNOMBRE.Text = "";
            textBoxAPELLIDOS.Text = "";

            //cierra conexion
            conexion.Close();
            cargar();
            cargarCombo();

        }







        private void btEliminar_Click(object sender, EventArgs e)
        {
            //Abrir conexion
            conexion.Open();
            string id = textBoxID.Text;
            
            //Definimos una cadena para eliminar el registro
            string cadena = "delete from CLIENTE where IDCLIENTE=" + id;

            
            SqlCommand comando = new SqlCommand(cadena, conexion);
            
            int cant;

            try
            {
                //Lanza el comando (cadena,conexion a sql)
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    textBoxNOMBRE.Text = "";
                    textBoxAPELLIDOS.Text = "";
                    MessageBox.Show("Se borró el cliente");
                    cargar();
                }
                else
                {
                    MessageBox.Show("No existe un cliente con este ID");
                    btEliminar.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("ALGO FALLO");
            }


            //CERRAR
            conexion.Close();
            cargar();
            cargarCombo();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
           //ABRIMOS CONEXION
            conexion.Open();
            string id = textBoxID.Text;
            string nombre = textBoxNOMBRE.Text;
            string apellidos = textBoxAPELLIDOS.Text;
            string cadena = "update CLIENTE set NOMBRES ='" + nombre + "', APELLIDOS='" + apellidos + "' where IDCLIENTE=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);

            //ExecuteNonQuery lanza consulta y devuelve >0 con exito y -1 si hay error

                int cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del cliente");
                    textBoxID.Text = "";
                    textBoxNOMBRE.Text = "";
                    textBoxAPELLIDOS.Text = "";


            }
                else
                {
                    MessageBox.Show("No existe un cliente con este ID");
                    btModificar.Enabled = false;
               
            }
            conexion.Close();
            cargar();
            cargarCombo();

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            string id = comboBoxID.Text;
            string cadena = "select IDCLIENTE,NOMBRES,APELLIDOS from CLIENTE where IDCLIENTE=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBoxNombreBuscado.Text = registro["NOMBRES"].ToString() + " " + registro["APELLIDOS"].ToString();
                btModificar.Enabled = true;
                btEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe una persona con este ID");
                textBoxNombreBuscado.Text = "";
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
            }
            conexion.Close();
        }
    }
}
