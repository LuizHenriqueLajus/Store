using Store.Store.Domain.Commands.Interfaces;
using ICommand = Store.Store.Domain.Commands.Interfaces.ICommand;

namespace Store.Store.Domain.Handlers.Interfaces
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
