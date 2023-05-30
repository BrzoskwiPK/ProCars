using WPFApplication.Domain.Commands;
using WPFApplication.Domain.Models;
using WPFApplication.EntityFramework.DTOs;

namespace WPFApplication.EntityFramework.Commands
{
    public class UpdateCarCommand : IUpdateCarCommand
    {
        private readonly CarsDbContextFactory _contextFactory;

        public UpdateCarCommand(CarsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

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
