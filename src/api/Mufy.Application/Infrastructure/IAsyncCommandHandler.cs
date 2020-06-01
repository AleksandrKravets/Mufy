using System.Threading.Tasks;

namespace Mufy.Application.Infrastructure
{
    public interface IAsyncCommandHandler<TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command);
    }

    public interface IAsyncCommandHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
    {
        Task<TResponse> HandleAsync(TCommand command);
    }
}
