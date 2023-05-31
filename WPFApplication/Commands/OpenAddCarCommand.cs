using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication.Commands
{
    /// <summary>
    /// Represents a command for opening the add car view.
    /// </summary>
    public class OpenAddCarCommand : CommandBase
    {
        private readonly CarsStore _carsStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAddCarCommand"/> class.
        /// </summary>
        /// <param name="carsStore">The store for managing cars.</param>
        /// <param name="modalNavigationStore">The store for modal navigation.</param>
        public OpenAddCarCommand(CarsStore carsStore, ModalNavigationStore modalNavigationStore)
        {
            _carsStore = carsStore;
            _modalNavigationStore = modalNavigationStore;
        }

        /// <inheritdoc/>
        public override void Execute(object? parameter)
        {
            AddCarViewModel addCarViewModel = new AddCarViewModel(_carsStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = addCarViewModel;
        }
    }

}
