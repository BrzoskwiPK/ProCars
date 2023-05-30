using WPFApplication.Domain.Models;

namespace WPFApplication.Domain.Commands
{
    public interface ICreateCarCommand
    {
        Task Execute(Car car);
    }
}
