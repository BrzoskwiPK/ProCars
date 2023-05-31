using System.Windows.Input;
using WPFApplication.Commands;
using WPFApplication.Stores;

namespace WPFApplication.ViewModels
{
    public class CarsViewModel : ViewModelBase
    {
        public CarsListingViewModel CarsListingViewModel { get; }
        public CarsDetailsViewModel CarsDetailsViewModel { get; }

        public ICommand AddCarCommand { get; }

        public CarsViewModel(CarsStore carsStore, SelectedCarStore selectedCarStore, ModalNavigationStore modalNavigationStore)
        {
            CarsListingViewModel = CarsListingViewModel.LoadViewModel(carsStore, selectedCarStore, modalNavigationStore);
            CarsDetailsViewModel = new CarsDetailsViewModel(selectedCarStore);

            AddCarCommand = new OpenAddCarCommand(carsStore, modalNavigationStore);
        }
    }
}
