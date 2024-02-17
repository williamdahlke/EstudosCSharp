using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp.Entities
{
    internal class Product : IComparable, ICloneable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("This object isn't a product!");
            }

            Product other = (Product)obj;
            return Price.CompareTo(other.Price);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
