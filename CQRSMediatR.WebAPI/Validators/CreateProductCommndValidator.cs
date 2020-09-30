using CQRSMediatR.WebAPI.Features.Commands;
using FluentValidation;

namespace CQRSMediatR.WebAPI.Validators
{
    public class CreateProductCommndValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommndValidator()
        {
            RuleFor(c => c.Barcode).NotEmpty();
            RuleFor(c => c.Name).NotEmpty();
        }
    }
}
