using Entities.Enums;

namespace Business.Dtos.Assignment.Response
{
    public class GetListAssignmentResponse
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public Status Status { get; set; }
    }
}
