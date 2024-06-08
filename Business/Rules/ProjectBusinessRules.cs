using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class ProjectBusinessRules : BaseBusinessRules
    {
        IProjectDal _projectDal;

        public ProjectBusinessRules(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public Task ProjectShouldExistWhenSelected(Project? project)
        {
            if (project == null)
                throw new BusinessException(Messages.ProjectNotExists);
            return Task.CompletedTask;
        }

    }
}
