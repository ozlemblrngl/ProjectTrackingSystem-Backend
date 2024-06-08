using Core.Business.Rules;

namespace Business.Rules
{
    public class ProjectBusinessRules : BaseBusinessRules
    {
        IProjectDal _projectDal;

        public ProjectBusinessRules(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

    }
}
