using FluentValidation;
using TaskMng.Domain.Models;
using TaskMngWebAPI.Models;

namespace TaskMngWebAPI.Validators
{
    public class AddTaskValidator : AbstractValidator<AddTaskRequest>
    {
        public AddTaskValidator()
        {
            RuleFor(t => t.Status)
                .IsInEnum()
                .WithMessage("Status could only contain values: Started, InProgress and Done.")
                .Must(BeAllowedTaskStatus).WithMessage("Invalid task Status type.");
        }

        private bool BeAllowedTaskStatus(Status status)
        {
            return status == Status.Started || status == Status.InProgress || status == Status.Done;
        }
    }
}
