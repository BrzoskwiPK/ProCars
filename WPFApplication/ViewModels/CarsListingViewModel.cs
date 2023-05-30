using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFApplication.Commands;
using WPFApplication.Models;
using WPFApplication.Stores;

namespace WPFApplication.ViewModels
{
    public class CarsListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CarListingItemViewModel> _carsListingItemViewModels;
        private readonly SelectedCarStore _selectedCarStore;
        private CarListingItemViewModel _selectedCarListingItemViewModel;

        public CarListingItemViewModel SelectedCarListingItemViewModel
        {
            get
            {
                return _selectedCarListingItemViewModel;
            }
            set
            {
                _selectedCarListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedCarListingItemViewModel));

                _selectedCarStore.SelectedCar = _selectedCarListingItemViewModel?.Car;
            }
        }

        public CarsListingViewModel(SelectedCarStore selectedCarStore, ModalNavigationStore modalNavigationStore)
        {
            _selectedCarStore = selectedCarStore;

            _carsListingItemViewModels = new ObservableCollection<CarListingItemViewModel>();
            AddCar(new Car(new Guid(), "Toyota", "Supra", 1920, "Red", 192000, "V8", 120000), modalNavigationStore);
            AddCar(new Car(new Guid(), "BMW", "430i", 2015, "Black", 20000, "3.0", 200000), modalNavigationStore);
            AddCar(new Car(new Guid(), "BMW", "440i", 2016, "Black", 20000, "3.0", 200000), modalNavigationStore);
        }

        public IEnumerable<CarListingItemViewModel> CarsListingItemViewModels => _carsListingItemViewModels;

        private void AddCar(Car car, ModalNavigationStore modalNavigationStore)
        {
            ICommand editCommand = new OpenEditCarCommand(car, modalNavigationStore);
            _carsListingItemViewModels.Add(new CarListingItemViewModel(car, editCommand));
        }
    }
}
