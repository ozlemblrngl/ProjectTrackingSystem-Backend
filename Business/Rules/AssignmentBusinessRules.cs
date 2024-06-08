using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules
{
    public class AssignmentBusinessRules : BaseBusinessRules
    {
        IAssignmentDal _assignmentDal;

        public AssignmentBusinessRules(IAssignmentDal assignmentDal)
        {
            _assignmentDal = assignmentDal;
        }

    }
}
