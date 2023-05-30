namespace WPFApplication.Domain.Commands
{
    public interface IDeleteCarCommand
    {
        Task Execute(Guid id);
    }
}
