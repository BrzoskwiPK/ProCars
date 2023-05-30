using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApplication.Models;
using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication.Commands
{
    public class EditCarCommand : AsyncCommandBase
    {
        private readonly EditCarViewModel _editCarViewModel;
        private readonly CarsStore _carsStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public EditCarCommand(EditCarViewModel editCarViewModel, CarsStore carsStore, ModalNavigationStore modalNavigationStore)
        {
            _editCarViewModel = editCarViewModel;
            _carsStore = carsStore;
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object? parameterr)
        {

            CarDetailsFormViewModel formViewModel = _editCarViewModel.CarDetailsFormViewModel;

            Car car = new Car(
                _editCarViewModel.CarId,
                formViewModel.Make,
                formViewModel.Model,
                formViewModel.Year,
                formViewModel.Color,
                formViewModel.Mileage,
                formViewModel.Engine,
                formViewModel.Price);

            try
            {
                await _carsStore.Update(car);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
