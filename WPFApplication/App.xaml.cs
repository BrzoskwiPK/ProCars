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

        public App()
        {
            _selectedCarStore = new SelectedCarStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new CarsViewModel(_selectedCarStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
