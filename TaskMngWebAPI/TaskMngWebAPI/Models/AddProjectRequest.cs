namespace TaskMngWebAPI.Models
{
    public class AddProjectRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectOwnerId { get; set; }
    }
}
