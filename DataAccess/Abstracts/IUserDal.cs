using Core.DataAccess.Repositories;
using Core.Entities.Concrete;

namespace DataAccess.Abstracts
{
    public interface IUserDal : IRepository<User, int>, IAsyncRepository<User, int>
    {
        Task<List<OperationClaim>> GetClaims(User user);
    }
}
