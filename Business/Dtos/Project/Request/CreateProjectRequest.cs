namespace Business.Dtos.Project.Request
{
    public class CreateProjectRequest
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
