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
using Wisdom.Models;

namespace Wisdom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product? product = FindResource("product1") as Product;
            if (product != null)
            {
                product.Name = "W";
                product.Description = "Z";
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var newProduct = new Product();
            var productDetailWindow = new ProductDetail(newProduct);

            if (productDetailWindow.ShowDialog() == true)
            {
                ((DataSource)DataContext).AddProduct(newProduct);
            }
        }
    }
}
