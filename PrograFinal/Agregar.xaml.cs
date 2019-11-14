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

namespace PrograFinal
{
    /// <summary>
    /// Lógica de interacción para Agregar.xaml
    /// </summary>
    public partial class Agregar : UserControl
    {
        public Agregar()
        {
            InitializeComponent();
            rbtnPelicula.IsChecked = true;
            grdDatos.Children.Add(new DatosPelicula());
        }

        private void RbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            grdDatos.Children.Clear();
            grdDatos.Children.Add(new DatosPelicula());
        }

        private void RbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            grdDatos.Children.Clear();
            grdDatos.Children.Add(new DatosSerie());
        }
    }
}
