using Microsoft.EntityFrameworkCore;
using WPFApplication.Domain.Commands;
using WPFApplication.Domain.Models;
using WPFApplication.EntityFramework.DTOs;

namespace WPFApplication.EntityFramework.Commands
{
    /// <summary>
    /// Represents a command to create a car.
    /// </summary>
    public class CreateCarCommand : ICreateCarCommand
    {
        private readonly CarsDbContextFactory _contextFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCarCommand"/> class.
        /// </summary>
        /// <param name="contextFactory">The factory for creating <see cref="CarsDbContext"/>.</param>
        public CreateCarCommand(CarsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        /// <summary>
        /// Executes the command to create a new car.
        /// </summary>
        /// <param name="car">The car to be created.</param>
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

                context.Cars.Add(carDTO);
                await context.SaveChangesAsync();
            }
        }
    }
}
