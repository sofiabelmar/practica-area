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
            float baser = float.Parse(baserect.Text);
            float alturar = float.Parse(alturarect.Text);

            float arect = baser * alturar;

            recttotal.Text = arect.ToString();

        }

        private void bnt2_Click(object sender, RoutedEventArgs e)
        {
            float trbase = float.Parse(basetr.Text);
            float traltura = float.Parse(altr.Text);

            float atr = (trbase * traltura) / 2;

            trtotal.Text = atr.ToString();

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            float radio = float.Parse(radcir.Text);

            float acir = 3.14160f * (radio * radio);

            cirtotal.Text = acir.ToString();
        }
    }
}
