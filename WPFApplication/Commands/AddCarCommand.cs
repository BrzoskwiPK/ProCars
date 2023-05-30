using System;
using System.Threading.Tasks;
using WPFApplication.Domain.Models;
using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication.Commands
{
    public class AddCarCommand : AsyncCommandBase
    {
        private readonly AddCarViewModel _addCarViewModel;
        private readonly CarsStore _carsStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public AddCarCommand(AddCarViewModel addCarViewModel, CarsStore carsStore, ModalNavigationStore modalNavigationStore)
        {
            _addCarViewModel = addCarViewModel;
            _carsStore = carsStore;
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object? parameterr)
        {
            CarDetailsFormViewModel formViewModel = _addCarViewModel.CarDetailsFormViewModel;
            Car car = new(
                Guid.NewGuid(),
                formViewModel.Make,
                formViewModel.Model,
                formViewModel.Year,
                formViewModel.Color,
                formViewModel.Mileage,
                formViewModel.Engine,
                formViewModel.Price);

            try
            {
                await _carsStore.Add(car);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
