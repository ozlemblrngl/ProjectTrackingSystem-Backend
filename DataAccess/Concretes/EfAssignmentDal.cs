using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    internal class EfAssignmentDal : EfRepositoryBase<Assignment, int, ProjectTrackingSystemContext>, IAssignmentDal
    {
        public EfAssignmentDal(ProjectTrackingSystemContext context) : base(context)
        {
        }
    }
}
