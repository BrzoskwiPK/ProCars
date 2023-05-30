using WPFApplication.Domain.Commands;
using WPFApplication.EntityFramework.DTOs;

namespace WPFApplication.EntityFramework.Commands
{
    public class DeleteCarCommand : IDeleteCarCommand
    {
        private readonly CarsDbContextFactory _contextFactory;

        public DeleteCarCommand(CarsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(Guid id)
        {
            using (CarsDbContext context = _contextFactory.Create())
            {
                CarDTO carDTO = new CarDTO()
                {
                    Id = id
                };

                context.Cars.Remove(carDTO);
                await context.SaveChangesAsync();
            }
        }
    }
}
