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

        public App()
        {
            _selectedCarStore = new SelectedCarStore();
            _modalNavigationStore = new ModalNavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            CarsViewModel carsViewModel = new CarsViewModel(_selectedCarStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, carsViewModel)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
