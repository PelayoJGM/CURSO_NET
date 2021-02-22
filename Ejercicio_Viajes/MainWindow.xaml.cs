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

namespace Ejercicio_Viajes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            //declaraciones

            string empresa = "";
            string salida = "";
            string llegada = "";
            string Nombre = "";
            string mail = "";
            string personas = "";
            //DateTime fecha;
             
            try
            {
                if ((MyCombo.SelectedItem as ComboBoxItem) == null) MessageBox.Show("Selecciona la empresa");
                else if ((ComboN.SelectedItem as ComboBoxItem) == null) MessageBox.Show("Introduce lugar de salida");
                else if ((ComboN2.SelectedItem as ComboBoxItem) == null) MessageBox.Show("Introduce lugar de llegada");
                else if (txtNombre.Text == "") MessageBox.Show("Introduce un nombre");
                else if (correo.Text == "") MessageBox.Show("Introduce una dirección de email válida");
                else if (fecha1.Text == "")MessageBox.Show("Introduce una fecha");
                else if (fecha2.Text== "")MessageBox.Show("Introduce una fecha de llegada");

                else
                {
                    empresa = (MyCombo.SelectedItem as ComboBoxItem).Content.ToString();
                    salida = (ComboN.SelectedItem as ComboBoxItem).Content.ToString();
                    llegada = (ComboN2.SelectedItem as ComboBoxItem).Content.ToString();
                    Nombre = txtNombre.Text;
                    mail = (correo).ToString().Substring(38);

                }


            }
            catch
            {
                MessageBox.Show("Completa los campos en blanco");
            }

            finally
            {
                MessageBox.Show("Estimado " + Nombre + "\nReserva realizada para el día " + fecha1.SelectedDate.ToString()+ "\nDe "+ salida + " a "+ llegada + " para " + personas );
            }
           

        }

    }

    }

