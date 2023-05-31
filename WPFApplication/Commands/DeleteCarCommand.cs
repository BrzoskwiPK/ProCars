using System;
using System.Threading.Tasks;
using WPFApplication.Domain.Models;
using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication.Commands
{
    public class DeleteCarCommand : AsyncCommandBase
    {
        private readonly CarListingItemViewModel _carListingItemViewModel;
        private readonly CarsStore _carsStore;

        public DeleteCarCommand(CarListingItemViewModel carListingItemViewModel, CarsStore carsStore)
        {
            _carListingItemViewModel = carListingItemViewModel;
            _carsStore = carsStore;
        }

        public override async Task ExecuteAsync(object? parameterr)
        {
            Car car = _carListingItemViewModel.Car;

            try
            {
                await _carsStore.Delete(car.Id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
