using WPFApplication.Domain.Models;

namespace WPFApplication.Domain.Commands
{
    /// <summary>
    /// Represents an interface for a command to update a car.
    /// </summary>
    public interface IUpdateCarCommand
    {
        /// <summary>
        /// Executes the command to update the specified car.
        /// </summary>
        /// <param name="car">The car to be updated.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task Execute(Car car);
    }

}
