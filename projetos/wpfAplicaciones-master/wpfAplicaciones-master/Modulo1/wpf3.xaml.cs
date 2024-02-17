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
using System.Windows.Shapes;

namespace wpfAplicacionesEscritorio.Modulo1
{
    /// <summary>
    /// Interaction logic for wpf3.xaml
    /// </summary>
    public partial class wpf3 : Window
    {
        public wpf3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stackPanel1.Resources.Add("Brush2", new SolidColorBrush(Colors.Brown));
        }
    }
}
