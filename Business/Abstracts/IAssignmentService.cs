using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IAssignmentService
    {
        Task<GetAssignmentResponse> Add(CreateAssignmentRequest createAssignmentRequest);
        Task<GetAssignmentResponse> Update(UpdateAssignmentRequest updateUserRequest);
        Task<GetAssignmentResponse> Delete(DeleteAssignmentRequest deleteUserRequest);
        Task<IPaginate<GetListAssignmentResponse>> GetList(PageRequest pageRequest);
        Task<GetAssignmentResponse> Get(int id);
    }
}
