using WPFApplication.Models;
using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication.Commands
{
    public class OpenEditCarCommand : CommandBase
    {
        private readonly CarListingItemViewModel _carListingItemViewModel;
        private readonly CarsStore _carsStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditCarCommand(CarListingItemViewModel carListingItemViewModel, CarsStore carsStore, ModalNavigationStore modalNavigationStore)
        {
            _carListingItemViewModel = carListingItemViewModel;
            _carsStore = carsStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            Car car = _carListingItemViewModel.Car;
            EditCarViewModel editCarViewModel = new(car, _carsStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editCarViewModel;
        }
    }
}
