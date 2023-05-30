using WPFApplication.Domain.Models;

namespace WPFApplication.Domain.Queries
{
    public interface IGetAllCarsQuery
    {
        Task<IEnumerable<Car>> Execute();
    }
}
