namespace TaskMng.Domain.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int ProjectOwnerId { get; set; }
        public User ProjectOwner { get; set; }

        public ICollection<ToDoTask> Tasks { get; set; }

    }
}
