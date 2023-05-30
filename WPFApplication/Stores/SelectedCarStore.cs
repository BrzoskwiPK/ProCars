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
    }
}
