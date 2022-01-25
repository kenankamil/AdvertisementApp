using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.UI.Models;

namespace Kenan.AdvertisementApp.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.GenderId).NotEmpty();
            RuleFor(x => x.Firstname).NotEmpty();
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Surname).NotEmpty();
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.Password).MinimumLength(3);
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Password Not Match");

            RuleFor(x => x.Username).MinimumLength(3);
            RuleFor(x => new
            {
                x.Username,
                x.Firstname
            }).Must(x => CanNotFirstName(x.Firstname, x.Username)).WithMessage("Username can not contains Firsname").When(x=>x.Username!=null && x.Firstname!=null);
  
        }

        private bool CanNotFirstName(string firstname, string username)
        {
            return !username.Contains(firstname);
        }
    }
}
