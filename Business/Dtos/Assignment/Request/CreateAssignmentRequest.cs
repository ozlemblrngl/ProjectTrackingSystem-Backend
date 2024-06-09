namespace Business.Dtos.Assignment.Request
{
    public class CreateAssignmentRequest
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Status { get; set; }

    }
}
