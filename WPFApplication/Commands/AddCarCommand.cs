using System;
using System.Threading.Tasks;
using WPFApplication.Domain.Models;
using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication.Commands
{
    /// <summary>
    /// Represents a command for adding a car.
    /// </summary>
    public class AddCarCommand : AsyncCommandBase
    {
        private readonly AddCarViewModel _addCarViewModel;
        private readonly CarsStore _carsStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCarCommand"/> class.
        /// </summary>
        /// <param name="addCarViewModel">The view model for adding a car.</param>
        /// <param name="carsStore">The store for managing cars.</param>
        /// <param name="modalNavigationStore">The store for modal navigation.</param>
        public AddCarCommand(AddCarViewModel addCarViewModel, CarsStore carsStore, ModalNavigationStore modalNavigationStore)
        {
            _addCarViewModel = addCarViewModel;
            _carsStore = carsStore;
            _modalNavigationStore = modalNavigationStore;
        }

        /// <inheritdoc/>
        public override async Task ExecuteAsync(object? parameterr)
        {
            CarDetailsFormViewModel formViewModel = _addCarViewModel.CarDetailsFormViewModel;
            Car car = new(
                Guid.NewGuid(),
                formViewModel.Make,
                formViewModel.Model,
                formViewModel.Year,
                formViewModel.Color,
                formViewModel.Mileage,
                formViewModel.Engine,
                formViewModel.Price);

            try
            {
                await _carsStore.Add(car);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
