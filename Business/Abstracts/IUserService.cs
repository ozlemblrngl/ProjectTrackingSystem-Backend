using Business.Dtos.User.Requests;
using Business.Dtos.User.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;

namespace Business.Abstracts
{
    public interface IUserService
    {
        Task<GetUserResponse> Add(CreateUserRequest createUserRequest);
        Task<GetUserResponse> Update(UpdateUserRequest updateUserRequest);
        Task<GetUserResponse> Delete(DeleteUserRequest deleteUserRequest);
        Task<IPaginate<GetListUserResponse>> GetList(PageRequest pageRequest);
        Task<GetUserResponse> Get(int id);
        Task<GetUserResponse> GetByMail(string email);
        Task<List<OperationClaim>> GetClaims(User user);
    }
}
