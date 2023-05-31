using WPFApplication.Domain.Models;

namespace WPFApplication.Domain.Commands
{
    /// <summary>
    /// Represents an interface for a command to create a car.
    /// </summary>
    public interface ICreateCarCommand
    {
        /// <summary>
        /// Executes the command to create a car.
        /// </summary>
        /// <param name="car">The car to be created.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task Execute(Car car);
    }

}
