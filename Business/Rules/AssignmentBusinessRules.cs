using Core.Business.Rules;

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
