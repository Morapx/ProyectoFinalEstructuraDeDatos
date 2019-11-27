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
using System.Collections.ObjectModel;

namespace PrograFinal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<PeliculaSerie> peliculaSerie = new ObservableCollection<PeliculaSerie>();
        public MainWindow()
        {
            InitializeComponent();

            peliculaSerie.Add(new Pelicula("Frozen", 2014, "Aventura", "Disney", "La historia de dos hermanas, la princesa de hielo y su pequeña hermana.", 5));
            peliculaSerie.Add(new Serie("The Big Bang Theory", 2007, "Comedia", "Chuck Lorre y Bill Prady", "Tres streamers raros.", 4, 12));

            lstDatos.ItemsSource = peliculaSerie;
        }

        private void BtnTituloAZ_Click(object sender, RoutedEventArgs e)
        {
            bool cambio;
            do
            {
                cambio = false;
                for (int i = 0; i < (peliculaSerie.Count - 1); i++)
                {
                    if (string.Compare(peliculaSerie[i].Titulo, peliculaSerie[i + 1].Titulo) > 0)
                    {
                        var temp = peliculaSerie[i];
                        peliculaSerie[i] = peliculaSerie[i + 1];
                        peliculaSerie[i + 1] = temp;
                        cambio = true;
                    }
                }
            } while (cambio == true);
        }

        private void BtnTituloZA_Click(object sender, RoutedEventArgs e)
        {
            bool cambio;
            do
            {
                cambio = false;
                for (int i = 0; i < (peliculaSerie.Count - 1); i++)
                {
                    if (string.Compare(peliculaSerie[i].Titulo, peliculaSerie[i + 1].Titulo) < 0)
                    {
                        var temp = peliculaSerie[i];
                        peliculaSerie[i] = peliculaSerie[i + 1];
                        peliculaSerie[i + 1] = temp;
                        cambio = true;
                    }
                }
            } while (cambio == true);

        }

        private void BtnAñoMm_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < peliculaSerie.Count - 1; i++)
                {
                    if (peliculaSerie[i].Año > peliculaSerie[i + 1].Año)
                    {
                        var temp = peliculaSerie[i];
                        peliculaSerie[i] = peliculaSerie[i + 1];
                        peliculaSerie[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }

        private void BtnAñomM_Click2(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < peliculaSerie.Count - 1; i++)
                {
                    if (peliculaSerie[i].Año < peliculaSerie[i + 1].Año)
                    {
                        var temp = peliculaSerie[i];
                        peliculaSerie[i] = peliculaSerie[i + 1];
                        peliculaSerie[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdVisualizar.Children.Clear();

            btnAgregarElemento.Visibility = Visibility.Visible;

            btnAñoMm.Visibility = Visibility.Visible;

            btnTituloAZ.Visibility = Visibility.Visible;

            btnTituloZA.Visibility = Visibility.Visible;

            btnAñomM2.Visibility = Visibility.Visible;

            btnAñoMm.Visibility = Visibility.Visible;

            btnActualizarElemento.Visibility = Visibility.Hidden;

            btnCancelar.Visibility = Visibility.Hidden;

            btnEliminarElemento.Visibility = Visibility.Hidden;

            btnGuardarElemento.Visibility = Visibility.Hidden;

            btnEditarElemento.Visibility = Visibility.Hidden;


        }

        private void BtnAgregarElemento_Click(object sender, RoutedEventArgs e)
        {
            grdVisualizar.Children.Clear();
            grdVisualizar.Children.Add(new Agregar());

            var algo = ((Agregar)(grdVisualizar.Children[0]));


            btnAgregarElemento.Visibility = Visibility.Hidden;

            btnAñoMm.Visibility = Visibility.Hidden;

            btnTituloAZ.Visibility = Visibility.Hidden;

            btnTituloZA.Visibility = Visibility.Hidden;

            btnAñomM2.Visibility = Visibility.Hidden;

            btnAñoMm.Visibility = Visibility.Hidden;

            btnCancelar.Visibility = Visibility.Visible;

            btnGuardarElemento.Visibility = Visibility.Visible;
        }

        private void btnGuardarElemento_Click(object sender, RoutedEventArgs e)
        {
            var algo = ((Agregar)(grdVisualizar.Children[0]));

            if (algo.rbtnPelicula.IsChecked == true)
            {
                if (algo.tb_Nombre.Text == string.Empty || algo.tb_Año.Text == string.Empty || algo.cb_Genero.Text == string.Empty || algo.tb_Productor.Text == string.Empty || algo.tb_Descripcion.Text == string.Empty || algo.l_Rating.Text == string.Empty)
                {

                }
                else
                {
                    peliculaSerie.Add(new Pelicula(algo.tb_Nombre.Text, Convert.ToInt32(algo.tb_Año.Text), algo.cb_Genero.Text, algo.tb_Productor.Text, algo.tb_Descripcion.Text, Convert.ToInt32(algo.tb_Rating.Text)));

                    btnAgregarElemento.Visibility = Visibility.Visible;

                    btnAñoMm.Visibility = Visibility.Visible;

                    btnTituloAZ.Visibility = Visibility.Visible;

                    btnTituloZA.Visibility = Visibility.Visible;

                    btnAñomM2.Visibility = Visibility.Visible;

                    btnAñoMm.Visibility = Visibility.Visible;

                    btnCancelar.Visibility = Visibility.Hidden;

                    btnGuardarElemento.Visibility = Visibility.Hidden;

                    btnEditarElemento.Visibility = Visibility.Hidden;

                    btnEliminarElemento.Visibility = Visibility.Hidden;

                    grdVisualizar.Children.Clear();

                }
            }
            if (algo.rbtnSerie.IsChecked == true)
            {
                if (algo.tb_Nombre.Text == string.Empty || algo.tb_Año.Text == string.Empty || algo.cb_Genero.Text == string.Empty || algo.tb_Productor.Text == string.Empty || algo.tb_Descripcion.Text == string.Empty || algo.l_Rating.Text == string.Empty || algo.tb_Temporadas.Text == string.Empty)
                {

                }
                else
                {
                    peliculaSerie.Add(new Serie(algo.tb_Nombre.Text, Convert.ToInt32(algo.tb_Año.Text), algo.cb_Genero.Text, algo.tb_Productor.Text, algo.tb_Descripcion.Text, Convert.ToInt32(algo.tb_Rating.Text), Convert.ToInt32(algo.tb_Temporadas.Text)));

                    btnAgregarElemento.Visibility = Visibility.Visible;

                    btnAñoMm.Visibility = Visibility.Visible;

                    btnTituloAZ.Visibility = Visibility.Visible;

                    btnTituloZA.Visibility = Visibility.Visible;

                    btnAñomM2.Visibility = Visibility.Visible;

                    btnAñoMm.Visibility = Visibility.Visible;

                    btnCancelar.Visibility = Visibility.Hidden;

                    btnGuardarElemento.Visibility = Visibility.Hidden;

                    btnEditarElemento.Visibility = Visibility.Hidden;

                    btnEliminarElemento.Visibility = Visibility.Hidden;

                    grdVisualizar.Children.Clear();

                }

            }

        }

        private void LstDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstDatos.SelectedIndex != -1)
            {
                grdVisualizar.Children.Clear();
                grdVisualizar.Children.Add(new Datos());

                btnAñoMm.Visibility = Visibility.Hidden;

                btnTituloAZ.Visibility = Visibility.Hidden;

                btnTituloZA.Visibility = Visibility.Hidden;

                btnAñomM2.Visibility = Visibility.Hidden;

                btnAñoMm.Visibility = Visibility.Hidden;

                btnAgregarElemento.Visibility = Visibility.Hidden;

                btnEditarElemento.Visibility = Visibility.Visible;

                btnCancelar.Visibility = Visibility.Visible;

                btnEliminarElemento.Visibility = Visibility.Visible;

                btnActualizarElemento.Visibility = Visibility.Hidden;

                btnGuardarElemento.Visibility = Visibility.Hidden;

                var algo = ((Datos)(grdVisualizar.Children[0]));
                var algo2 = peliculaSerie[lstDatos.SelectedIndex];

                algo.tb_Nombre.Text = algo2.Titulo;
                algo.tb_Año.Text = algo2.Año.ToString();
                algo.tb_Director.Text = algo2.Director;
                algo.cb_Genero.Text = algo2.Genero;
                algo.tb_Descipcion.Text = algo2.Sinopsis;
                algo.lTipo.Text = algo2.Seccion;
                algo.tb_Temporadas.Text = algo2.Temporadas.ToString();
                algo.tb_Rating.Text = algo2.Rating.ToString();

                if (algo2.Rating == 0)
                {

                }
                if (algo2.Rating == 1)
                {
                    algo.e1.Visibility = Visibility.Visible;
                }
                if (algo2.Rating == 2)
                {
                    algo.e2.Visibility = Visibility.Visible;
                }
                if (algo2.Rating == 3)
                {
                    algo.e3.Visibility = Visibility.Visible;
                }
                if (algo2.Rating == 4)
                {
                    algo.e4.Visibility = Visibility.Visible;
                }
                if (algo2.Rating == 5)
                {
                    algo.e5.Visibility = Visibility.Visible;
                }
                if (algo2.Rating > 5 || algo2.Rating < 0)
                {
                    algo.novalido.Visibility = Visibility.Visible;
                }

                if (algo2.Seccion == "Serie")
                {
                    algo.l_Rating.Visibility = Visibility.Hidden;

                    algo.l_Temporadas.Visibility = Visibility.Visible;

                    algo.tb_Rating.Visibility = Visibility.Hidden;

                    algo.tb_Temporadas.Visibility = Visibility.Visible;
                }
                if (algo2.Seccion == "Película")
                {
                    algo.l_Rating.Visibility = Visibility.Hidden;

                    algo.l_Temporadas.Visibility = Visibility.Hidden;

                    algo.tb_Rating.Visibility = Visibility.Hidden;

                    algo.tb_Temporadas.Visibility = Visibility.Hidden;
                }
                algo.tb_Nombre.IsEnabled = false;
                algo.tb_Año.IsEnabled = false;
                algo.tb_Director.IsEnabled = false;
                algo.cb_Genero.IsEnabled = false;
                algo.tb_Descipcion.IsEnabled = false;
                algo.tb_Temporadas.IsEnabled = false;
                algo.tb_Rating.IsEnabled = false;

            }


        }

        private void BtnEditarElemento_Click(object sender, RoutedEventArgs e)
        {
            var algo = ((Datos)(grdVisualizar.Children[0]));
            var algo2 = peliculaSerie[lstDatos.SelectedIndex];


            algo.tb_Nombre.IsEnabled = true;
            algo.tb_Año.IsEnabled = true;
            algo.tb_Director.IsEnabled = true;
            algo.cb_Genero.IsEnabled = true;
            algo.tb_Descipcion.IsEnabled = true;
            algo.tb_Rating.IsEnabled = true;
            algo.tb_Temporadas.IsEnabled = true;
            algo.l_Rating.Visibility = Visibility.Visible;
            algo.tb_Rating.Visibility = Visibility.Visible;


            if (algo2.Rating == 0)
            {

            }
            if (algo2.Rating == 1)
            {
                algo.e1.Visibility = Visibility.Hidden;
            }
            if (algo2.Rating == 2)
            {
                algo.e2.Visibility = Visibility.Hidden;
            }
            if (algo2.Rating == 3)
            {
                algo.e3.Visibility = Visibility.Hidden;
            }
            if (algo2.Rating == 4)
            {
                algo.e4.Visibility = Visibility.Hidden;
            }
            if (algo2.Rating == 5)
            {
                algo.e5.Visibility = Visibility.Hidden;
            }
            if (algo2.Rating > 5 || algo2.Rating < 0)
            {
                algo.novalido.Visibility = Visibility.Hidden;
            }


            btnEditarElemento.Visibility = Visibility.Hidden;

            btnActualizarElemento.Visibility = Visibility.Visible;
        }

        private void BtnActualizarElemento_Click(object sender, RoutedEventArgs e)
        {
            var algo = ((Datos)(grdVisualizar.Children[0]));
            var algo2 = peliculaSerie[lstDatos.SelectedIndex];

            if (algo.tb_Nombre.Text == string.Empty || algo.tb_Año.Text == string.Empty || algo.cb_Genero.Text == string.Empty || algo.tb_Director.Text == string.Empty || algo.tb_Descipcion.Text == string.Empty || algo.l_Rating.Text == string.Empty || algo.tb_Temporadas.Text == string.Empty && algo2.Seccion == "Serie")
            {

            }
            if (algo.tb_Nombre.Text == string.Empty || algo.tb_Año.Text == string.Empty || algo.cb_Genero.Text == string.Empty || algo.tb_Director.Text == string.Empty || algo.tb_Descipcion.Text == string.Empty || algo.l_Rating.Text == string.Empty && algo2.Seccion == "Pelicula")
            {

            }
            else
            {
                algo2.Titulo = algo.tb_Nombre.Text;
                algo2.Año = Convert.ToInt32(algo.tb_Año.Text);
                algo2.Director = algo.tb_Director.Text;
                algo2.Genero = algo.cb_Genero.Text;
                algo2.Sinopsis = algo.tb_Descipcion.Text;
                algo2.Rating = Convert.ToInt32(algo.tb_Rating.Text);
                lstDatos.Items.Refresh();

                algo.tb_Nombre.IsEnabled = false;
                algo.tb_Año.IsEnabled = false;
                algo.tb_Director.IsEnabled = false;
                algo.cb_Genero.IsEnabled = false;
                algo.lDesSinop.IsEnabled = false;
                algo.tb_Temporadas.IsEnabled = false;
                algo.tb_Rating.IsEnabled = false;

                btnActualizarElemento.Visibility = Visibility.Hidden;

                btnEditarElemento.Visibility = Visibility.Visible;

            }


        }

        private void BtnEliminarElemento_Click(object sender, RoutedEventArgs e)
        {
            if (lstDatos.SelectedIndex != -1)
            {
                peliculaSerie.RemoveAt(lstDatos.SelectedIndex);
            }

            grdVisualizar.Children.Clear();
            lstDatos.Items.Refresh();

            btnAgregarElemento.Visibility = Visibility.Visible;

            btnAñoMm.Visibility = Visibility.Visible;

            btnTituloAZ.Visibility = Visibility.Visible;

            btnTituloZA.Visibility = Visibility.Visible;

            btnAñomM2.Visibility = Visibility.Visible;

            btnAñoMm.Visibility = Visibility.Visible;

            btnCancelar.Visibility = Visibility.Hidden;

            btnGuardarElemento.Visibility = Visibility.Hidden;

            btnEditarElemento.Visibility = Visibility.Hidden;

            btnEliminarElemento.Visibility = Visibility.Hidden;

        }

    }
}