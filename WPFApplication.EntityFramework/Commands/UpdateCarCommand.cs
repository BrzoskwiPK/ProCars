using WPFApplication.Domain.Commands;
using WPFApplication.Domain.Models;
using WPFApplication.EntityFramework.DTOs;

namespace WPFApplication.EntityFramework.Commands
{
    /// <summary>
    /// Represents a command to update a car.
    /// </summary>
    public class UpdateCarCommand : IUpdateCarCommand
    {
        private readonly CarsDbContextFactory _contextFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCarCommand"/> class.
        /// </summary>
        /// <param name="contextFactory">The factory for creating <see cref="CarsDbContext"/>.</param>
        public UpdateCarCommand(CarsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        /// <summary>
        /// Executes the command to update a car.
        /// </summary>
        /// <param name="car">The car with updated information.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task Execute(Car car)
        {
            using (CarsDbContext context = _contextFactory.Create())
            {
                CarDTO carDTO = new CarDTO()
                {
                    Id = car.Id,
                    Make = car.Make,
                    Model = car.Model,
                    Year = car.Year,
                    Mileage = car.Mileage,
                    Color = car.Color,
                    Price = car.Price,
                    Engine = car.Engine
                };

                context.Cars.Update(carDTO);
                await context.SaveChangesAsync();
            }
        }
    }
}
