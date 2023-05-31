using System;
using System.Windows.Input;
using WPFApplication.Commands;
using WPFApplication.Domain.Models;
using WPFApplication.Stores;

namespace WPFApplication.ViewModels
{
    public class EditCarViewModel : ViewModelBase
    {
        public Guid CarId { get; }
        public CarDetailsFormViewModel CarDetailsFormViewModel { get; }

        public EditCarViewModel(Car car, CarsStore carsStore, ModalNavigationStore modalNavigationStore)
        {
            CarId = car.Id;

            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            ICommand submitCommand = new EditCarCommand(this, carsStore, modalNavigationStore);

            CarDetailsFormViewModel = new CarDetailsFormViewModel(submitCommand, cancelCommand)
            {
                Make = car.Make,
                Model = car.Model,
                Year = car.Year,
                Mileage = car.Mileage,
                Engine = car.Engine,
                Price = car.Price,
                Color = car.Color
            };
        }
    }
}
