using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
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

        public async Task AssignmentNameShouldBeUnique(string title)
        {
            bool doesExist = await _assignmentDal.AnyAsync(predicate: a => a.Title == title);
            if (doesExist)
                throw new BusinessException(Messages.AssignmentNameCanNotBeTheSame);
        }

    }
}
