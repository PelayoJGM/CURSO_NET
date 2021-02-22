using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class Form1 : Form
    {

        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myEmpleado.Nombre = textBox2.Text;
            myEmpleado.Identificacion = textBox3.Text;
            myEmpleado.AsignacionDia = Convert.ToDecimal(textBox4.Text);
            myNomina.DiasLaborados = Convert.ToInt32(textBox5.Text);
            MessageBox.Show("SEguardo el registro correctamente");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = myNomina.CalcularNomina(Convert.ToInt32(myNomina.DiasLaborados),
            Convert.ToDecimal(myEmpleado.AsignacionDia)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
