namespace Mufy.Application.Infrastructure
{
    public interface ICommandBase
    {
    }

    public interface ICommand : ICommandBase
    {
    }

    public interface ICommand<TResponse> : ICommandBase
    {
    }
}
