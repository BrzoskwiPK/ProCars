using System;
using System.Threading.Tasks;
using WPFApplication.Domain.Models;
using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication.Commands
{
    /// <summary>
    /// Represents a command for deleting a car.
    /// </summary>
    public class DeleteCarCommand : AsyncCommandBase
    {
        private readonly CarListingItemViewModel _carListingItemViewModel;
        private readonly CarsStore _carsStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCarCommand"/> class.
        /// </summary>
        /// <param name="carListingItemViewModel">The view model for the car listing item.</param>
        /// <param name="carsStore">The store for managing cars.</param>
        public DeleteCarCommand(CarListingItemViewModel carListingItemViewModel, CarsStore carsStore)
        {
            _carListingItemViewModel = carListingItemViewModel;
            _carsStore = carsStore;
        }

        /// <inheritdoc/>
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
