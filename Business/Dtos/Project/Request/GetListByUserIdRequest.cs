using Core.Business.Requests;

namespace Business.Dtos.Project.Request
{
    public class GetListByUserIdRequest : PageRequest
    {
        public int UserId { get; set; }
    }
}
