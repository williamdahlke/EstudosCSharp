using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWpfMVVM.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Line { get; set; }
        public int Year { get; set; }

        public List<Car> GetListCars()
        {
            List<Car> list = new List<Car>()
        {
            new Car { Id = 1, Model = "Ka 1.0 SE Plus", Line = "Ford", Year = 2015 } ,
            new Car { Id = 2, Model = "C3 Exclusive 1.4", Line = "Citroen", Year = 2008}
        };
            return list;
        }

    }    
}
