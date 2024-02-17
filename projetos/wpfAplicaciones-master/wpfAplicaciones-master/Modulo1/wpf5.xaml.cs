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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpfAplicacionesEscritorio.Modulo1
{
    /// <summary>
    /// Interaction logic for wpf5.xaml
    /// </summary>
    public partial class wpf5 : Window
    {
        public wpf5()
        {
            InitializeComponent();
        }

        private void el1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            (grid1.Resources["sb1"] as Storyboard)?.Begin();
        }
    }
}
