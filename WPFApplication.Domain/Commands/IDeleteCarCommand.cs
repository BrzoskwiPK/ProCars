namespace WPFApplication.Domain.Commands
{
    /// <summary>
    /// Represents an interface for a command to delete a car.
    /// </summary>
    public interface IDeleteCarCommand
    {
        /// <summary>
        /// Executes the command to delete a car with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the car to be deleted.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task Execute(Guid id);
    }

}
