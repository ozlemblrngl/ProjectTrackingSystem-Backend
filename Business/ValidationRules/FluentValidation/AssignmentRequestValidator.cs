using Business.Constants;
using Business.Dtos.Assignment.Request;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AssignmentRequestValidator : AbstractValidator<CreateAssignmentRequest>
    {
        public AssignmentRequestValidator()
        {
            RuleFor(p => p.Title).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar); ;
            RuleFor(p => p.Description).NotEmpty().MinimumLength(5).WithMessage(Messages.MustContainAtMinfiveChar).MaximumLength(50).WithMessage(Messages.MustContainMinFiftyChar);

        }
    }
}
