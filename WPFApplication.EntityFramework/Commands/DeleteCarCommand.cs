using WPFApplication.Domain.Commands;
using WPFApplication.EntityFramework.DTOs;

namespace WPFApplication.EntityFramework.Commands
{
    /// <summary>
    /// Represents a command to delete a car.
    /// </summary>
    public class DeleteCarCommand : IDeleteCarCommand
    {
        private readonly CarsDbContextFactory _contextFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCarCommand"/> class.
        /// </summary>
        /// <param name="contextFactory">The factory for creating <see cref="CarsDbContext"/>.</param>
        public DeleteCarCommand(CarsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        /// <summary>
        /// Executes the command to delete a car.
        /// </summary>
        /// <param name="id">The identifier of the car to be deleted.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
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
