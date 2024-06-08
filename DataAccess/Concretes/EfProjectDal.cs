using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfProjectDal : EfRepositoryBase<Project, int, ProjectTrackingSystemContext>, IProjectDal
    {
        public EfProjectDal(ProjectTrackingSystemContext context) : base(context)
        {
        }
    }
}
