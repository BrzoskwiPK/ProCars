using System;
using System.Threading.Tasks;
using WPFApplication.Stores;

namespace WPFApplication.Commands
{
    public class LoadCarsCommand : AsyncCommandBase
    {
        private readonly CarsStore _carsStore;

        public LoadCarsCommand(CarsStore carsStore)
        {
            _carsStore = carsStore;
        }

        public override async Task ExecuteAsync(object? parameterr)
        {
            try
            {
                await _carsStore.Load();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
