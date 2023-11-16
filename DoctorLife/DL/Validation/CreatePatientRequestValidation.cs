using DoctorLife.DL.DTO.Request;
using FluentValidation;

namespace DoctorLife.DL.Validation
{
    public class CreatePatientRequestValidation : AbstractValidator<CreatePatientRequest>
    {
        public CreatePatientRequestValidation()
        {
            RuleFor(request => request.Name)
                .NotEmpty()
                .MinimumLength(2);

            RuleFor(request => request.Cpf)
                .NotEmpty()
                .MinimumLength(11)
                .MaximumLength(11);

            RuleFor(request => request.Birthday)
                .NotEmpty()
                .LessThanOrEqualTo(DateTime.Now);
        }
    }
}
