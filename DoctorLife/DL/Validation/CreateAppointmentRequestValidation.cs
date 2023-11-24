using DoctorLife.DL.DTO.Request;
using FluentValidation;

namespace DoctorLife.DL.Validation
{
    public class CreateAppointmentRequestValidation : AbstractValidator<CreateAppointmentRequest>
    {
        public CreateAppointmentRequestValidation()
        {
            RuleFor(request => request.PatientId)
                .NotNull()
                .GreaterThan(0);

            RuleFor(request => request.DoctorId)
                .NotNull()
                .GreaterThan(0);

            RuleFor(request => request.Title)
                .NotEmpty()
                .NotNull();

            RuleFor(request => request.Description)
                .NotEmpty()
                .NotNull();

            RuleFor(request => request.Date)
                .NotNull()
                .GreaterThan(DateTime.Today);
        }
    }
}
