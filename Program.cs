using EstudosCSharp.Entities;
using EstudosCSharp.Services;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Digite o número de produtos");
            int number = Convert.ToInt32(Console.ReadLine());
            List<Product> list = new List<Product>(); 

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Digite os produtos");
                string[] vect = Console.ReadLine().Split(',');

                list.Add(new Product(vect[0], Convert.ToInt32(vect[1])));
            }

            Console.WriteLine("Max: " + new Service().Max(list));
            Console.ReadKey();
        }
    }
}
