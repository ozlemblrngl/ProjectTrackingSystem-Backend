using Business.Constants;
using Business.Dtos.Project.Request;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProjectRequestValidatior : AbstractValidator<CreateProjectRequest>
    {
        public ProjectRequestValidatior()
        {
            RuleFor(s => s.Name).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);

        }

    }
}
