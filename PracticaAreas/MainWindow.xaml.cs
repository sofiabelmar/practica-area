﻿using System;
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

namespace PracticaAreas
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


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            /*float baser = float.Parse(baserect.Text);
            float alturar = float.Parse(alturarect.Text);

            float arect = baser * alturar;

            recttotal.Text = arect.ToString();*/

        }

        private void bnt2_Click(object sender, RoutedEventArgs e)
        {
            /*float trbase = float.Parse(basetr.Text);
            float traltura = float.Parse(altr.Text);

            float atr = (trbase * traltura) / 2;

            trtotal.Text = atr.ToString();*/

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
           /* float radio = float.Parse(radcir.Text);

            float acir = 3.14160f * (radio * radio);

            cirtotal.Text = acir.ToString();*/
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            /*float menor = float.Parse(bmenor.Text);
            float mayor = float.Parse(bmayor.Text);
            float altura = float.Parse(alturatrap.Text);

            float atrap = altura * ((menor + mayor) / 2);

            areatrap.Text = atrap.ToString();*/

        }

        private void cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PanelConfiguracion.Children.Clear();

            switch (cb.SelectedIndex)
            {
                case 0: //rectangulo
                    PanelConfiguracion.Children.Add(new ControlAreaRectangulo());
                    break;
                case 1: //triangulo
                    PanelConfiguracion.Children.Add(new ControlAreaTriangulo());
                    break;
                case 2:
                    PanelConfiguracion.Children.Add(new ControlAreaRectangulo());
                    break;
                case 3:
                    PanelConfiguracion.Children.Add(new ControlAreaCirculo());
                    break;
                case 4:
                    PanelConfiguracion.Children.Add(new ControlAreaTrapecio());
                    break;
                default:
                    break;
            }

        }

        private void btn1_Click_1(object sender, RoutedEventArgs e)
        {

            double area = 0.0;
            switch (cb.SelectedIndex)

            {
                case 0: //cuadrado

                    var controlAreaRectangulo = (ControlAreaRectangulo)PanelConfiguracion.Children[0];

                        float baser=  float.Parse( controlAreaRectangulo.baserect.Text);

                        float alturar = float.Parse(controlAreaRectangulo.alturarect.Text);

                         area = baser * alturar;

                     

                    break;
                case 1: //triangulo
                    break;
                case 2: //rectangulo
                    break;
                case 3:  //circulo
                    break;
                case 4: //trapecio
                    break;
            }

            lblResultadoArea.Text = area.ToString();
        }
    }
}
