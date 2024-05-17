namespace TaskMngWebAPI.Models
{
    public class UpdateProjectRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectOwnerId { get; set; }
    }
}
