namespace Business.Dtos.Project.Request
{
    public class UpdateProjectRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
