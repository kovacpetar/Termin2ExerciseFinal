using MediatR;

namespace TaskMng.Domain.Commands
{
    public record DeleteUserCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
