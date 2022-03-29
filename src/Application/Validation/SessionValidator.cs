using Domain.Entities;
using FluentValidation;

namespace Application.Validation
{
    public class SessionValidator: AbstractValidator<Session>
    {
        public SessionValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Session Title cannot be empty");
            RuleFor(x => x.Start_Time).NotEmpty().WithMessage("Start Time cannot be empty");
            RuleFor(x => x.End_Time).NotEmpty().WithMessage("End Time cannot be empty");
            RuleFor(x => x.Location_Type).NotEmpty().WithMessage("Location Type cannot be empty");
            RuleFor(x => x.Day_Id).NotEmpty().WithMessage("A Session should have a Day");

        }
    }
}
