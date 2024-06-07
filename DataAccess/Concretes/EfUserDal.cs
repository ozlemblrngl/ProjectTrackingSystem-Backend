﻿using Core.DataAccess.Repositories;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using DataAccess.Context;

namespace DataAccess.Concretes
{
    public class EfUserDal : EfRepositoryBase<User, int, ProjectTrackingSystemContext>, IUserDal
    {

        public EfUserDal(ProjectTrackingSystemContext context) : base(context)
        {

        }

        public async Task<List<OperationClaim>> GetClaims(User user)
        {

            var result = from operationClaim in Context.OperationClaims
                         join userOperationClaim in Context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.Id
                         select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
            return result.ToList();


        }
    }


}
