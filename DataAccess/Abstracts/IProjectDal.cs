using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IProjectDal : IRepository<Project, int>, IAsyncRepository<Project, int>
    {
    }

}
