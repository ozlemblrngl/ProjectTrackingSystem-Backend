using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;

namespace Business.Rules
{
    public class ProjectBusinessRules : BaseBusinessRules
    {
        IProjectDal _projectDal;

        public ProjectBusinessRules(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public async Task ProjectNameNotBeTheSame(string name)
        {
            bool doesExist = await _projectDal.AnyAsync(predicate: p => p.Name == name);
            if (doesExist)
                throw new BusinessException(Messages.ProjectNameCanNotBeTheSame);
        }

        public void ProjectEndDateCanNotBeBeforeStartDate(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                throw new BusinessException(Messages.EndDateCanNotBeBeforeStartDate);
            }
        }
    }
}
