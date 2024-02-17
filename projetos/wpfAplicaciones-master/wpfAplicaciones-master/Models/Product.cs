using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Wisdom.Models
{
    public class Product : BaseModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(); }
        }

        private decimal? _price;

        public decimal? Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public Product()
        {

        }

        public Product(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
