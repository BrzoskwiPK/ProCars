using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
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
            EditCarViewModel editCarViewModel = new EditCarViewModel(car, _carsStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editCarViewModel;
        }
    }
}
