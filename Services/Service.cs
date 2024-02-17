using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp.Services
{
    internal class Service
    {

        public T Max<T>(List<T> product) where T : IComparable
        {
            if (product.Count == 0)
            {
                throw new Exception("List can't be empty");
            }
            T max = product.First();

            foreach (T item in product)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }
        
    }
}
