using System.Windows;
using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedCarStore _selectedCarStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly CarsStore _carsStore;  

        public App()
        {
            _modalNavigationStore = new ModalNavigationStore();
            _carsStore = new CarsStore();
            _selectedCarStore = new SelectedCarStore(_carsStore);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            CarsViewModel carsViewModel = new CarsViewModel(_selectedCarStore, _modalNavigationStore, _carsStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, carsViewModel)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
