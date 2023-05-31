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
    /// Represents the entry point for the application.
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

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            string connectionString = "Data Source=ProCars.db";

            _carsDbContextFactory = new CarsDbContextFactory(
                new DbContextOptionsBuilder()
                .UseSqlite(connectionString)
                .Options
            );
            _modalNavigationStore = new ModalNavigationStore();
            _getAllCarsQuery = new GetAllCarsQuery(_carsDbContextFactory);
            _createCarCommand = new CreateCarCommand(_carsDbContextFactory);
            _updateCarCommand = new UpdateCarCommand(_carsDbContextFactory);
            _deleteCarCommand = new DeleteCarCommand(_carsDbContextFactory);
            _carsStore = new CarsStore(_createCarCommand, _updateCarCommand, _deleteCarCommand, _getAllCarsQuery);
            _selectedCarStore = new SelectedCarStore(_carsStore);
        }

        /// <summary>
        /// Called when the application starts up.
        /// </summary>
        /// <param name="e">The event data for the startup event.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            using (CarsDbContext carsDbContext = _carsDbContextFactory.Create())
            {
                carsDbContext.Database.Migrate();
            }

            CarsViewModel carsViewModel = new CarsViewModel(_carsStore, _selectedCarStore, _modalNavigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, carsViewModel)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
