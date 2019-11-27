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
        }

        private void RbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            if (rbtnPelicula.IsChecked == true)
            {
                l_Temporadas.Visibility = Visibility.Hidden;
                tb_Temporadas.Visibility = Visibility.Hidden;
            }
        }

        private void RbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            if (rbtnSerie.IsChecked == true)
            {
                l_Temporadas.Visibility = Visibility.Visible;
                tb_Temporadas.Visibility = Visibility.Visible;
            }
        }
    }
}
