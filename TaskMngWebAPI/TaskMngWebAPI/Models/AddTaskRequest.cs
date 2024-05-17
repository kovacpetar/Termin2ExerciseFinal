using TaskMng.Domain.Models;

namespace TaskMngWebAPI.Models
{
    public class AddTaskRequest 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
    }
}
