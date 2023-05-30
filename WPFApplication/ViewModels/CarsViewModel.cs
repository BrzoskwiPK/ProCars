using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFApplication.ViewModels
{
    public class CarsViewModel : ViewModelBase
    {
        public CarsListingViewModel CarsListingViewModel { get; }
        public CarsDetailsViewModel CarsDetailsViewModel { get; }

        public ICommand AddCarCommand { get; }

        public CarsViewModel()
        {
            CarsListingViewModel = new CarsListingViewModel();
            CarsDetailsViewModel = new CarsDetailsViewModel();
        }
    }
}
