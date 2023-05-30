using System.Windows.Input;
using WPFApplication.Models;

namespace WPFApplication.ViewModels
{
    public class CarListingItemViewModel : ViewModelBase
    {
        public Car Car { get; }

        public string Make { get;  }
        public string Model { get; }
        public string Engine { get; }
        public int Year { get; }
        public int Mileage { get; }
        public string Color { get; }
        public decimal Price { get; }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public CarListingItemViewModel(Car car)
        {
            Car = car;
        }
    }
}
