namespace Business.Dtos.Project.Request
{
    internal class UpdateProjectRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
