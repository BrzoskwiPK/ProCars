using System;
using System.Threading.Tasks;
using WPFApplication.Domain.Models;
using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication.Commands
{
    /// <summary>
    /// Represents a command for editing a car.
    /// </summary>
    public class EditCarCommand : AsyncCommandBase
    {
        private readonly EditCarViewModel _editCarViewModel;
        private readonly CarsStore _carsStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCarCommand"/> class.
        /// </summary>
        /// <param name="editCarViewModel">The view model for editing a car.</param>
        /// <param name="carsStore">The store for managing cars.</param>
        /// <param name="modalNavigationStore">The store for modal navigation.</param>
        public EditCarCommand(EditCarViewModel editCarViewModel, CarsStore carsStore, ModalNavigationStore modalNavigationStore)
        {
            _editCarViewModel = editCarViewModel;
            _carsStore = carsStore;
            _modalNavigationStore = modalNavigationStore;
        }

        /// <inheritdoc/>
        public override async Task ExecuteAsync(object? parameterr)
        {
            CarDetailsFormViewModel formViewModel = _editCarViewModel.CarDetailsFormViewModel;

            Car car = new(
                _editCarViewModel.CarId,
                formViewModel.Make,
                formViewModel.Model,
                formViewModel.Year,
                formViewModel.Color,
                formViewModel.Mileage,
                formViewModel.Engine,
                formViewModel.Price);

            try
            {
                await _carsStore.Update(car);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
