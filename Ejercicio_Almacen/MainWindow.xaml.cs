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

namespace Ejercicio_Almacen
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

        private void IvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void validar_Contenido(String cadena, String titulo)
        {
            if (cadena == "")
            {
                MessageBox.Show("Debe introducir el dato:"+titulo);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            validar_Contenido(txtNombre.Text, " NOMBRE");
            validar_Contenido(txtDescripcion.Text, "DESCRIPCION");
            validar_Contenido(txtDescuento.Text, "DESCUENTO");
            validar_Contenido(txtIva.Text, "IVA");
            validar_Contenido(txtPagado.Text,"PAGADO");
           

        }

        private void txtDescuento_SelectionChanged(string cadena)
        {
            if (cadena == "")
            {
                MessageBox.Show("Debe introducir el descuento");
            }
        }

        private void txtDescripcion_TextChanged(string cadena)
        {
            if (cadena == "")
            {
                MessageBox.Show("Debe introducir la Descripción");
            }

        }

        private void txtNombre_TextChanged(string cadena)
        {
            if (cadena == "")
            {
                MessageBox.Show("Debe introducir el Nombre");
            }

        }

        private void txtIva_TextChanged()
        {
            if (txtIva.Text == "")
            {
                MessageBox.Show("Debe introducir el IVA");
            }

        }

        private void txtCantidad_TextChanged()
        {
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe introducir la cantidad");
            }

        }
    }
}
