﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public CarsViewModel(SelectedCarStore selectedCarStore, ModalNavigationStore modalNavigationStore)
        {
            CarsListingViewModel = new CarsListingViewModel(selectedCarStore, modalNavigationStore);
            CarsDetailsViewModel = new CarsDetailsViewModel(selectedCarStore);

            AddCarCommand = new OpenAddCarCommand(modalNavigationStore);
        }
    }
}
