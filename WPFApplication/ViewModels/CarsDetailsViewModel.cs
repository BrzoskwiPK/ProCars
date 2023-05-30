using WPFApplication.Domain.Models;
using WPFApplication.Stores;

namespace WPFApplication.ViewModels
{
    public class CarsDetailsViewModel : ViewModelBase
    {
        private readonly SelectedCarStore _selectedCarStore;

        private Car SelectedCar => _selectedCarStore.SelectedCar;

        public bool HasSelectedCar => SelectedCar != null;
        public string Make => SelectedCar?.Make ?? "Unknown";
        public string Model => SelectedCar?.Model ?? "Unknown";
        public int Year => SelectedCar?.Year ?? 0;
        public string Color => SelectedCar?.Color ?? "Unknown";
        public int Mileage => SelectedCar?.Mileage ?? 0;
        public string Engine => SelectedCar?.Engine ?? "Unknown";
        public decimal Price => SelectedCar?.Price ?? 0;

        public CarsDetailsViewModel(SelectedCarStore selectedCarStore)
        {
            _selectedCarStore = selectedCarStore;

            _selectedCarStore.SelectedCarChanged += SelectedCarStore_SelectedCarChanged;
        }

        protected override void Dispose()
        {
            _selectedCarStore.SelectedCarChanged -= SelectedCarStore_SelectedCarChanged;

            base.Dispose();
        }

        private void SelectedCarStore_SelectedCarChanged()
        {
            OnPropertyChanged(nameof(HasSelectedCar));
            OnPropertyChanged(nameof(Make));
            OnPropertyChanged(nameof(Model));
            OnPropertyChanged(nameof(Year));
            OnPropertyChanged(nameof(Color));
            OnPropertyChanged(nameof(Mileage));
            OnPropertyChanged(nameof(Engine));
            OnPropertyChanged(nameof(Price));
        }
    }
}
