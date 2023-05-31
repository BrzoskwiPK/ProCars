using WPFApplication.Domain.Models;

namespace WPFApplication.Domain.Queries
{
    /// <summary>
    /// Represents an interface for a query to retrieve all cars.
    /// </summary>
    public interface IGetAllCarsQuery
    {
        /// <summary>
        /// Executes the query to retrieve all cars.
        /// </summary>
        /// <returns>A task representing the asynchronous operation that returns an enumerable collection of cars.</returns>
        Task<IEnumerable<Car>> Execute();
    }

}
