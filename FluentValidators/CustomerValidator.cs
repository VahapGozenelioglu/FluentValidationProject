using System;
using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get;} = "{PropertyName} is required";
        public CustomerValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x=>x.Email).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress().WithMessage("Email is not valid");
            RuleFor(x=>x.Age).NotEmpty().WithMessage(NotEmptyMessage).InclusiveBetween(18,60).WithMessage("Age is not valid");
            RuleFor(x=>x.BirthDay).NotEmpty().WithMessage(NotEmptyMessage).Must(x =>
            {
                return DateTime.Now.AddYears(-18) >= x;
            }).WithMessage("You must be at least 18 years old");
            RuleForEach(x => x.Addresses).SetValidator(new AddressValidator());
        }
    }
}