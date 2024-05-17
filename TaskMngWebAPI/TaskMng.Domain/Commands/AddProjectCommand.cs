using MediatR;
using TaskMng.Domain.Models;

namespace TaskMng.Domain.Commands
{
    public record AddProjectCommand : IRequest<Project>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectOwnerId { get; set; }
    }
}
