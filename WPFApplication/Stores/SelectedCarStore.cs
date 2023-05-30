using System;
using WPFApplication.Models;

namespace WPFApplication.Stores
{
    public class SelectedCarStore
    {
        private Car _selectedCar;
        public Car SelectedCar
        {
            get
            {
                return _selectedCar;
            }
            set
            {
                _selectedCar = value;
                SelectedCarChanged?.Invoke();
            }
        }

        public event Action SelectedCarChanged;

        private readonly CarsStore _carsStore;

        public SelectedCarStore(CarsStore carsStore)
        {
            _carsStore = carsStore;

            _carsStore.CarUpdated += _carsStore_CarUpdated;
        }

        private void _carsStore_CarUpdated(Car car)
        {
            if (car.Id == SelectedCar?.Id)
            {
                SelectedCar = car;
            }
        }
    }
}
