using WPFApplication.Domain.Models;
using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication.Commands
{
    /// <summary>
    /// Represents a command for opening the edit car view.
    /// </summary>
    public class OpenEditCarCommand : CommandBase
    {
        private readonly CarListingItemViewModel _carListingItemViewModel;
        private readonly CarsStore _carsStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenEditCarCommand"/> class.
        /// </summary>
        /// <param name="carListingItemViewModel">The view model for the car listing item.</param>
        /// <param name="carsStore">The store for managing cars.</param>
        /// <param name="modalNavigationStore">The store for modal navigation.</param>
        public OpenEditCarCommand(CarListingItemViewModel carListingItemViewModel, CarsStore carsStore, ModalNavigationStore modalNavigationStore)
        {
            _carListingItemViewModel = carListingItemViewModel;
            _carsStore = carsStore;
            _modalNavigationStore = modalNavigationStore;
        }

        /// <inheritdoc/>
        public override void Execute(object? parameter)
        {
            Car car = _carListingItemViewModel.Car;
            EditCarViewModel editCarViewModel = new EditCarViewModel(car, _carsStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editCarViewModel;
        }
    }

}
