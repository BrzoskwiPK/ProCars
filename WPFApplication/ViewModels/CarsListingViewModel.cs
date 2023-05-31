using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using WPFApplication.Commands;
using WPFApplication.Domain.Models;
using WPFApplication.Stores;

namespace WPFApplication.ViewModels
{
    public class CarsListingViewModel : ViewModelBase
    {
        private readonly CarsStore _carsStore;
        private readonly SelectedCarStore _selectedCarStore;
        private readonly ObservableCollection<CarListingItemViewModel> _carsListingItemViewModels;
        private readonly ModalNavigationStore _modalNavigationStore;
        public IEnumerable<CarListingItemViewModel> CarsListingItemViewModels => _carsListingItemViewModels;

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

        public ICommand LoadCarsCommand { get; }
        public CarsListingViewModel(CarsStore carsStore, SelectedCarStore selectedCarStore, ModalNavigationStore modalNavigationStore)
        {
            _carsStore = carsStore;
            _selectedCarStore = selectedCarStore;
            _modalNavigationStore = modalNavigationStore;
            _carsListingItemViewModels = new ObservableCollection<CarListingItemViewModel>();

            LoadCarsCommand = new LoadCarsCommand(carsStore);

            _carsStore.CarLoaded += _carsStore_CarLoaded;
            _carsStore.CarAdded += CarsStore_CarAdded;
            _carsStore.CarUpdated += CarsStore_CarUpdated;
            _carsStore.CarDeleted += CarsStore_CarDeleted;
        }

        private void CarsStore_CarDeleted(Guid id)
        {
            CarListingItemViewModel itemViewModel = _carsListingItemViewModels.FirstOrDefault(y => y.Car?.Id == id);

            if (itemViewModel != null)
            {
                _carsListingItemViewModels.Remove(itemViewModel);
            }
        }

        private void _carsStore_CarLoaded()
        {
            _carsListingItemViewModels.Clear();

            foreach (Car car in _carsStore.Cars)
            {
                AddCar(car);
            }
        }

        public static CarsListingViewModel LoadViewModel(CarsStore carsStore, SelectedCarStore selectedCarStore, ModalNavigationStore modalNavigationStore)
        {
            CarsListingViewModel viewModel = new CarsListingViewModel(carsStore, selectedCarStore, modalNavigationStore);

            viewModel.LoadCarsCommand.Execute(null);

            return viewModel;
        }

        protected override void Dispose()
        {
            _carsStore.CarLoaded -= _carsStore_CarLoaded;
            _carsStore.CarAdded -= CarsStore_CarAdded;
            _carsStore.CarUpdated -= CarsStore_CarUpdated;
            _carsStore.CarDeleted -= CarsStore_CarDeleted;

            base.Dispose();
        }

        private void CarsStore_CarAdded(Car car)
        {
            AddCar(car);
        }

        private void CarsStore_CarUpdated(Car car)
        {
            CarListingItemViewModel? carViewModel = _carsListingItemViewModels.FirstOrDefault(entry => entry.Car.Id == car.Id);

            if (carViewModel != null)
                carViewModel.Update(car);
        }
        private void AddCar(Car car)
        {
            CarListingItemViewModel itemViewModel = new CarListingItemViewModel(car, _carsStore, _modalNavigationStore);
            _carsListingItemViewModels.Add(itemViewModel);
        }
    }
}
