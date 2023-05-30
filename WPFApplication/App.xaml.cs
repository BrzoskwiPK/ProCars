using System.Windows;
using WPFApplication.ViewModels;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new CarsViewModel()
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
