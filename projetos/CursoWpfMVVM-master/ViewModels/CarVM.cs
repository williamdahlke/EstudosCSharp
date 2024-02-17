using CursoWpfMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CursoWpfMVVM.Services;

namespace CursoWpfMVVM.ViewModels
{
    public class CarVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Car> Cars { get; set; }
        public ICommand GetCarsCommand { get; set; }
        public CarVM() 
        {
            GetCarsCommand = new DelegateCommand(GetCars);       
        }

        public void GetCars(object obj)
        {
            var carList = new Car().GetListCars();
            Cars = new ObservableCollection<Car>(carList as List<Car>);
            NotifyPropertyChanged(nameof(Cars));
        }

        public void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
