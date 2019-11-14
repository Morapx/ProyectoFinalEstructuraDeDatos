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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregarElemento_Click(object sender, RoutedEventArgs e)
        {
            grdVisualizar.Children.Clear();
            grdVisualizar.Children.Add(new Agregar());

            btnAgregarElemento.Visibility = Visibility.Hidden;
            
            btnAñomM.Visibility = Visibility.Hidden;
            btnAñoMm.Visibility = Visibility.Hidden;

            btnTituloAZ.Visibility = Visibility.Hidden;
            btnTituloZA.Visibility = Visibility.Hidden;

            btnCancelar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Visible;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdVisualizar.Children.Clear();
            btnAgregarElemento.Visibility = Visibility.Visible;

            btnAñomM.Visibility = Visibility.Visible;
            btnAñoMm.Visibility = Visibility.Visible;

            btnTituloAZ.Visibility = Visibility.Visible;
            btnTituloZA.Visibility = Visibility.Visible;

            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;

        }
    }
}
