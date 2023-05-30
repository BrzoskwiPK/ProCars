using WPFApplication.Domain.Models;

namespace WPFApplication.Domain.Commands
{
    public interface IUpdateCarCommand
    {
        Task Execute(Car car);
    }
}
