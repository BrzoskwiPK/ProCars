using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WPFApplication.Domain.Models;
using WPFApplication.Stores;

namespace WPFApplication.ViewModels
{
    public class CarsListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CarListingItemViewModel> _CarListingItemViewModels;
        private readonly CarsStore _carsStore;
        private readonly SelectedCarStore _selectedCarStore;
        private readonly ModalNavigationStore _modalNavigationStore;
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

        public CarsListingViewModel(SelectedCarStore selectedCarStore, ModalNavigationStore modalNavigationStore, CarsStore carsStore)
        {
            _carsStore = carsStore;
            _selectedCarStore = selectedCarStore;
            _modalNavigationStore = modalNavigationStore;
            _CarListingItemViewModels = new ObservableCollection<CarListingItemViewModel>();

            _carsStore.CarAdded += CarsStore_CarAdded;
            _carsStore.CarUpdated += CarsStore_CarUpdated;
        }

        protected override void Dispose()
        {
            _carsStore.CarAdded -= CarsStore_CarAdded;
            _carsStore.CarUpdated -= CarsStore_CarUpdated;

            base.Dispose();
        }

        public IEnumerable<CarListingItemViewModel> CarListingItemViewModels => _CarListingItemViewModels;

        private void AddCar(Car car)
        {
            CarListingItemViewModel itemViewModel = new CarListingItemViewModel(car, _carsStore, _modalNavigationStore);
            _CarListingItemViewModels.Add(itemViewModel);
        }

        private void CarsStore_CarAdded(Car car)
        {
            AddCar(car);
        }

        private void CarsStore_CarUpdated(Car car)
        {
            CarListingItemViewModel? carViewModel = _CarListingItemViewModels.FirstOrDefault(entry => entry.Car.Id == car.Id);

            if (carViewModel != null)
                carViewModel.Update(car);
        }
    }
}
