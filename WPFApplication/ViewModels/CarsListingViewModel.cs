using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApplication.ViewModels
{
    public class CarsListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CarListingItemViewModel> _carsListingItemViewModels;

        public CarsListingViewModel()
        {
            _carsListingItemViewModels = new ObservableCollection<CarListingItemViewModel>
            {
                new CarListingItemViewModel("Toyota", "Supra", "V8", 1990, 125000, "Red", 200000),
                new CarListingItemViewModel("BMW", "430i", "3.0", 2014, 100000, "Black", 100000),
                new CarListingItemViewModel("Porsche", "992 GT3", "4.5", 2015, 25000, "Yellow", 1000000)
            };
        }

        public IEnumerable<CarListingItemViewModel> CarsListingItemViewModels => _carsListingItemViewModels;
    }
}
