using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface ICoomand : ICommand<Unit>
    {

    }
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
