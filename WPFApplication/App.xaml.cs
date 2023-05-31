using Microsoft.EntityFrameworkCore;
using System.Windows;
using WPFApplication.Domain.Commands;
using WPFApplication.Domain.Queries;
using WPFApplication.EntityFramework;
using WPFApplication.EntityFramework.Commands;
using WPFApplication.EntityFramework.Queries;
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
        private readonly CarsDbContextFactory _carsDbContextFactory;

        private readonly IGetAllCarsQuery _getAllCarsQuery;
        private readonly ICreateCarCommand _createCarCommand;
        private readonly IUpdateCarCommand _updateCarCommand;
        private readonly IDeleteCarCommand _deleteCarCommand;

        public App()
        {
            string connectionString = "Data Source=ProCars.db";

            _carsDbContextFactory = new CarsDbContextFactory(new DbContextOptionsBuilder().UseSqlite(connectionString).Options);
            _modalNavigationStore = new ModalNavigationStore();
            _getAllCarsQuery = new GetAllCarsQuery(_carsDbContextFactory);
            _createCarCommand = new CreateCarCommand(_carsDbContextFactory);
            _updateCarCommand = new UpdateCarCommand(_carsDbContextFactory);
            _deleteCarCommand = new DeleteCarCommand(_carsDbContextFactory);
            _carsStore = new CarsStore(_createCarCommand, _updateCarCommand, _deleteCarCommand, _getAllCarsQuery);
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
