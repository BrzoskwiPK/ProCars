﻿using WPFApplication.Stores;

namespace WPFApplication.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public ViewModelBase CurrentModalViewModel => _modalNavigationStore.CurrentViewModel;
        public bool IsModalOpen => _modalNavigationStore.IsOpen;
        public CarsViewModel CarsViewModel { get; }

        public MainViewModel(ModalNavigationStore modalNavigationStore, CarsViewModel carsViewModel)
        {
            _modalNavigationStore = modalNavigationStore;
            CarsViewModel = carsViewModel;

            _modalNavigationStore.CurrentViewModelChanged += ModalNavigationStore_CurrentViewModelChanged;
        }

        protected override void Dispose()
        {
            _modalNavigationStore.CurrentViewModelChanged -= ModalNavigationStore_CurrentViewModelChanged;

            base.Dispose();
        }

        private void ModalNavigationStore_CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentModalViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
        }
    }
}
