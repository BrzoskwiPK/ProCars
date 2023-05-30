using Microsoft.EntityFrameworkCore;
using WPFApplication.Domain.Models;
using WPFApplication.Domain.Queries;
using WPFApplication.EntityFramework.DTOs;

namespace WPFApplication.EntityFramework.Queries
{
    public class GetAllCarsQuery : IGetAllCarsQuery
    {
        private readonly CarsDbContextFactory _contextFactory;

        public GetAllCarsQuery(CarsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Car>> Execute()
        {
            using(CarsDbContext context = _contextFactory.Create())
            {
                await Task.Delay(2000);

                IEnumerable<CarDTO> carsDTOs = await context.Cars.ToListAsync();


                return carsDTOs.Select(y => new Car(y.Id, y.Make, y.Model, y.Year, y.Color, y.Mileage, y.Engine, y.Price));
            }
        }
    }
}
