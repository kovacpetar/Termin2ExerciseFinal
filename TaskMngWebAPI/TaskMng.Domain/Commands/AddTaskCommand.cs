using MediatR;
using TaskMng.Domain.Models;

namespace TaskMng.Domain.Commands
{
    public record AddTaskCommand : IRequest<ToDoTask>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
    }
}
