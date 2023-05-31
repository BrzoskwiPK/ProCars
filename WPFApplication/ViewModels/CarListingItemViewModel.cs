using System.Windows.Input;
using WPFApplication.Commands;
using WPFApplication.Domain.Models;
using WPFApplication.Stores;

namespace WPFApplication.ViewModels
{
    public class CarListingItemViewModel : ViewModelBase
    {
        public Car Car { get; private set; }
        public string Make => Car.Make;
        public string Model => Car.Model;
        public string Engine => Car.Engine;
        public int Year => Car.Year;
        public int Mileage => Car.Mileage;
        public string Color => Car.Color;
        public decimal Price => Car.Price;

        
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }


        public CarListingItemViewModel(Car car, CarsStore carsStore, ModalNavigationStore modalNavigationStore)
        {
            Car = car;

            EditCommand = new OpenEditCarCommand(this, carsStore, modalNavigationStore);
            DeleteCommand = new DeleteCarCommand(this, carsStore);
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
