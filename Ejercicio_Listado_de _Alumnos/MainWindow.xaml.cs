//Ejercicio de LINQ Realizado por Pelayo JGM el 09/03/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Linq;

namespace Ejercicio_Listado_de__Alumnos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cargarGrid();
        }
        //añadimos el Codigo para cargar el Datagridview 
        DataClasses1DataContext Ejercicio_Listado_de_Alumnos = new DataClasses1DataContext();




        void cargarGrid()
        {
            var cargaGrid = from p in Ejercicio_Listado_de_Alumnos.Alumnos
                            select p;
            DataGrid1.ItemsSource = cargaGrid;

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
          

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBox2.Items.Add("MAsculino");
            ComboBox2.Items.Add("Femenino");

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //Boton para agregar Un nuevo alumno

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Alumnos MyAlumno = new Alumnos();
            MyAlumno.Nombre = textBox1.Text;
            MyAlumno.Turno = ComboBox1.Text;
            MyAlumno.Codigo = textBox2.Text;
            MyAlumno.DNI = textBox3.Text;
            MyAlumno.Sexo = ComboBox2.Text;
            MyAlumno.Especialidad = ComboBox3.Text;
            MyAlumno.Modulo = ComboBox4.Text;
            Ejercicio_Listado_de_Alumnos.Alumnos.InsertOnSubmit(MyAlumno);
            Ejercicio_Listado_de_Alumnos.SubmitChanges();
            cargarGrid();

        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox1.Items.Add("Diurno");
            ComboBox1.Items.Add("Nocturno");

            string selected = ComboBox1.Text;
            MessageBox.Show(selected);


        }

        private void ComboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox3.Items.Add("COMPUTACION E INFORMATICA");
            ComboBox3.Items.Add("INFORMATICA Y COMPUTACION");
        }

        private void ComboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox4.Items.Add("DAM");
            ComboBox4.Items.Add("DAW");
            ComboBox4.Items.Add("ASIR");
        }


        //Boton para eliminar un alumno
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Alumnos MyAlumno = Ejercicio_Listado_de_Alumnos.Alumnos.Single(p => p.Nombre == textBox1.Text);
            Ejercicio_Listado_de_Alumnos.Alumnos.DeleteOnSubmit(MyAlumno);
            Ejercicio_Listado_de_Alumnos.SubmitChanges();
            cargarGrid();

        }

        //Boton para modificar Alumnos
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            Alumnos MyAlumno = Ejercicio_Listado_de_Alumnos.Alumnos.Single(p => p.Nombre == textBox1.Text);
            MyAlumno.Nombre = textBox1.Text;
            MyAlumno.Codigo = (textBox2.Text);
            MyAlumno.DNI = (textBox3.Text);
            Ejercicio_Listado_de_Alumnos.SubmitChanges();
            cargarGrid();

        }


    }
    }



