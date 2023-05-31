using Microsoft.EntityFrameworkCore;
using WPFApplication.Domain.Models;
using WPFApplication.Domain.Queries;
using WPFApplication.EntityFramework.DTOs;

namespace WPFApplication.EntityFramework.Queries
{
    /// <summary>
    /// Represents a query to retrieve all cars.
    /// </summary>
    public class GetAllCarsQuery : IGetAllCarsQuery
    {
        private readonly CarsDbContextFactory _contextFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllCarsQuery"/> class with the specified context factory.
        /// </summary>
        /// <param name="contextFactory">The factory for creating the CarsDbContext.</param>
        public GetAllCarsQuery(CarsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        /// <summary>
        /// Executes the query to retrieve all cars.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The task result contains the collection of cars.</returns>
        public async Task<IEnumerable<Car>> Execute()
        {
            using (CarsDbContext context = _contextFactory.Create())
            {
                // Simulate a delay of 2 seconds to mimic an asynchronous operation
                await Task.Delay(2000);

                IEnumerable<CarDTO> carsDTOs = await context.Cars.ToListAsync();

                return carsDTOs.Select(y => new Car(y.Id, y.Make, y.Model, y.Year, y.Color, y.Mileage, y.Engine, y.Price));
            }
        }
    }

}
