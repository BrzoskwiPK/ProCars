using System.Windows.Input;
using WPFApplication.Commands;
using WPFApplication.Domain.Models;
using WPFApplication.Stores;

namespace WPFApplication.ViewModels
{
    public class CarListingItemViewModel : ViewModelBase
    {
        public Car Car { get; private set; }

        public string Make { get;  }
        public string Model { get; }
        public string Engine { get; }
        public int Year { get; }
        public int Mileage { get; }
        public string Color { get; }
        public decimal Price { get; }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public CarListingItemViewModel(Car car, CarsStore carsStore, ModalNavigationStore modalNavigationStore)
        {
            Car = car;

            EditCommand = new OpenEditCarCommand(this, carsStore, modalNavigationStore);
            
        }

        public void Update(Car car)
        {
            Car = car;

            OnPropertyChanged(nameof(Make));
            OnPropertyChanged(nameof(Model));
            OnPropertyChanged(nameof(Engine));
            OnPropertyChanged(nameof(Year));
            OnPropertyChanged(nameof(Color));
            OnPropertyChanged(nameof(Mileage));
            OnPropertyChanged(nameof(Price));
        }
    }
}
