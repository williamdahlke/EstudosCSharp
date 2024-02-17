using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Models
{
    internal class DataSource : BaseModel
    {
        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        public DataSource()
        {
        }

        public void AddProduct(Product product)
        {
            if (_products == null)
            {
                _products = new ObservableCollection<Product>();
            }
            _products.Add(product);
            OnPropertyChanged(nameof(Products));
        }

    }
}
