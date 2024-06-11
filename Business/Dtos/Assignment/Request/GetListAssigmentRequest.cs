using Core.Business.Requests;

namespace Business.Dtos.Assignment.Request
{
    public class GetListAssigmentRequest : PageRequest
    {
        public int ProjectId { get; set; }
    }
}
