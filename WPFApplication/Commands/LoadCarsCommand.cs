using System;
using System.Threading.Tasks;
using WPFApplication.Stores;

namespace WPFApplication.Commands
{
    /// <summary>
    /// Represents a command for loading cars.
    /// </summary>
    public class LoadCarsCommand : AsyncCommandBase
    {
        private readonly CarsStore _carsStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadCarsCommand"/> class.
        /// </summary>
        /// <param name="carsStore">The store for managing cars.</param>
        public LoadCarsCommand(CarsStore carsStore)
        {
            _carsStore = carsStore;
        }

        /// <inheritdoc/>
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
